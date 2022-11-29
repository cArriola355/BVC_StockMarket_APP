using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVC_StockMarket_APP
{
    public class CoreStockData
    {
        public DateTime Timestamp { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get; set; }

        public CoreStockData(DateTime timeStamp, decimal open, decimal high, decimal low, decimal close, decimal volume)
        {
            this.Timestamp = timeStamp;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
        }
    }
}
