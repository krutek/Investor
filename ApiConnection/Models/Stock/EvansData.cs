using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnection.Models.Stock
{
    public class EvansData
    {
        public string id { get; set; }
        public double amount { get; set; }
        public int date { get; set; }
        public string type { get; set; }
        double data { get; set; }

    }
}
