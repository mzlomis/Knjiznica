using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //+=2 has the effect of moving the track bar to the right by to on every click
            //takoe the value, add 2 to it, store it back to the same trackBar1.Value
            trackBar1.Value += 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //take the current value of the trackbar
            //divide it by 2
            //store that new updated value back
            trackBar1.Value /= 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //grab the current value of trackBar1.Value
            //subtrack 3 from it
            //store back the updated value
            trackBar1.Value -= 3;
        }
    }
}
