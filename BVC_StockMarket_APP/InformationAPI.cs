using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using ServiceStack.Text;
using System.Net.Http;


namespace BVC_StockMarket_APP
{
    public class InformationAPI
    {
        private static string apiKey = "2QWA2DXL6S3RQ6YX";
        //private static string apiKey = "demo";

        //
        // Method to Get the Data from the input symbol
        //
        public List<CoreStockData> getSeries(string symbol, string timeSeries)
        {
            var Prices = $"https://www.alphavantage.co/query?function={timeSeries}&symbol={symbol}&apikey={apiKey}&datatype=csv"
                            .GetStringFromUrl().FromCsv<List<CoreStockData>>();
            return Prices;
        }


        //
        // Method to Get Information about the Company associated to the symbol input
        //
        public FundamentalData[] getCompanyOverview(string symbol)
        {
            var companyInfo = $"https://www.alphavantage.co/query?function=OVERVIEW&symbol={symbol}&apikey={apiKey}"
                            .GetStringFromUrl().FromJson<List<FundamentalData>>();

            return companyInfo.ToArray();
        }


        //
        // Method to Get Best Matches based on the input value on the search box
        //
        public List<string> getBestMatches(string symbol)
        {
            var searchResults = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={symbol}&apikey={apiKey}"
                .GetStringFromUrl().FromJson<Dictionary<string, string>>();

            var myArray = searchResults.Values.ToArray()[0];
            char[] removeChar = { '\n', '[', ']', '{', '}', ',' };
            var myArray2 = myArray.Replace("  ", String.Empty).Split(removeChar, StringSplitOptions.RemoveEmptyEntries);
            List<string> myList = new List<string>();

            foreach (var item in myArray2)
            {
                if (item.StartsWith("1"))
                {

                    myList.Add(item.Trim().Replace("1. symbol: ", String.Empty));
                }
            }
            return myList;
        }


    }
}
