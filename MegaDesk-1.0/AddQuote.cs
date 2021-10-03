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
    public partial class AddQuote : Form
    {
        Desk desk = new Desk();
        DeskQuote deskQuote = new DeskQuote();
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Return_MouseClick(object sender, MouseEventArgs e)
        {
            var MainMenu = (MainMenu)Tag;
            MainMenu.Show();
            Close();
        }

        private void PriceQuote_MouseClick(object sender, MouseEventArgs e)
        {
            //set desk info
            setQuoteInfo();
            deskQuote.SetQuotePrice();

            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Tag = this;
            displayQuote.Show(this);
            Hide();
        }


        private void WidthBox_Leave(object sender, EventArgs e)
        {
            //if (WidthBox != null && WidthBox.value > 96 && WidthBox.value < 24)
            //{

            //}
            //else
            //{
            //    WidthBox.BackColor = Color.Red;
            //}

        }

        private void FirstNameBox_Enter(object sender, EventArgs e)
        {
            TextBox answerBox = sender as TextBox;

            if (answerBox != null)
            {
                //int lengthOfAnswer = FirstNameBox.Length;
                //answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void WidthBox_ValueChanged(object sender, EventArgs e)
        {
            if (WidthBox.Value > 96 || WidthBox.Value < 24)
            {
                MessageBox.Show("The desk width needs to be between 24 and 96 inches");
                WidthBox.BackColor = Color.Red;
            }
            else
                WidthBox.BackColor = Color.White;
        }

        private void DepthBox_ValueChanged(object sender, EventArgs e)
        {
            if (DepthBox.Value > 48 && DepthBox.Value < 12)
            {
                MessageBox.Show("The desk depth needs to be between 12 and 48 inches");
                DepthBox.BackColor = Color.Red;
            }
            else
                DepthBox.BackColor = Color.White;
        }

        private string getDate()
        {
            DateTime dt = DateTime.Parse(DateTime.Now.ToString());
            return ($"{dt:d MMMM, yyyy}");
        }

        private void setQuoteInfo()
        {
            desk.setName(FirstNameBox.ToString(), LastNameBox.ToString());
            desk.SetWidth((int)WidthBox.Value);
            desk.SetDepth((int)DepthBox.Value);
            desk.SetDrawers(DrawersBox.SelectedIndex + 1);
            desk.SetMaterial(MaterialBox.SelectedIndex);
            desk.SetRushOrder(RushBox.SelectedIndex);
            /*FirstNameSave = FirstName.value;
            LastNameSave = LastName.value;
            WidthSave = WidthBox.Value;
            DepthSave = DepthBox.Value;
            DrawersSave = DrawersBox.SelectedIndex + 1;
            MaterialSave = MaterialBox.SelectedIndex;
            RushOrderSave = RushBox.SelectedIndex;*/
        }

     

        private void WidthBox_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = DepthBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void WidthBox_Click(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = DepthBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void DepthBox_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = DepthBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void DepthBox_Click(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = DepthBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }        
    }
}
