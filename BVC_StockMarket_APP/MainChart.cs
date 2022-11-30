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
        private string internalSymbol { get; set; }
        InformationAPI alphaVantage = new InformationAPI();

        List<DateTime> xValues = new List<DateTime>();
        List<decimal> yValues = new List<decimal>();
        public MainChart(string mySymbol, string timeSeries)
        {
            InitializeComponent();
            internalSymbol = mySymbol;
            chBoxType.Text = "Bar chart";
            dataGridMain.RowTemplate.Height = 20;
            dataGridMain.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3,26,98);
            dataGridMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridMain.EnableHeadersVisualStyles = false;

            List<CoreStockData> alphaListSeries = alphaVantage.getSeries(mySymbol, timeSeries);
            FundamentalData[] alphaListCompany = alphaVantage.getCompanyOverview(mySymbol);


            for (int i = 0; i < alphaListSeries.Count - 1; i++)
            {
                if (i <= 30)
                {
                    xValues.Add(alphaListSeries[i].Timestamp);
                    yValues.Add(alphaListSeries[i].Close);
                }
                int n = dataGridMain.Rows.Add();
                if (timeSeries == "TIME_SERIES_MONTHLY")
                {
                    dataGridMain.Rows[n].Cells[0].Value = alphaListSeries[i].Timestamp.ToString("MMM-yy");
                }
                if (timeSeries == "TIME_SERIES_DAILY_ADJUSTED")
                {
                    dataGridMain.Rows[n].Cells[0].Value = alphaListSeries[i].Timestamp.ToString("dd-MMM-yy");
                }
                dataGridMain.Rows[n].Cells[1].Value = alphaListSeries[i].Open;
                dataGridMain.Rows[n].Cells[2].Value = alphaListSeries[i].High;
                dataGridMain.Rows[n].Cells[3].Value = alphaListSeries[i].Low;
                dataGridMain.Rows[n].Cells[4].Value = alphaListSeries[i].Close;
                dataGridMain.Rows[n].Cells[5].Value = alphaListSeries[i].Volume;
            }

            chartSeries.Legends.Clear();
            chartSeries.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartSeries.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            if(timeSeries == "TIME_SERIES_MONTHLY")
            {
                chartSeries.ChartAreas[0].AxisX.Title = "Last 30 Months";
                chartSeries.ChartAreas[0].AxisX.LabelStyle.Format = "MMM-yy";
            }
            if (timeSeries == "TIME_SERIES_DAILY_ADJUSTED")
            {
                chartSeries.ChartAreas[0].AxisX.Title = "Last 30 Working Days";
                chartSeries.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MMM";
            }
            chartSeries.ChartAreas[0].AxisY.Title = "Price";
            chartSeries.Series["Close"].Points.DataBindXY(xValues, yValues);
            lblOverview.Text = alphaListCompany[0].Description;
        }
        private void MainChart_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        
        private void chBoxType_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxType.Text == "Bar chart")
            {
                chBoxType.Text = "Line chart";
                chartSeries.Series["Close"].ChartType = SeriesChartType.Column;
            } else
            {
                chBoxType.Text = "Bar chart";
                chartSeries.Series["Close"].ChartType = SeriesChartType.Line;
            }
        }

        private void btnMaxChart_Click(object sender, EventArgs e)
        {
            MaxChart newWindow = new MaxChart();
            newWindow.Text = "Symbol: " + internalSymbol + " - Maximized chart";
            Chart newChart = new Chart();
            newChart = chartSeries;
            newChart.Size = new Size(newWindow.myPanel.Width - 20, newWindow.myPanel.Height - 50);
            newWindow.myPanel.Controls.Add(newChart);
            newWindow.Show();
        }

        private void btnExportXLS_Click(object sender, EventArgs e)
        {
            // Code snippet from: https://www.c-sharpcorner.com/UploadFile/hrojasara/export-datagridview-to-excel-in-C-Sharp/
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGridMain.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridMain.Columns[i - 1].HeaderText;
            } 
            for (int i = 0; i < dataGridMain.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridMain.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridMain.Rows[i].Cells[j].Value.ToString();
                }
            }
            app.Quit();
        }
    }
}
