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


        private void button1_Click(object sender, EventArgs e)
        {
            
            int n,d,m;
            if(int.TryParse(Number.Text, out n) && int.TryParse(Size.Text, out d) && int.TryParse(Mod.Text, out m))
            {
                int[] results =new int[n];
                foreach (int roll in results){

                }
                Console.WriteLine(n + " " + d + " " + m);
            }



            

        }

      
    }
}
