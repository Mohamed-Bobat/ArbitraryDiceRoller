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

        /// <summary>
        /// A normal Dice roll without additional options.
        /// </summary>
        /// <param name="die">Random Number Generator</param>
        /// <param name="n">Number of dice to roll</param>
        /// <param name="d">Max value of Dice</param>
        /// <param name="m">Value of mod</param>
        /// <param name="dc">Value of DC to compare against</param>
        public void NormalRoll(Random die, int n, int d, int m, int dc)
        {
            if (d <= 0) { return; }
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

        /// <summary>
        /// An Exploding Dice roll. This roll will repeat itself if thge maximum value is rolled. These repetions may be chained and have no upper limit
        /// </summary>
        /// <param name="die">Random Number Generator</param>
        /// <param name="n">Number of dice to roll</param>
        /// <param name="d">Max value of Dice</param>
        /// <param name="m">Value of mod</param>
        /// <param name="dc">Value of DC to compare against</param>
        private void explodingRoll(Random die, int n, int d, int m, int dc)
        {
            if (d <= 1) { return; }
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

        /// <summary>
        /// Rolls a number of Die and then sums their values. 
        /// </summary>
        /// <param name="die">Random Number Generator</param>
        /// <param name="n">Number of dice to roll</param>
        /// <param name="d">Max value of Dice</param>
        /// <param name="m">Value of mod</param>
        /// <param name="dc">Value of DC to compare against</param>
        private void SumRoll(Random die, int n, int d, int m, int dc)
        {
            if (d <= 0) { return; }
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

        /// <summary>
        /// rolls a number of exploding die, then sums their values. Exploding die reroll when they roll the highest value. These rerolls may chain.
        /// </summary>
        /// <param name="die"></param>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <param name="dc"></param>
        private void SumExplodingRoll(Random die, int n, int d, int m, int dc)
        {
            if (d <= 1) { return; }
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

