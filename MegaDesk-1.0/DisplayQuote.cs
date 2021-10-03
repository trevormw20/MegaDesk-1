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
        
        public DisplayQuote(Desk desk)
        {
            InitializeComponent();
            DeskQuote deskQuote = new DeskQuote(desk);
            deskQuote.SetQuotePrice();
            //QuoteTotalLabel.Text = desk.getWidth().ToString();
            QuoteTotalLabel.Text = deskQuote.getQuotePrice().ToString();
            NameLabel.Text = desk.getName();
            DateLabel.Text = desk.getQuoteDate();
        }


        private void Return_MouseClick(object sender, MouseEventArgs e)
        {
            var AddQuote = (AddQuote)Tag;
            AddQuote.Show();
            Close();
        }
    }
}
