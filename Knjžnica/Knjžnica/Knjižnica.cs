using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjžnica
{
    public partial class Knjižnica : Form
    {
        public Knjižnica()
        {
            InitializeComponent();
        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knjige frm = new Knjige();//napravi novi prozor
            frm.MdiParent = this;//set the main form as the parent
            frm.Show();//show the new form
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici frm = new Korisnici();
            frm.MdiParent = this;
            frm.Show();
        }

        private void posuđeneKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posuđene_knjige frm = new Posuđene_knjige();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
