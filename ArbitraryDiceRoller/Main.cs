using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbitraryDiceRoller
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        public void NormalRoll(Random die, int n, int d, int m, int dc)
        {
            if (DC.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    int result = die.Next(1, d);
                    if (result + m < dc)
                    {
                        ResultList.Items.Add(result + "+" + m + ":" + (result + m) + " vs. " + dc + ":  Fail!");
                    }
                    else
                    {
                        ResultList.Items.Add(result + "+" + m + ":" + (result + m) + " vs. " + dc + "   Pass!");
                    }

                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int result = die.Next(1, d);
                    ResultList.Items.Add(result + "+" + m + ":" + (result + m));
                }
            }
        }


        public void explodingRoll(Random die, int n, int d, int m, int dc)
        {

        }


        public void SumRoll(Random die, int n, int d, int m, int dc)
        {

        }


        private void Roll_Click(object sender, EventArgs e)
        {

            int n, d, m, dc;
            Boolean b = int.TryParse(Number.Text, out n) & int.TryParse(Size.Text, out d) & int.TryParse(Mod.Text, out m);
            int.TryParse(DCValue.Text, out dc);
            //parses the text boxes into integers
            if (b)//only begin rolling dice if the parsed values exist
            {
                Random dice = new Random();
                if (Sum.Checked)
                {
                    SumRoll(dice, n, d, m, dc);
                }
                else if (Exploding.Checked)
                {
                    explodingRoll(dice, n, d, m, dc);
                }
                else
                {
                    NormalRoll(dice, n, d, m, dc);
                }
            }






        }
        
    }  
}

