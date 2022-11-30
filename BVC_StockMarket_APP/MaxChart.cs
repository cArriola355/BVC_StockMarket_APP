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
    public partial class MaxChart : Form
    {
        public Panel myPanel { get; set; }
        public MaxChart()
        {
            InitializeComponent();
            myPanel = panelMax;
        }
    }
}
