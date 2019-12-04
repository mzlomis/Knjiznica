using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace knjiznica
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter;
        DataTable table;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("Select*from Knjige");

        }
        private void GetData(string v)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new DataTable();
            }
        }


    }
}
