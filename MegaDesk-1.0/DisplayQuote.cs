using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1._0
{
    public partial class DisplayQuote : Form
    {
        DeskQuote deskQuote;
        public DisplayQuote()
        {
            InitializeComponent();
            QuoteTotalLabel.Text = deskQuote.getQuotePrice().ToString();
        }

        private void Return_MouseClick(object sender, MouseEventArgs e)
        {
            //var MainMenu = (MainMenu)Tag;
            //MainMenu.Show();
            Close();
        }
    }
}
