using ApiConnection.Models.Market;
using ApiConnection.Models.Stock;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnection.ConnectionsModels
{
    public class ConnectionJsonModel
    {
        private string url { get; set; } = "https://apidojo-yahoo-finance-v1.p.rapidapi.com/";
        private RestClient retunRestClient()
        {
            var client = new RestClient(url);
            return client;
        }

        public List<HistoricalDataModel> Test()
        {
            var client = retunRestClient();
            var request = new RestRequest("stock/v3/get-historical-data?symbol=PFI&region=EU", Method.GET);
            request.AddHeader("x-rapidapi-key", "ce97752aecmsh6b47e4653d8152dp1ad427jsn51c60b4b4bcc");
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            var response = client.Execute<List<HistoricalDataModel>>(request).Data;

            return response;
        }
        public List<HistoricalDataModel> GetDataBySymbol(string symbol)
        {
            var client = retunRestClient();
            var request = new RestRequest("stock/v3/get-historical-data?symbol=" + symbol + "&region=EU", Method.GET);
            request.AddHeader("x-rapidapi-key", "ce97752aecmsh6b47e4653d8152dp1ad427jsn51c60b4b4bcc");
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            var response = client.Execute<List<HistoricalDataModel>>(request).Data;
            return response;
        }

        public List<Root> GetTrendingTickers_Root()
        {
            var client = retunRestClient();
            var request = new RestRequest("market/get-trending-tickers?region=US", Method.GET);
            request.AddHeader("x-rapidapi-key", "ce97752aecmsh6b47e4653d8152dp1ad427jsn51c60b4b4bcc");
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            var response = client.Execute<List<Root>>(request).Data;
            return response;
        }
     









    }
}
