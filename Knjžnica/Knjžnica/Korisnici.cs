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

namespace Knjžnica
{
    public partial class Korisnici : Form
    {
        string connString1 = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjižnica3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter1;//connection between the program and the database
        DataTable table1;
        SqlCommandBuilder commandBuilder;
        public Korisnici()
        {
            InitializeComponent();
        }

        private void Korisnici_Load(object sender, EventArgs e)
        {
          
            cboTraži2.SelectedIndex = 0;//first item in combobox shows
            dataGridView1.DataSource = bindingSource2;//connects the datagrid view to the bindingsource
            txtPosuđenaKnjiga.Visible = false;//not visible
            label6.Visible = false;
            dateTimePicker1.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            GetData("Select * from Korisnici");
        }
        private void GetData(string selectCommand1)
        {
            try
            {
                dataAdapter1 = new SqlDataAdapter(selectCommand1, connString1);
                table1 = new DataTable();//create new table
                table1.Locale = System.Globalization.CultureInfo.InvariantCulture;//table variety
                dataAdapter1.Fill(table1);//fill the data table
                bindingSource2.DataSource = table1;//connect binding source with the data sourc in table
                dataGridView1.Columns[0].ReadOnly = true;//ID number Read only
                this.dataGridView1.Columns[6].Visible = false;//not visible
                this.dataGridView1.Columns[7].Visible = false;


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//error message
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SqlCommand command;//declares a new sql command object
            string insert = @"insert into Korisnici (OIB, Ime, Prezime, Adresa, Grad, Posuđena_knjiga, Datum_posudbe)
                            values(@OIB, @Ime, @Prezime, @Adresa, @Grad, @Posuđena_knjiga, @Datum_posudbe)";
            using (SqlConnection conn = new SqlConnection(connString1))
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand(insert, conn);//creates a new sql command object
                    command.Parameters.AddWithValue(@"OIB", txtOIB.Text);//add a value into database
                    command.Parameters.AddWithValue(@"Ime", txtIme.Text);
                    command.Parameters.AddWithValue(@"Prezime", txtPrezime.Text);
                    command.Parameters.AddWithValue(@"Adresa", txtAdresa.Text);
                    command.Parameters.AddWithValue(@"Grad", txtGrad.Text);
                    if (txtPosuđenaKnjiga.Text == "")//condition so null values can be saved
                    {
                        command.Parameters.AddWithValue(@"Posuđena_knjiga", DBNull.Value);//save null value
                    }
                    else
                    {
                        command.Parameters.AddWithValue(@"Posuđena_knjiga", txtPosuđenaKnjiga.Text);///save real value
                    }
                    if (dateTimePicker1.Checked ==true)//condition for datetimepicker to choose to insert the date into table
                    {
                        command.Parameters.AddWithValue(@"Datum_posudbe", dateTimePicker1.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue(@"Datum_posudbe",DBNull.Value);//saves null value to table
                    } 
                    command.ExecuteNonQuery();
                    txtOIB.Text = "";//clear textboxes after adding new user
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    txtAdresa.Text = "";
                    txtGrad.Text = "";
                    txtPosuđenaKnjiga.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//error message
                }
            }
            GetData("Select * from Korisnici");
            dataGridView1.Update();
        } 
         //Editing data inside table
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            commandBuilder = new SqlCommandBuilder (dataAdapter1);
            dataAdapter1.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                bindingSource2.EndEdit();
                dataAdapter1.Update(table1);//Table updated
                MessageBox.Show("Podaci promijenjeni");//shows when data is updated
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzbriši_Click(object sender, EventArgs e)//deletes rows inside table
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;//grab a refrence to the current row
            string Value = row.Cells["ID_Korisnika"].Value.ToString();//grab the value from the ID_korisnika field of the selected record
            DialogResult result = MessageBox.Show(" Da li stvarno želite izbrisati korisnika " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string deleteState = @"Delete from Korisnici where ID_Korisnika='" + Value + "'";//ths deletes record from sql table
            if (result == DialogResult.Yes)
            {
                using(SqlConnection conn=new SqlConnection(connString1))
                {
                    try
                    {
                        conn.Open();//try to open the connection
                        SqlCommand comm = new SqlCommand(deleteState, conn);
                        comm.ExecuteNonQuery();//this actually deletes the record
                        GetData("Select * from Korisnici");
                        dataGridView1.Update();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);//runns when something is wrong
                    }
                }
                
            }
        }

        private void btnTraži2_Click(object sender, EventArgs e)
        {
            switch (cboTraži2.SelectedItem.ToString())//combobox select option
            {
                case "ID_korisnika":
                    GetData("select * from korisnici where lower (id_Korisnika) like '%" + txtTraži2.Text.ToLower()+"%'");
                    break;
                case "OIB":
                    GetData("select * from korisnici where lower (oib) like '%" + txtTraži2.Text.ToLower() + "%'");
                    break;
                case "Prezime":
                    GetData("select * from korisnici where lower (prezime) like '%" + txtTraži2.Text.ToLower() + "%'");
                    break;
                case "Posuđena_knjiga":
                    GetData("select * from korisnici where lower (posuđena_knjiga) like '%" + txtTraži2.Text.ToLower() + "%'");
                    break;
            }
            if (checkBox1.Checked == true)//condition for visibility of 2 end columns when serching
            {
                this.dataGridView1.Columns[6].Visible = true;
                this.dataGridView1.Columns[7].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;
            }
        }

        private void btnIspiši2_Click(object sender, EventArgs e)//print report
        {
            Popis_korisnika frm = new Popis_korisnika();
            frm.Show();
        }

        private void btnPosudba_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)//condition for visibility when clicking on "Posudba"
            {
                txtPosuđenaKnjiga.Visible = false;
                label6.Visible = false;
                dateTimePicker1.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                this.dataGridView1.Columns[6].Visible = false;
                this.dataGridView1.Columns[7].Visible = false;
            }
            else
            {
                txtPosuđenaKnjiga.Visible = true;
                label6.Visible = true;
                dateTimePicker1.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                this.dataGridView1.Columns[6].Visible = true;
                this.dataGridView1.Columns[7].Visible = true;
            }
        }
    }
}
