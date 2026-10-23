using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketSimulator
{
    public class Stock
    {
        public decimal CurrentPrice { get; set; }
        public decimal PreviousPrice { get; set; }

        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }

        public long Volume { get; set; }

        public double Volatility { get; set; }      // Kursschwankungen
        public double Trend { get; set; }           // Positiv oder negativ
    }
}
