using System;
using System.Windows.Forms;

namespace OrderPipeline
{
    public partial class Form1 : Form
    {
        // --- Flags & Events ---

        // Track whether the latest order is confirmed
        private bool _orderConfirmed = false;

        // Task 1 events
        public event EventHandler<OrderEventArgs> OrderCreated;
        public event EventHandler OrderRejected;
        public event EventHandler<OrderEventArgs> OrderConfirmed;

        // Task 2 event
        public event EventHandler<ShipEventArgs> OrderShipped;

        public Form1()
        {
            InitializeComponent();

            // Subscribe to events (event chaining)
            OrderCreated += ValidateOrder;      // validates & may chain
            OrderCreated += DisplayOrderInfo;   // shows MessageBox

            OrderRejected += ShowRejection;     // invalid order handler
            OrderConfirmed += ShowConfirmation; // valid order handler

            // OrderShipped always has ShowDispatch
            OrderShipped += ShowDispatch;

            // Wire button click handlers (in case you didn't via Designer)
            btnProcessOrder.Click += BtnProcessOrder_Click;
            btnShipOrder.Click += BtnShipOrder_Click;
        }

        // ============================
        //  Task 1: Process Order flow
        // ============================

        private void BtnProcessOrder_Click(object sender, EventArgs e)
        {
            string customer = txtCustomer.Text.Trim();
            string product = cmbProduct.SelectedItem as string;
            int quantity = (int)nudQuantity.Value;

            _orderConfirmed = false; // new order, reset flag
            lblStatus.Text = "Processing order...";

            var args = new OrderEventArgs(customer, product, quantity);

            // Raise OrderCreated – this triggers ValidateOrder + DisplayOrderInfo
            OrderCreated?.Invoke(this, args);
        }

        // Subscriber 1 for OrderCreated
        private void ValidateOrder(object sender, OrderEventArgs e)
        {
            if (e.Quantity > 0)
            {
                lblStatus.Text = "Validated";

                // If valid, chain to OrderConfirmed
                OrderConfirmed?.Invoke(this, e);
            }
            else
            {
                // Invalid -> fire OrderRejected
                OrderRejected?.Invoke(this, EventArgs.Empty);
            }
        }

        // Subscriber 2 for OrderCreated
        private void DisplayOrderInfo(object sender, OrderEventArgs e)
        {
            MessageBox.Show(
                $"Customer: {e.Customer}\nProduct: {e.Product}\nQuantity: {e.Quantity}",
                "Order Summary");
        }

        // Subscriber for OrderRejected
        private void ShowRejection(object sender, EventArgs e)
        {
            lblStatus.Text = "Order Invalid – Please retry";
            _orderConfirmed = false;
        }

        // Subscriber for OrderConfirmed
        private void ShowConfirmation(object sender, OrderEventArgs e)
        {
            _orderConfirmed = true;
            lblStatus.Text = $"Order Processed Successfully for {e.Customer}";
        }

        // ======================================
        //  Task 2: Shipping, filtering, dynamic
        // ======================================

        private void BtnShipOrder_Click(object sender, EventArgs e)
        {
            // Only allow shipping if last order was confirmed
            if (!_orderConfirmed)
            {
                MessageBox.Show(
                    "Please process and confirm a valid order before shipping.",
                    "Order not confirmed");
                return;
            }

            string product = cmbProduct.SelectedItem as string;
            bool express = chkExpress.Checked;

            // Dynamic subscriber management (event filtering):
            // 1. Always remove NotifyCourier first to avoid duplicates.
            OrderShipped -= NotifyCourier;

            // 2. Add it only when Express is checked.
            if (express)
            {
                OrderShipped += NotifyCourier;
            }

            var shipArgs = new ShipEventArgs(product, express);

            // Raise OrderShipped – calls ShowDispatch and maybe NotifyCourier
            OrderShipped?.Invoke(this, shipArgs);
        }

        // Subscriber 1 for OrderShipped
        private void ShowDispatch(object sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product}";
        }

        // Subscriber 2 for OrderShipped (added/removed dynamically)
        private void NotifyCourier(object sender, ShipEventArgs e)
        {
            if (e.Express)
            {
                MessageBox.Show("Express delivery initiated!", "Courier Notification");
            }
        }
    }
}
