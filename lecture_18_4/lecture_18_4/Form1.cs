using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_18_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblLetters.Text = "";//clear value of text property
            //123%46(*)A
            //grab each charcter, hold it and decide whether it's a letter or a digit
            //grab 1, decide it's a number
            //grab A, examine it, decide it's a number and display
            foreach(var c in textBox1.Text)
            {
                if (char.IsLetter(c))//check each character from the string to determine whether it's a letter
                    lblLetters.Text += $"{c}\n";
                 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "";//clear the value so the tet does not accumulate between runs
            //grab each letter in the string inside the textbox
            //12$5GA imagine this is a string, so as the loop runs, c is 1,2,$,5,G,A
            foreach(var c in textBox1.Text)
            {
                if (char.IsDigit(c))
                    lblNumbers.Text += $"{c}\n";
            }
        }
    }
}
