using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Knjiznica2
{
    public partial class Naslovna : Form
    {
        public Naslovna()
        {
            InitializeComponent();
        }
        
        private void PrijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Prijava().Show();
        }

        private void ClanoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "Clanovi")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Clanovi NewMDIChild = new Clanovi()
                {
                    MdiParent = this
                };
                NewMDIChild.Show();
            }
        }

        private void PosudbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "Posudba")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Posudba NewMDIChild = new Posudba()
                {
                    MdiParent = this
                };
                NewMDIChild.Show();
            }
        }

        private void ToolStrip1_BackColorChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
