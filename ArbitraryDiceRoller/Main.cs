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
                    int result = die.Next(1,d+1);
                    if (result + m < dc)
                    {
                        ResultList.Items.Add(result + "+" + m + ":" + (result + m) + " vs. " + dc + ":  Fail!");
                    }
                    else
                    {
                        ResultList.Items.Add(result + "+" + m + ":" + (result + m) + " vs. " + dc + ":  Pass!");
                    }

                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int result = die.Next(1,d+1);
                    ResultList.Items.Add(result + "+" + m + ":" + (result + m));
                }
            }
        }


        private void explodingRoll(Random die, int n, int d, int m, int dc)
        {
            
            if (DC.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    StringBuilder results = new StringBuilder("");
                    int roll = die.Next(1,d+1);
                    int result = roll;
                    results.Append(result + "+");
                    while (roll == d)
                    {
                        roll = die.Next(1, d + 1);
                        result = result + roll;
                        
                        results.Append(roll+"+");
                    }

                    if (result + m < dc)
                    {
                        ResultList.Items.Add(results.ToString()  + m + ":" + (result + m) + " vs. " + dc + ":  Fail!");
                    }
                    else
                    {
                        ResultList.Items.Add(results.ToString()  + m + ":" + (result + m) + " vs. " + dc + ":  Pass!");
                    }

                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    StringBuilder results = new StringBuilder("");
                    int roll = die.Next(1,d+1);
                    int result = roll;
                    results.Append(result + "+");
                    while (roll == d)
                    {
                        roll = die.Next(1, d + 1);
                        result = result + roll;
                        results.Append(roll + "+");
                    }
                    ResultList.Items.Add(results.ToString() + m + ":" + (result + m));
                }
            }
        }


        private void SumRoll(Random die, int n, int d, int m, int dc)
        {
            int[] rolls = new int[n];
            StringBuilder results = new StringBuilder("");
            if (DC.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    rolls[i] = die.Next(1,d+1);
                    results.Append((rolls[i] + "+"));
                }
                int result = rolls.Sum();
                if (result + m < dc)
                {
                    ResultList.Items.Add(results.ToString() + m + ":" + (result + m) + " vs. " + dc + ":  Fail!");
                }
                else
                {
                    ResultList.Items.Add(results.ToString() + m + ":" + (result + m) + " vs. " + dc + ":  Pass!");
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    rolls[i] = die.Next(1, d + 1);
                    results.Append((rolls[i] + "+"));
                }
                int result = rolls.Sum();
                ResultList.Items.Add(results.ToString()  + m + ":" + (result + m));
                
            }
        }

        private void SumExplodingRoll(Random die, int n, int d, int m, int dc)
        {
            int[] rolls = new int[n];
            StringBuilder results = new StringBuilder("");
            if (DC.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    int roll = die.Next(1, d + 1);
                    rolls[i] = roll;
                    results.Append((roll + "+"));
                    while (roll == d)
                    {
                        roll = die.Next(1, d + 1);
                        rolls[i] = rolls[i] + roll;
                        results.Append((roll + "+"));
                        // ResultList.Items.Add("Exploded!");
                    }

                }
                int result = rolls.Sum();
                

                if (result + m < dc)
                {
                    ResultList.Items.Add(results.ToString() + m + ":" + (result + m) + " vs. " + dc + ":  Fail!");
                }
                else
                {
                    ResultList.Items.Add(results.ToString() + m + ":" + (result + m) + " vs. " + dc + ":  Pass!");
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int roll = die.Next(1, d + 1);
                    rolls[i] = roll;
                    results.Append((roll + "+"));
                    while (roll == d)
                    {
                        roll = die.Next(1, d + 1);
                        rolls[i] = rolls[i] + roll;
                        results.Append((roll + "+"));
                       // ResultList.Items.Add("Exploded!");
                    }
                    
                }
                int result = rolls.Sum();
                ResultList.Items.Add(results.ToString() + m + ":" + (result + m));
            }
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
                if (Sum.Checked&Exploding.Checked)
                {
                    SumExplodingRoll(dice, n, d, m, dc);
                }
                else if (Sum.Checked)
                {
                    SumRoll(dice, n, d, m,dc);
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

