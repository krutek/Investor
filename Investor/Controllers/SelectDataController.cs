using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiConnection.ConnectionsModels;
using ApiConnection.Models.SuppotrModels;
using ApiConnection.Models.Market;

namespace Investor.Controllers
{
    public class SelectDataController : Controller
    {
            List<SectorsModel> Sectors = new List<SectorsModel>();


            ConnectionJsonModel cjm = new ConnectionJsonModel();
            List<Root> rootList = new List<Root>();
            List<Quote> quotes = new List<Quote>();
            public IActionResult Index()
            {
                rootList = cjm.GetTrendingTickers_Root();
                quotes = TakeAllQuotes(rootList);
                return View(quotes);
            }

            public List<Quote> TakeAllQuotes(List<Root> roots)
            {
                List<Quote> toReturn = new List<Quote>();
                foreach (var root in roots)
                {
                    foreach (var results in root.finance.result)
                    {
                        foreach (var quote in results.quotes)
                        {
                            toReturn.Add(quote);
                        }
                    }
                }
                return toReturn;
            }

            private void RefullSectors()
            {
                Sectors.Add(new SectorsModel { sectorID = 1, sector = "Communication services" });
                Sectors.Add(new SectorsModel { sectorID = 2, sector = "Consumer discretionary" });
                Sectors.Add(new SectorsModel { sectorID = 3, sector = "Consumer staples" });
                Sectors.Add(new SectorsModel { sectorID = 4, sector = "Energy" });
                Sectors.Add(new SectorsModel { sectorID = 5, sector = "Financials" });
                Sectors.Add(new SectorsModel { sectorID = 6, sector = "Healthcare" });
                Sectors.Add(new SectorsModel { sectorID = 7, sector = "Industrials" });
                Sectors.Add(new SectorsModel { sectorID = 8, sector = "Information technology" });
                Sectors.Add(new SectorsModel { sectorID = 9, sector = "Materials" });
                Sectors.Add(new SectorsModel { sectorID = 10, sector = "Real estate" });
                Sectors.Add(new SectorsModel { sectorID = 11, sector = "Utilities" });
            }

        }
}

