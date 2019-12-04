using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_49
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void businessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BizContacts frm = new BizContacts();//make new business contacts form
            frm.MdiParent = this;//ste the main form as the parent of eah business form
            frm.Show();//show the new business contacs form
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);//cascade the child form inside the main form
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);//apply vertical layout inside to child forms inside parent forms
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);//apply horizontal layout inside to child forms inside parent forms
        }
    }
}
