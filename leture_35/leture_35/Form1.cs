using System;
using System.Linq;//this is needed to make use of lists
using System.Windows.Forms;

namespace leture_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            //make an array to hold the value from the boxes
            //an array allows us to operate with the data in bulk
            decimal [] values = { nmrFirstNumber.Value, nmrSecondNumber.Value, nmrThirdNumber.Value };
            decimal max, min, average, sum;//these variables ar set inside Summarize so they do not have to be set here
            MathMethods.Summarize(values, out max, out min, out average, out sum);//call method to set variable values
            lblSummary.Text = $"Max: {max}\n";//finds and shows the max value to the user
            lblSummary.Text += $"Min: {min}\n";//finds and shows the minimum value of the list
            lblSummary.Text += $"Average: {Math.Round(average,2)}\n";//finds and shows the average of all three numbers
            lblSummary.Text += $"Sum:{sum}";// the sum of all 3 numbers
        }
    }
}
