using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if the exercise box is checked, and the diet box is checked
            //if both conditions on both sides of the && are true, the code immedeately following runs
            if (chkExercise.Checked && chkDiet.Checked)
            {
                lblResults.Text = "10% discount!";//runs if both boxes are checked
            }
            else if (chkExercise.Checked)//if only the exercise box is checked
            {
                lblResults.Text = "4% disocunt!";//runs only id the exercise boy is checked
            }
            else if (chkDiet.Checked)
            {
                lblResults.Text = "6% discount!";//runs when only the diet box is checked
            }
            else
            {
                lblResults.Text = "";//runs when neither box is checked
            }
        }
    }
}
