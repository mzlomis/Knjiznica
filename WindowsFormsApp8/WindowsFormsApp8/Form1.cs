using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblLetters.Text = "";
            foreach (var c in textBox1.Text)
            
                if (char.IsLetter)
                
                    lblLetters.Text += $"{c}\n";
                }
            }
        }
    }
}
