using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSideLength_TextChanged(object sender, EventArgs e)
        {
            //when ever the text is changed in the box
            //the label next to the square i updated with that value
            lblSideLength.Text = txtSideLength.Text;
        }

        private void btnFindPerimiter_Click(object sender, EventArgs e)
        {
            //reads the value from the box and saves it, after conversion, to sideLength
            double SideLength = double.Parse(txtSideLength.Text);
            //every square has exactly 4 sides
            const ushort numberOfSides = 4;
            //4*10=40 perimeter when each side is 10
            //4*20=80 perimeter when each side is 20
            double perimeter = numberOfSides * SideLength;
            //line below the run time will show the perimeter
            lblPerimeter.Text = $"Perimeter = {perimeter}";
        }
    }
}
