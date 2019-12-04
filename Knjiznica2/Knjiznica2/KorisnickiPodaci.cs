using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text
    ;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagedList;

namespace Knjiznica2
{
    public partial class KorisnickiPodaci : Form
    {
        string ConnString = (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Connection string
        SqlDataAdapter DataAdapter;
        DataTable Table;
        string SelectCommand = "Select * from Prijava2";
        int IndexRow;

        public KorisnickiPodaci()
        {
            InitializeComponent();
        }

        private void KorisnickiPodaci_Shown(object sender, EventArgs e)
        {
            //Binding the databse to datagridview
            DataGridView1.DataSource = BindingSource1;
            GetData(SelectCommand);

            foreach (DataGridViewRow Row in DataGridView1.Rows)
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

        //Get data from database tabe to datagridview
        private void GetData (string SelectCommand)
        {
            try

            {
                DataAdapter = new SqlDataAdapter(SelectCommand, ConnString);
                Table = new DataTable()
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };
                DataAdapter.Fill(Table);
                BindingSource1.DataSource = Table;
                DataGridView1.Columns[0].ReadOnly = true;
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //CLear txtboxes
        private void OcistiTxt()
        {
            TxtKorIme.Text = "";
            TxtLozinka.Text = "";
        }
        
        //Add values method
        private void Dodaj()
        {
            SqlCommand Command;
            string Insert = @"Insert into Prijava2(Korisnik, Lozinka) values (@Korisnik, @Lozinka)";
            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue(@"Korisnik", TxtKorIme.Text);
                    Command.Parameters.AddWithValue(@"Lozinka", TxtLozinka.Text);
                    Command.ExecuteNonQuery();
                    OcistiTxt();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GetData(SelectCommand);
            DataGridView1.Update();
        }

        //Execute add values method
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        //Aadd values from datagriview to textboxes
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
            DataGridViewRow Row = DataGridView1.Rows[IndexRow];
            TxtKorIme.Text = Row.Cells[0].Value.ToString();
            TxtLozinka.Text = Row.Cells[1].Value.ToString();
        }

        //Edit data in database
       

        //Deletion method
        private void Izbrisi()
        {
            DataGridViewRow Row = DataGridView1.CurrentCell.OwningRow;
            string Value = Row.Cells[0].Value.ToString();
            DialogResult Result = MessageBox.Show("Da li stvarno zelite izbrisati korisnika " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string DeleteState=@"Delete from Prijava2 where Korisnik= '"+Value+"'";
            if (Result == DialogResult.Yes)
            {
                using (SqlConnection Conn=new SqlConnection(ConnString))
                {
                    try
                    {
                        Conn.Open();
                        SqlCommand Comm = new SqlCommand(DeleteState, Conn);
                        Comm.ExecuteNonQuery();
                    }
                    catch (SqlException Ex)
                    {
                        MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            GetData(SelectCommand);
            DataGridView1.Update();
        }

        //Execute deletion
        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            Izbrisi();
        }

        //Search
        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            string Data = "Select * from Prijava2 where lower";
            string TextBox= "like '%"+TxtPretrazi.Text.ToLower() + "%'";
            switch (CboPretrazi.SelectedItem.ToString())
            {
                case "Korisnik":
                    GetData("" + Data + "(Korisnik)" + TextBox + "");
                    break;
            }
        }

        //Show all rows
        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in DataGridView1.Rows)
            {
                Row.Visible = Row.Index > -1;
            }
        }

        //Hide all but 2 rows
        private void BtnSakrij_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in DataGridView1.Rows)
            {
                if (!Row.IsNewRow)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DataGridView1.DataSource];
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

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewDataRow = DataGridView1.Rows[IndexRow];
            NewDataRow.Cells[0].Value = TxtKorIme.Text;
            NewDataRow.Cells[1].Value = TxtLozinka.Text;
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder(DataAdapter);
            DataAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();

            try
            {
                BindingSource1.EndEdit();
                DataAdapter.Update(Table);
                MessageBox.Show("Podaci promijenjeni", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Row.EndEdit();
            }

            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OcistiTxt();
        }

        private void BtnIspisi_Click(object sender, EventArgs e)
        {
            new PopisKorisnika().Show();
        }
    }
}
