using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVC_StockMarket_APP
{
    public partial class Form1 : Form
    {
        private string symbol { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            //symbol = companySelection1.selectedSymbol;
            symbol = "IBM";
            lblSymbol.Text = symbol;
            MainChart mainChartX = new MainChart(symbol);
            panelChart.Controls.Add(mainChartX);
        }
    }
}
