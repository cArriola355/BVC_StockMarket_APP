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
        InformationAPI alphaVantage = new InformationAPI();

        List<DateTime> xValues = new List<DateTime>();
        List<decimal> yValues = new List<decimal>();
        public MainChart(string mySymbol)
        {
            InitializeComponent();

            List<string> bestMatches = alphaVantage.getBestMatches(mySymbol);

            //List<CoreStockData> alphaListMonthly = alphaVantage.getSeries(mySymbol, "TIME_SERIES_MONTHLY");
            List<CoreStockData> alphaListDaily = alphaVantage.getSeries(mySymbol, "TIME_SERIES_DAILY_ADJUSTED");
            FundamentalData[] alphaListCompany = alphaVantage.getCompanyOverview(mySymbol);

            for (int i = 0; i < alphaListDaily.Count - 1; i++)
            {
                if (i <= 10)
                {
                    xValues.Add(alphaListDaily[i].Timestamp);
                    yValues.Add(alphaListDaily[i].Close);
                }
            }

            chartSeries.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
            chartSeries.Legends.Clear();
            chartSeries.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartSeries.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartSeries.ChartAreas[0].AxisX.Title = "Days";
            chartSeries.ChartAreas[0].AxisY.Title = "Price";
            chartSeries.Series["Close"].Points.DataBindXY(xValues, yValues);
            lblOverview.Text = alphaListCompany[0].Description;

            tableData.ColumnCount = 6;
            

            //Task<FundamentalData[]> alphaListCompany2 = alphaVantage.getCompanyOverviewAsync("IBM");

            //label1.Text = alphaListMonthly.Max(u => u.Close).ToString();
            //label2.Text = alphaListDaily.Min(u => u.Close).ToString();

        }
        private void MainChart_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void lblOverview_Click(object sender, EventArgs e)
        {

        }
    }
}
