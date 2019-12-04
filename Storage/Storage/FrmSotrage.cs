using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FrmSotrage : Form
    {
        public FrmSotrage()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //Declaration od variables section
            int Age;
            string YourName;
            double Pay;

            //assignment statements
            Age = 15;
            YourName = "Mislav";
            Pay=230.75;

            //disply the results
            MessageBox.Show("Your age is " + Age.ToString());
            MessageBox.Show("Your name is " + YourName);
            MessageBox.Show("Your pay is " + Pay.ToString());

        }
    }
}
