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

namespace comboboxfill
{
    public partial class Form1 : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                             TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand cm = new SqlCommand("Select Zanr from Zanrovi2", Conn);
                SqlDataAdapter sda = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["Zanr"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ;
            }
        }
    }
}
