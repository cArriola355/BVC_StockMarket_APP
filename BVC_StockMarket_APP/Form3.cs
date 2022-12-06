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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)

        {
            lblInfobtn.Text = "\n The BVC Stock Market App \n" +
               "\n Is designed to be used by students \n " +
               "\n And people interested in Stocks alike.\n" +
               "The purpose of this App is to teach the user \n" +
               "About the Stock Market and to keep up \n " +
               "To date with the current Stock market prices \n" +
               "And current in demand Stocks \n";
        }



        private void btn_ok2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
