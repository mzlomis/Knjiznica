using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //4=2+2=3+1=6-2
        private void button1_Click(object sender, EventArgs e)
        {
            //thos variable will hold the summ of entries in the table
            //begins at 0 so the value of the sum at the end is correct
            double sum = 0;
            double value;//this variable will be used in attempts to convert
            for (int i = 0; i< dataGridView1.Rows.Count ; i++) 
            {
                //dataGridView[0,i] is written this way so we can step over the rows in the first column
                //0 is the index of the column
                //i is a variable thaat stands for the index of eah row as we loop
                sum += double.TryParse(dataGridView1[0, i].Value.ToString()-1, i++ out value)?value:0.0;
            }
            label1.Text = $"{sum}";//after loop runs display sum to the user
        }

    }
}
