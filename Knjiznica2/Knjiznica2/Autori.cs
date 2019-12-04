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
    public partial class Autori : Form
    {
        //connect to database
        string ConnString = (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;
                             Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter DataAdapter;
        DataTable Table;
        string SelectCommand = "Select * from Autori4";
        int IndexRow;

        public Autori()
        {
            InitializeComponent();
        }

        private void Autori_Shown(object sender, EventArgs e)
        {
            //Connect database table to datagrid view
            DataGridView.DataSource = BindingSource1;
            GetData(SelectCommand);

            //make rows invisible
            foreach(DataGridViewRow Row in DataGridView.Rows)
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

        //Get Data method to connect to database datagridview
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
                BindingSource1.DataSource = Table;//connect binding source with the data sourc in table
                DataGridView.Columns[0].ReadOnly = true;//ID number Read only
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
            }
        }

        // method to add values
        private void Dodaj()
        {
            SqlCommand Command;
            string Insert = @"insert into Autori4(Autor) values (@Autor)";
            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue(@"Autor", TxtAutor.Text);
                    Command.ExecuteNonQuery();
                    TxtAutor.Text = "";
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
                }
            }
            GetData(SelectCommand);
            DataGridView.Update();
        }

        //add values execution
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        //bring values form database to texbox
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
            DataGridViewRow Row = DataGridView.Rows[IndexRow];
            TxtAutor.Text = Row.Cells[1].Value.ToString();
        }

        //Edit values in database
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewDataRow = DataGridView.Rows[IndexRow];
            NewDataRow.Cells[1].Value = TxtAutor.Text;
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
            TxtAutor.Text = "";
        }

        //Method to delete record
        private void Izbrisi()
        {
            DataGridViewRow Row = DataGridView.CurrentCell.OwningRow;//grab a refrence to the current row
            string Value = Row.Cells["Sifra"].Value.ToString();//grab the value from the sifra field of the selected record
            DialogResult Result = MessageBox.Show(" Da li stvarno želite izbrisati Autor broj " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string DeleteState = @"Delete from Autori4 where Sifra='" + Value + "'";//ths deletes record from sql table
            if (Result == DialogResult.Yes)
            {
                using (SqlConnection Conn = new SqlConnection(ConnString))
                {
                    try
                    {
                        Conn.Open();//try to open the connection
                        SqlCommand Comm = new SqlCommand(DeleteState, Conn);
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

        //execute deletion
        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            Izbrisi();
        }

        //search
        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            string Data = "Select * from Autori4 where lower";
            string TextBox = "like '%" + TxtPretrazi.Text.ToLower() + "%'";
            switch (CboPretrazi.SelectedItem.ToString())
            {
                case "Sifra":
                    GetData(" " + Data + " (Sifra) " + TextBox + "");
                    break;
                case "Autor":
                    GetData("" + Data + " (Autor) " + TextBox + "");
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

        //Hide everything but two rows
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
        private void BtnPopisAutora_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
                
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "PopisAutora")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                new PopisAutora().Show();
            }
        }
    }
}
