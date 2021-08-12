using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnection.Models.Market
{
    public class Finance
    {
        public List<Result> result { get; set; }
        public bool error { get; set; }
    }
}
