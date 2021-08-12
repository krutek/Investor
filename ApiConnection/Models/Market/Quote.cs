using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnection.Models.Market
{
    public class Quote
    {
        public string language { get; set; }
        public string region { get; set; }
        public string quoteType { get; set; }
        public bool triggerable { get; set; }
        public string quoteSourceName { get; set; }
        public double regularMarketPrice { get; set; }
        public int regularMarketTime { get; set; }
        public double regularMarketChange { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public string longName { get; set; }
        public string market { get; set; }
        public int priceHint { get; set; }
        public bool esgPopulated { get; set; }
        public bool tradeable { get; set; }
        public string marketState { get; set; }
        public double regularMarketChangePercent { get; set; }
        public double regularMarketPreviousClose { get; set; }
        public string fullExchangeName { get; set; }
        public string shortName { get; set; }
        public int sourceInterval { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public int gmtOffSetMilliseconds { get; set; }
        public string exchange { get; set; }
        public string symbol { get; set; }
    }

}
