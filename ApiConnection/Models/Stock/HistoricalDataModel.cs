using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnection.Models.Stock
{
    public class HistoricalDataModel
    {
        public List<Price> prices { get; set; }
        public bool isPending { get; set; }
        public int firstTradeDate { get; set; }
        public string id { get; set; }
        public TimeZone timeZone { get; set; }
        public List<object> eventsData { get; set; }
      
    }
}
