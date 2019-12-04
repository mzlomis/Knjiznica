using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        //convert the string "11/25/2016" into a dateTime object
        //it's placed here so ot happens only once
        DateTime dt = DateTime.Parse("25.11.2018.");
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //if somebody chooses a date earlier than 01.11.2018. display a disount message
            //id somebody chooses a date later than 01.11.2018. display a discount message
            //if somebody chooses the dat itself, display no discount for you message
            //dateTimePicker1.Value.Date<dt means that the chosen date is earlier in time than 11/25/2016
            //dateTimePicker1.Value.Date>dt means that the chosen date is later in time than 11/25/2016
            //logical or operator || because it helps us make ad decision
            //|| returns true if the left side is true, or the right side is true, or if both sides are true
            //if the left side is true, the right side is no even checked, os the code is more efficient
            if (dateTimePicker1.Value.Date<dt || dateTimePicker1.Value.Date > dt)
            {
                label1.Text = "You qualify for a discount";//runs when if is true
            }
            else
            {
                label1.Text = "No discount for You";//runs when 11/1/2018 is selected
            }
        }
    }
}
