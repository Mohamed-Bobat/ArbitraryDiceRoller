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


        private void Roll_Click(object sender, EventArgs e)
        {
            
            int n,d,m,dc;
            Boolean b = int.TryParse(Number.Text, out n) & int.TryParse(Size.Text, out d) & int.TryParse(Mod.Text, out m);
            if (b)
            {
                Random dice = new Random();
              
                for (int i=0; i<n;i++){
                    int result = dice.Next(1,d);
                        
                            ResultList.Items.Add(result + "+" + m + ":" + (result + m));
                        

                    }
                }
            }
            





        }

      
}

