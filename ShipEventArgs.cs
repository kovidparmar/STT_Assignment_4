using System;

namespace OrderPipeline
{
    /// <summary>
    /// Custom EventArgs for shipping events
    /// </summary>
    public class ShipEventArgs : EventArgs
    {
        public string Product { get; }
        public bool Express { get; }

        public ShipEventArgs(string product, bool express)
        {
            Product = product;
            Express = express;
        }
    }
}

