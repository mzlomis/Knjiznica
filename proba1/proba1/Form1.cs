using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = comboBox1.FindString(comboBox1.Text);
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.SelectedIndex = index;
            }
        }
    }
}
