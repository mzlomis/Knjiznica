using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prehrana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIzracunaj_Click(object sender, EventArgs e)
        {
            double Total;
            double First = 88.362;
            double Second = 13.397;
            double Third = 4.799;
            double Fourth = 5.677;
            double Fifth = 1.2;
                Total = (First + (Second * Convert.ToDouble(NudTezina.Value)) + (Third * Convert.ToDouble(NudVisina.Value)) - (Fourth * Convert.ToDouble(NudGodine.Value)))*Fifth;
                LblOdrzavanje.Text = Total.ToString();
            
        }
    }
}
