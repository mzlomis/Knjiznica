using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Checked is a property of a box, this poperty is either true or false
            if (checkBox1.Checked)
            {
                MessageBox.Show("Are You sure You want to get rich?");//runs when the box is checked
            }
            else
            {
                MessageBox.Show("Are You sure You don't want to get rich?");//runs when the box is not checked
            }
        }
    }
}
