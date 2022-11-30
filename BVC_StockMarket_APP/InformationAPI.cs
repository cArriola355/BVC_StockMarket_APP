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
        //public List<CoreStockData> getSeries(string symbol, string timeSeries)
        //{
        //    var Result = $"https://www.alphavantage.co/query?function={timeSeries}&symbol={symbol}&apikey={apiKey}"
        //        .GetStringFromUrl().FromJson<Dictionary<string, string>>();

        //    char[] removeChar = { '\n', '[', ']', '{', '}', ',' };
        //    var resultArray = Result.Values.ElementAt(1).Replace("  ", String.Empty).Split(removeChar, StringSplitOptions.RemoveEmptyEntries);

        //    List<CoreStockData> resultList = new List<CoreStockData>();
        //    DateTime dTime = new DateTime();
        //    decimal open = 0;
        //    decimal high = 0;
        //    decimal low = 0;
        //    decimal close = 0;
        //    decimal volume = 0;

        //    for (var row = 0; row <= resultArray.Length - 1; row++)
        //    {
        //        if (DateTime.TryParse(resultArray[row].ToString().Replace(": ", String.Empty), out DateTime temp))
        //        {
        //            string date = resultArray[row].ToString().Replace(": ", String.Empty);
        //            dTime = DateTime.Parse(date);
        //        }
        //        if (resultArray[row].ToString().Contains("1. open:"))
        //        {
        //            open = resultArray[row].Replace("1. open: ", String.Empty).ToDecimal();
        //        }
        //        if (resultArray[row].ToString().Contains("2. high"))
        //        {
        //            high = resultArray[row].Replace("2. high: ", String.Empty).ToDecimal();
        //        }
        //        if (resultArray[row].ToString().Contains("3. low:"))
        //        {
        //            low = resultArray[row].Replace("3. low: ", String.Empty).ToDecimal();
        //        }
        //        if (resultArray[row].ToString().Contains("4. close:"))
        //        {
        //            close = resultArray[row].Replace("4. close: ", String.Empty).ToDecimal();
        //        }
        //        if (resultArray[row].ToString().Contains("5. volume"))
        //        {
        //            volume = resultArray[row].Replace("5. volume: ", String.Empty).ToDecimal();
        //        }
        //        if (row > 0 && (row + 1) % 6 == 0)
        //        {
        //            resultList.Add(new CoreStockData(dTime, open, high, low, close, volume));
        //        }
        //    }
        //    return resultList;
        //}
        public List<CoreStockData> getSeries(string symbol, string timeSeries)
        {
            //var Prices = "https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol=BBC&apikey=2QWA2DXL6S3RQ6YX&datatype=csv"
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
