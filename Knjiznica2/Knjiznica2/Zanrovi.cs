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
    public partial class Zanrovi : Form
    {
        string ConnString=(@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter DataAdapter;//connection between the program and the database
        DataTable Table;
        string SelectCommand = "Select * from Zanrovi2";//Select values from database table
        int IndexRow;

        public Zanrovi()
        {
            InitializeComponent();
        }

        private void Zanrovi_Shown(object sender, EventArgs e)
        {
            //connect datagridview to database table
            DataGridView.DataSource = BindingSource1;
            GetData(SelectCommand);

            //Hide rows
            foreach (DataGridViewRow Row in DataGridView.Rows)
            {
                if (!Row.IsNewRow)
                {
                    Row.Visible = Row.Index < 2;
                }
                else
                {
                    Row.Visible = Row.Index > -1;
                }
            }
        }

        //Method to add data from database
        public void GetData(string SelectCommand)
        {
            try
            {
                DataAdapter = new SqlDataAdapter(SelectCommand, ConnString);
                Table = new DataTable
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture//table variety
                };
                DataAdapter.Fill(Table);//fill the data table
                BindingSource1.DataSource = Table;//connect binding source with the data sourc in table1
                DataGridView.Columns[0].ReadOnly = true;//ID number Read only
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
            }
        }

        //Method to add values to database
        private void Dodaj()
        {
            SqlCommand Command;
            string Insert = @"insert into Zanrovi2(Zanr) values (@Zanr)";
            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue(@"Zanr", TxtZanr.Text);
                    Command.ExecuteNonQuery();
                    TxtZanr.Text = "";
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
                }
            }
            GetData(SelectCommand);
            DataGridView.Update();
        }

        //Execute add values
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        //bring data from database to textbox
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
            DataGridViewRow Row = DataGridView.Rows[IndexRow];
            TxtZanr.Text = Row.Cells[1].Value.ToString();      
        }

        //Edit data from database
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewDataRow = DataGridView.Rows[IndexRow];
            NewDataRow.Cells[1].Value = TxtZanr.Text;
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder(DataAdapter);
            DataAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();
            try
            {
                BindingSource1.EndEdit();
                DataAdapter.Update(Table);
                MessageBox.Show("Podaci promijenjeni", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtZanr.Text = "";
        }

        //Method for deletion
        private void Izbrisi()
        {
            DataGridViewRow Row = DataGridView.CurrentCell.OwningRow;//grab a refrence to the current row
            string Value = Row.Cells["Sifra"].Value.ToString();//grab the value from the ID_korisnika field of the selected record
            DialogResult result = MessageBox.Show(" Da li stvarno želite izbrisati zanr broj " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string deleteState = @"Delete from Zanrovi2 where Sifra='" + Value + "'";//ths deletes record from sql table
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    try
                    {
                        conn.Open();//try to open the connection
                        SqlCommand comm = new SqlCommand(deleteState, conn);
                        comm.ExecuteNonQuery();//this actually deletes the record
                        GetData("Select * from Zanrovi2");
                        DataGridView.Update();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);//runns when something is wrong
                    }
                }
            }
        }

        //Execute deletion
        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            Izbrisi();
        }

        //Search
        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            string Data = "Select * from Zanrovi2 where lower";
            string TextBox = "like '%" + TxtTrazi.Text.ToLower() + "%'";
            switch (CboPretrazi.SelectedItem.ToString())
            {
                case "Sifra":
                    GetData(" "+Data+" (Sifra) "+TextBox+"");
                    break;
                case "Zanr":
                    GetData(""+Data+" (Zanr) "+TextBox+"");
                    break;
            }
        }

        //Show all rows
        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow Row in DataGridView.Rows)
            {
                    Row.Visible = Row.Index > -1;
            }
        }

        //Hide all but two rows
        private void BtnSakrij_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in DataGridView.Rows)
            {
                if (!Row.IsNewRow)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    Row.Visible = Row.Index < 2;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    Row.Visible = Row.Index > -1;
                }
            }
        }

        //Crystal report
        private void BtnPopisZanrova_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "PopisZanrova")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                new PopisZanrova().Show();
            }
        }
    }
}

