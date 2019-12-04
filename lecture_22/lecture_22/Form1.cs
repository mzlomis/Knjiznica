using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            DateTime date;//declare a variable to hold the input of the box after a conversion
            //read the value from the box, if the conversion is succesfull, set the date variable
            //save the date variable as a long date string
            //if conversion fails, save "Canot convert" to dateFinal
            string dateFinal = DateTime.TryParse(textBox1.Text, out date) ? date.ToLongDateString() : "Cannot convert";
            label1.Text = dateFinal;//display message ti him or her so they know what's going on
        }
    }
}
