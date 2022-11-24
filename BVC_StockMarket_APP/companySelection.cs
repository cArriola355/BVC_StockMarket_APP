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
    public partial class companySelection : UserControl
    {
        InformationAPI alphaVantage = new InformationAPI();
        public string selectedSymbol { get; set; }

        public companySelection()
        {
            InitializeComponent();
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxBestMatches.Items.Clear();
            string inputSymbol = tboxSearch.Text;
            List<string> bestMatches = alphaVantage.getBestMatches(inputSymbol);
            foreach (var result in bestMatches)
            {
                listBoxBestMatches.Items.Add(result);
            }
        }

        private void listBoxBestMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSymbol = listBoxBestMatches.SelectedItem.ToString();   
        }
    }
}
