using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class IconCalculator : Form
    {
        public IconCalculator()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = textBox1_Result.Text + "1";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }
    }
}
