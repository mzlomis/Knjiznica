using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //splits the text according to the list of separators, and removes blank spaces
            var values = textBox1.Text.Split(new char[] { ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            //line below converts each entry in the values array from a string to a decimal
            var valuesNumeric = Array.ConvertAll(values, decimal.Parse);
            //line below first finds sum and than displays it ot the user
            label1.Text = $"{valuesNumeric.Sum()}";
        }
    }
}
