using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Knjiznica2
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;
                                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT (*) FROM Prijava2 WHERE Korisnik='" + TxtKorIme.Text + "' AND Lozinka='" + TxtLoz.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                bool IsOpen = false;
                foreach (Form F in Application.OpenForms)
                {
                    if (F.Text == "Administrator")
                    {
                        IsOpen = true;
                        F.BringToFront();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    new Administrator().Show();
                }
            }
            else
            {
                MessageBox.Show("Krivo korisnicko ime ili lozinka", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
