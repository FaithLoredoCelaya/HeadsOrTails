using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{
    public partial class HeadsOrTails : Form
    {
        public HeadsOrTails()
        {
            InitializeComponent();
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            //Initialize random processing.
            Random rng = new Random();
            int output = rng.Next(2);


            //check the result and change image.
            if (output == 1)
                outBox.Image = Properties.Resources.Heads;
            else if (output == 0)
                outBox.Image = Properties.Resources.Tails;
        }
    }
}
