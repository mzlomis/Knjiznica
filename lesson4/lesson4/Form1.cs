using System;
using System.Windows.Forms;

namespace lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msgLabel_Click(object sender, EventArgs e)
        {
            //imagine a cafe where the number of people changes over time
            //-10 people? NO.
            //0 a possible count or people? 
            //numbers like 0, 10,but no 4.567
            ushort numberPeople = 34;//tells the nuber of people inside cafe
            //$ is used for string interpolation
            //variable names can be put directly into strings
            //\n has the efect of creating a new line
            msgLabel.Text = $"The number of people:{numberPeople}\n";
            numberPeople = 23; //assign updaate value based on some observation in the world
            //line below displayes updated value
            //+= has the effect of building a long string from smaller ones
            msgLabel.Text += $"The number of people:{numberPeople}";

        }
    }
}
