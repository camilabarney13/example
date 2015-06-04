using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        
        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { name = "Lloyd", earSize = 12 };
            lucinda = new Elephant() { name = "Lucinda", earSize = 14 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Elephant
        {
            public string name;
            public int earSize = 0;

            public void whoAmI()
            {   
                MessageBox.Show("I am " + name + " and my ears are " + earSize + " inches tall");
            }

        }

        private void Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.whoAmI();

        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.whoAmI();
        }

        private void swap_Click(object sender, EventArgs e)
        {
            Elephant swap;
            swap = lloyd;
            lloyd = lucinda;
            lucinda = swap;

            MessageBox.Show("Swap completed!");

        }
    }
}
