using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnection.Models.Market
{
    public class Result
    {
        public int count { get; set; }
        public List<Quote> quotes { get; set; }
        public long jobTimestamp { get; set; }
        public long startInterval { get; set; }
    }
}
