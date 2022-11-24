using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BVC_StockMarket_APP
{
    public partial class MainChart : UserControl
    {
        private string symbol { get; set; }

        InformationAPI alphaVantage = new InformationAPI();

        List<DateTime> xValues = new List<DateTime>();
        List<decimal> yValues = new List<decimal>();
        public MainChart()
        {
            InitializeComponent();

            List<string> bestMatches = alphaVantage.getBestMatches("abc");

            List<CoreStockData> alphaListMonthly = alphaVantage.getSeries("ABC", "TIME_SERIES_MONTHLY");
            List<CoreStockData> alphaListDaily = alphaVantage.getSeries("ABC", "TIME_SERIES_DAILY_ADJUSTED");
            FundamentalData[] alphaListCompany = alphaVantage.getCompanyOverview("IBM");

            //for (int i = 0; i < alphaListDaily.Count - 1; i++)
            //{
            //    if(i <= 30)
            //    {
            //        xValues.Add(alphaListDaily[i].Timestamp);
            //        yValues.Add(alphaListDaily[i].Close);
            //    }
            //}

            foreach (var item in alphaListDaily)
            {
                xValues.Add(item.Timestamp);
            }

            foreach (var item in xValues)
            {
                listBox1.Items.Add(item);
            }

            //Task<FundamentalData[]> alphaListCompany2 = alphaVantage.getCompanyOverviewAsync("IBM");

            label1.Text = alphaListMonthly.Max(u => u.Close).ToString();
            label2.Text = alphaListDaily.Min(u => u.Close).ToString();
            label3.Text = alphaListCompany[0].Description;
        }

        private void cBoxBarChart_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void setSymbol(string _symbol)
        {
            symbol = _symbol;
        }
    }
}
