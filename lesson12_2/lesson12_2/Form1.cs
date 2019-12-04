using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson12_2
{
    public partial class Form1 : Form
    {
        //int means -10, 0, 50, not 5.678
        int x = 1;//this is present so we have a variable we can use throughout our code
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"x = {x}";//this is here so that the inital vaue of x is shown
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //+= has the effect of building up the output
            //x++ has the action of first allowing us to display the value of x, then the value increased by 1
            //\n at end stacks output vertically by putting output on new lines
            richTextBox1.Text += $"x={x++}\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;//resets the variable back to 1
            richTextBox1.Text = "";//ths clears out the text from the box on the left side
            richTextBox2.Text = "";//this clears out hte text from the box on the right side
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //+= has the effect of building up the output
            //++x has the action of first updating the value of x and than showing it
            //\n at end stacks output vertically by putting output on new lines
            richTextBox2.Text += $"x={++x}\n";
        }
    }
}
