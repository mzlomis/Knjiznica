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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void ZanroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "Zanrovi")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Zanrovi NewMDIChild = new Zanrovi()
                {
                    MdiParent = this
                };
                NewMDIChild.Show();
            }
        }

        private void AutoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach(Form F in Application.OpenForms)
            {
                if (F.Text == "Autori")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Autori NewMDIChild = new Autori()
                {
                    MdiParent = this
                };
                NewMDIChild.Show();
            }
        }

        private void KnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach(Form F in Application.OpenForms)
            {
                if (F.Text== "Knjige")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Knjige NewMDIChild = new Knjige()
                {
                    MdiParent = this
                };
                NewMDIChild.Show();
            }
        }

        private void KorisnickiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "KorisnickiPodaci")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                KorisnickiPodaci NewMDIChild = new KorisnickiPodaci()
                {
                    MdiParent = this
                };
                NewMDIChild.Show();
            }
        }
    }
}
