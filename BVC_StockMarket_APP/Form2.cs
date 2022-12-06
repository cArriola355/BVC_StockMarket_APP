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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

       
    private void HelpForm_Load(object sender, EventArgs e)
        {
            lblHelpbtn.Text = " \nThank you for using the \n" +
                "\nThe BVC Stock Market App \n" +
                "\nFor further inquiries please email us at \n" +
                "\nBVCStockMarketApp@gmail.com\n";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
