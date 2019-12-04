using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //as you move the marker, display a tooltip with the current value of the trackbar
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //as you move the marker, display a tooltip with the current value of the trackbar
            toolTip2.SetToolTip(trackBar2, trackBar2.Value.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (checkedListBox1.SelectedIndex)//use to examine selected index of entry in box
            {
                case 0://case label that correspodonds to first item selected, or Add
                    label1.Text = Add(trackBar1.Value, trackBar2.Value).ToString();//Call Add
                    break;
                case 1://examine whether the word Divide has been selected
                    label1.Text = Divide(trackBar1.Value, trackBar2.Value).ToString();
                    break;
            }
        }
        //private means accesible only in our code
        //static means we will be able to call our method just by typing it's name
        //double is the type of data returned by the method
        //name of the method is add
        //double x and double y are parameters
        //=> is called "expression bodied memer" notation
        private static double Add(double x, double y) => x + y;

        private static double Divide (double x, double y)
        {
            //in math the division by zero is not allowed: 5/0
            //if y is not 0, divide x b y and send it back to the calling code
            //if y is not 0, return 0.0 to the callin code because division by 0 is not defined
            return (y != 0) ? x / y : 0.0;
        }

    }
}
