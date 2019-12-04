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

namespace Knjžnica
{
    public partial class Knjige : Form
    {
        string connString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjižnica3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter;//connects the datbase to the program
        DataTable table;//table to hold the data so we can fill the datagridview
        SqlCommandBuilder commandBuilder;

        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            cboTraži.SelectedIndex = 0;//combobox first item selected
            dataGridView1.DataSource = bindingSource1;//connecting datagridview with datasource

            //method GetData
            GetData("Select * from Knjige");
        }
        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new DataTable();//create new object - data table
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);//fill the data table
                bindingSource1.DataSource = table;//conect binding source and data source
                dataGridView1.Columns[0].ReadOnly = true;//ID number Read only

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//error message
            }

        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            SqlCommand command;//declares a new sql command object
            string insert = @"insert into Knjige(Autor, Naslov_knjige, Signatura)
                            values(@Autor, @Naslov_knjige, @Signatura)";
            using(SqlConnection conn=new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand(insert, conn);//creates a new sql command object
                    command.Parameters.AddWithValue(@"Autor", txtAutor.Text);
                    command.Parameters.AddWithValue(@"Naslov_knjige", txtNaslovKnjige.Text);
                    command.Parameters.AddWithValue(@"Signatura", txtSignatura.Text);
                    command.ExecuteNonQuery();
                    txtAutor.Text = "";
                    txtNaslovKnjige.Text = "";
                    txtSignatura.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            GetData("Select * from Knjige"); 
           dataGridView1.Update();
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                bindingSource1.EndEdit();//changes the data in the program table
                dataAdapter.Update(table);//changes the data in the database
                MessageBox.Show("Podaci promijenjeni");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;//grab a refrence to the current row
            string Value = row.Cells["ID_broj_knjige"].Value.ToString();//grab the value from the ID_korisnika field of the selected record
            DialogResult result = MessageBox.Show(" Da li stvarno želite izbrisati knjigu " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string deleteState = @"Delete from Knjige where ID_broj_knjige='" + Value + "'";//ths deletes record from sql table
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();//try to open the connection
                        SqlCommand comm = new SqlCommand(deleteState, conn);
                        comm.ExecuteNonQuery();//this actually deletes the record
                        GetData("Select * from Knjige");
                        dataGridView1.Update();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);//runns when something is wrong
                    }
                }

            }
        }

        private void btnTraži_Click(object sender, EventArgs e)
        {
            switch (cboTraži.SelectedItem.ToString())//combobox select option
            {
                case "ID_broj_knjige":
                    GetData("select * from knjige where lower (id_broj_knjige) like '%" + txtTraži1.Text.ToLower() + "%'");
                    break;
                case "Autor":
                    GetData("select * from knjige where lower (autor) like '%" + txtTraži1.Text.ToLower() + "%'");
                    break;
                case "Naslov_knjige":
                    GetData("select * from knjige where lower (naslov_knjige) like '%" + txtTraži1.Text.ToLower() + "%'");
                    break;
                case "Signatura":
                    GetData("select * from knjige where lower (signatura) like '%" + txtTraži1.Text.ToLower() + "%'");
                    break;
            }
        }

        private void btnIspiši_Click(object sender, EventArgs e)//print report
        {
            Popis_knjiga frm = new Popis_knjiga();
            frm.Show();
        }
    }
}
    