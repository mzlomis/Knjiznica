using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //txtInput.Text means grab the text from the textbox
            //txtInput.Text.ToLower() means convert the text value o lower case
            //equa sign saves it to the label text property
            //txtInput.Text.ToLower().Trim() trims away blanks on both ends of the input
            //daata type on the left matches data type fro the last method on the right
            label1.Text = txtInput.Text.ToLower().Trim();
        }
    }
}
