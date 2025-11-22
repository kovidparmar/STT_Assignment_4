namespace OrderPipeline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCustomer = new TextBox();
            label2 = new Label();
            cmbProduct = new ComboBox();
            label3 = new Label();
            nudQuantity = new NumericUpDown();
            btnProcessOrder = new Button();
            lblStatus = new Label();
            chkExpress = new CheckBox();
            btnShipOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(226, 22);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(277, 27);
            txtCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Laptop", "", "", "Mouse", "", "", "Keyboard" });
            cmbProduct.Location = new Point(225, 122);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(226, 67);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 27);
            nudQuantity.TabIndex = 5;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.Location = new Point(75, 183);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(164, 29);
            btnProcessOrder.TabIndex = 6;
            btnProcessOrder.Text = "Process Order";
            btnProcessOrder.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(240, 393);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status will appear here";
            // 
            // chkExpress
            // 
            chkExpress.AutoSize = true;
            chkExpress.Location = new Point(85, 326);
            chkExpress.Name = "chkExpress";
            chkExpress.Size = new Size(143, 24);
            chkExpress.TabIndex = 8;
            chkExpress.Text = "Express Shipping";
            chkExpress.UseVisualStyleBackColor = true;
            // 
            // btnShipOrder
            // 
            btnShipOrder.Location = new Point(75, 244);
            btnShipOrder.Name = "btnShipOrder";
            btnShipOrder.Size = new Size(94, 29);
            btnShipOrder.TabIndex = 9;
            btnShipOrder.Text = "Ship Order";
            btnShipOrder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShipOrder);
            Controls.Add(chkExpress);
            Controls.Add(lblStatus);
            Controls.Add(btnProcessOrder);
            Controls.Add(nudQuantity);
            Controls.Add(label3);
            Controls.Add(cmbProduct);
            Controls.Add(label2);
            Controls.Add(txtCustomer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomer;
        private Label label2;
        private ComboBox cmbProduct;
        private Label label3;
        private NumericUpDown nudQuantity;
        private Button btnProcessOrder;
        private Label lblStatus;
        private CheckBox chkExpress;
        private Button btnShipOrder;
    }
}
