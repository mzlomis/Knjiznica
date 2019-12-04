﻿ using System;
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
    public partial class Knjige : Form
    {
        //Connection string to database
        string ConnString = (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;
                             Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable Table;
        string SelectCommand = "Select * from Knjige";
        string SelectCommand1 = "Select Zanr from Zanrovi2";
        string SelectCommand2 = "Select Autor from Autori4";
        int IndexRow;

        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Shown(object sender, EventArgs e)
        {
            //Connect datagridview to database table
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

            SqlConnection Conn = new SqlConnection(ConnString);

            //Populate comboboxes
            try
            {
                Conn.Open();
                SqlCommand Cm = new SqlCommand(SelectCommand1, Conn);
                SqlCommand Cm1 = new SqlCommand(SelectCommand2, Conn);
                SqlDataAdapter Sda = new SqlDataAdapter(Cm);
                SqlDataAdapter Sda1 = new SqlDataAdapter(Cm1);
                DataTable DtZanr = new DataTable();
                DataTable DtAutor = new DataTable();
                Sda.Fill(DtZanr);
                Sda1.Fill(DtAutor);

                foreach (DataRow dr in DtZanr.Rows)
                {
                    CboZanr.Items.Add(dr["Zanr"]);
                }
                foreach (DataRow dr1 in DtAutor.Rows)
                {
                    CboAutor.Items.Add(dr1["Autor"]);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method get data to connect to database table
        private void GetData(string SelectCommand)
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

        //Choose from combobox
        private void CboZanr_KeyDown(object sender, KeyEventArgs e)
        {
            int Index = CboZanr.FindString(CboZanr.Text);
            if (e.KeyCode == Keys.Enter)
            {
                CboZanr.SelectedIndex = Index;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //choode from combobox
        private void CboAutor_KeyDown(object sender, KeyEventArgs e)
        {
            int Index = CboAutor.FindString(CboAutor.Text);
            if (e.KeyCode == Keys.Enter)
            {
                CboAutor.SelectedIndex = Index;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Ocisti()
        {
            TxtISBN.Text = "";
            CboZanr.Text = "";
            CboAutor.Text = "";
            TxtNaslov.Text = "";
        }
        //Method to add values
        private void Dodaj()
        {
            SqlCommand Command;
            string Insert = @"insert into Knjige(ISBN, Zanr, Autor, Naslov) values (@ISBN, @Zanr, @Autor, @Naslov)";
            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue(@"ISBN", TxtISBN.Text);
                    Command.Parameters.AddWithValue(@"Zanr", CboZanr.Text);
                    Command.Parameters.AddWithValue(@"Autor", CboAutor.Text);
                    Command.Parameters.AddWithValue(@"Naslov", TxtNaslov.Text);
                    Command.ExecuteNonQuery();
                    Ocisti();
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

        //add values from datatable to comboboxes and textboxes
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
            DataGridViewRow Row = DataGridView.Rows[IndexRow];
            TxtISBN.Text = Row.Cells[1].Value.ToString();
            CboZanr.Text = Row.Cells[2].Value.ToString();
            CboAutor.Text = Row.Cells[3].Value.ToString();
            TxtNaslov.Text= Row.Cells[4].Value.ToString();
        }

        //edit database values
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewDataRow = DataGridView.Rows[IndexRow];
            NewDataRow.Cells[1].Value = TxtISBN.Text;
            NewDataRow.Cells[2].Value = CboZanr.Text;
            NewDataRow.Cells[3].Value = CboAutor.Text;
            NewDataRow.Cells[4].Value = TxtNaslov.Text;
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
            Ocisti();
        }

        //method for deletion
        private void Izbrisi()
        {
            DataGridViewRow Row = DataGridView.CurrentCell.OwningRow;//grab a refrence to the current row
            string Value = Row.Cells["Sifra"].Value.ToString();//grab the value from the sifra field of the selected record
            DialogResult Result = MessageBox.Show(" Da li stvarno želite izbrisati knjigu broj " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string DeleteState = @"Delete from Knjige where Sifra='" + Value + "'";//ths deletes record from sql table
            if (Result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    try
                    {
                        conn.Open();//try to open the connection
                        SqlCommand Comm = new SqlCommand(DeleteState, conn);
                        Comm.ExecuteNonQuery();//this actually deletes the record
                        GetData(SelectCommand);
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
            string Data = "Select * from Knjige where lower";
            string TextBox = "like '%" + TxtPretrazi.Text.ToLower() + "%'";
            switch (CboPretrazi.SelectedItem.ToString())
            {
                case "Sifra":
                    GetData(" " + Data + " (Sifra) " + TextBox + "");
                    break;
                case "ISBN":
                    GetData("" + Data + " (ISBN)" + TextBox + "");
                    break;
                case "Zanr":
                    GetData("" + Data + " (Zanr)" + TextBox + "");
                    break;
                case "Autor":
                    GetData("" + Data + " (Autor) " + TextBox + "");
                    break;
                case "Naslov":
                    GetData("" + Data + " (Naslov)" + TextBox + "");
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
        private void BtnIzvjestajZanrovi_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "IzvjestajZanrovi")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                new IzvjestajZanrovi().Show();
            }
        }
    }
}
