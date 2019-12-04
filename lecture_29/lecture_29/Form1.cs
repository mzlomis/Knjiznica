using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nmrFirstNumber_ValueChanged(object sender, EventArgs e)
        {
            //This has the effect of calling the Add method, stored inside the Mathmethods class
            //Add is a method that id called by typing Mathmethods.Add(value1, value2)
            //you can think of this code here as the calling code
            lblSum.Text = $"Sum={MathMethods.Add(nmrFirstNumber.Value, nmrSecondNumber.Value)}";
            lblAverage.Text = $"Average={MathMethods.Average(nmrFirstNumber.Value, nmrSecondNumber.Value)}";
        }

        private void nmrSecondNumber_ValueChanged(object sender, EventArgs e)
        {
            //This has the effect of calling the Add method, stored inside the Mathmethods class
            //Add is a method that id called by typing Mathmethods.Add(value1, value2)
            //you can think of this code here as the calling code
            lblSum.Text = $"Sum={MathMethods.Add(nmrFirstNumber.Value, nmrSecondNumber.Value)}";
            lblAverage.Text = $"Average={MathMethods.Average(nmrFirstNumber.Value, nmrSecondNumber.Value)}";

        }
    }
}
