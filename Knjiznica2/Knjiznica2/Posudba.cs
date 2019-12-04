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
using System.Collections;

namespace Knjiznica2
{
    public partial class Posudba : Form
    {
        string ConnString = (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Connection to database
        SqlDataAdapter DataAdapter;
        DataTable Table;
        string SelectCommand = "Select * from Posudba4";
        string SelectCommand1 = "Select Sifra from Knjige";
        string SelectCommand2 = "Select Sifra from Clanovi";
        int IndexRows;
        

        public Posudba()
        {
            InitializeComponent();
        }

        private void Posudba_Shown(object sender, EventArgs e)
        {
            //Bind the datagridview to bindingsource
            DataGridView.DataSource = BindingSource1;
            GetData(SelectCommand);

            int rowscount = DataGridView.Rows.Count;

            for (int i = 0; i < rowscount; i++)
            {
                if (Convert.ToDateTime(DataGridView.Rows[i].Cells[4].Value).Equals(DTPVracanje.MinDate))
                {
                    DataGridView.Rows[i].Cells[4].Style.ForeColor = Color.White;
                }
            }

            //Make more than two rows invisible
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

            //populating comboboxes from database
            try
            {
                Conn.Open();
                SqlCommand Cm = new SqlCommand(SelectCommand1, Conn);
                SqlCommand Cm1 = new SqlCommand(SelectCommand2, Conn);
                SqlDataAdapter Sda = new SqlDataAdapter(Cm);
                SqlDataAdapter Sda1 = new SqlDataAdapter(Cm1);
                DataTable Dt = new DataTable();
                DataTable Dt1 = new DataTable();
                Sda.Fill(Dt);
                Sda1.Fill(Dt1);

                foreach (DataRow Dr in Dt.Rows)
                {
                    CboSifraKnjige.Items.Add(Dr["Sifra"]);
                }

                foreach (DataRow Dr1 in Dt1.Rows)
                {
                    CboSifraClana.Items.Add(Dr1["Sifra"]);
                }

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Get data to fill datgridview
        private void GetData(string SelectCommand)
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
                DataGridView.Columns[0].ReadOnly = true;           
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //clear textboxes and set dates to original state
        private void Ocisti()
        {
            CboSifraKnjige.Text = "";
            CboSifraClana.Text = "";
            DTPVracanje.Value = DTPVracanje.MinDate;
            DTPVracanje.Checked = false;
            LblBrojDana.Text = "";
        }

        //method to add values
        private void Dodaj()
        {
            SqlCommand Command;
            string Insert = @"Insert into Posudba4 (SifraKnjige, SifraClana, DatumPosudbe, DatumVracanja, Kasnjenje) values 
                            (@SifraKnjige, @SifraClana, @DatumPosudbe, @DatumVracanja, @Kasnjenje)";
            using (SqlConnection Conn=new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue(@"SifraKnjige", CboSifraKnjige.Text);
                    Command.Parameters.AddWithValue(@"SifraClana", CboSifraClana.Text);
                    Command.Parameters.AddWithValue(@"DatumPosudbe", DTPPosudba.Value);
                    if (DTPVracanje.Checked == true)
                    {
                         Command.Parameters.AddWithValue(@"DatumVracanja", DTPVracanje.Value);
                    }
                    else
                    {
                         Command.Parameters.AddWithValue(@"DatumVracanja", DTPVracanje.MinDate);
                    }
                    Command.Parameters.AddWithValue(@"Kasnjenje", LblBrojDana.Text);
                    Command.ExecuteNonQuery();
                    GetData(SelectCommand);
                    DataGridView.Update();
                }

                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //calculate delay of books
        private void BtnKasnjenje_Click(object sender, EventArgs e)
        {
            DateTime Dt11 = DTPPosudba.Value;
            DateTime Dt12 = DTPVracanje.Value;
           
            TimeSpan Ts = Dt12 - Dt11;
            double DDays = Ts.TotalDays;

            if (DDays > 30)
            {
                DDays = Ts.TotalDays - 30;
                int Days = Convert.ToInt32(DDays);
                LblBrojDana.Text = Days.ToString();
            }
            else
            {
                LblBrojDana.Text = "0";
            }   
        }       

        // Add values
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (DTPVracanje.Checked == false)
            {
                DTPVracanje.Value = DTPVracanje.MinDate;
            }
            else
            {
                this.DTPVracanje.Value = DateTime.Now;
            }

            foreach (DataGridViewRow Row in DataGridView.Rows)
            {
                if (Convert.ToDateTime(Row.Cells[4].Value).Equals(DTPVracanje.Value) &&
                    Row.Cells[1].Value.ToString().Equals(CboSifraKnjige.Text))
                {
                    MessageBox.Show("Knjga je vani");
                    return;
                }
            }
            Dodaj();
            Ocisti();
        }

        //add values from datagridview to textboxes and datetimepickers
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row1 = DataGridView.CurrentRow;
                
            if (Row1.Cells[4].Value.Equals(DTPVracanje.MinDate))
            {
                IndexRows = e.RowIndex;
                DataGridViewRow Row = DataGridView.Rows[IndexRows];
                CboSifraKnjige.Text = Row.Cells[1].Value.ToString();
                CboSifraClana.Text = Row.Cells[2].Value.ToString();
                DTPPosudba.Value = Convert.ToDateTime(Row.Cells[3].Value.ToString());
                DTPVracanje.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Knjiga je vracena", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        //Edit database form changed values in textboxes and datetimepickers
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            DataGridViewRow NewDataRow = DataGridView.Rows[IndexRows];
            NewDataRow.Cells[1].Value = CboSifraKnjige.Text;
            NewDataRow.Cells[2].Value = CboSifraClana.Text;
            NewDataRow.Cells[3].Value = DTPPosudba.Value;
            NewDataRow.Cells[4].Value = DTPVracanje.Value;
            if (LblBrojDana.Text == "")
            {
                NewDataRow.Cells[5].Value = 0;
            }
            else
            {
                NewDataRow.Cells[5].Value = Convert.ToInt32(LblBrojDana.Text);
            }

            SqlCommandBuilder Commandbuilder = new SqlCommandBuilder(DataAdapter);
            DataAdapter.UpdateCommand = Commandbuilder.GetUpdateCommand();

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

        //Search
        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            string Data = "Select * from Posudba4 where lower";
            string TextBox = " like '%" + TxtPretrazi.Text.ToLower() + "%'";
            switch (CboPretrazi.SelectedItem.ToString())
            {
                case "Sifra Knjige":
                    GetData("" + Data + "(SifraKnjige)" + TextBox + "");
                    break;
                case "Sifra Clana":
                    GetData("" + Data + "(SifraClana)" + TextBox + "");
                    break;
            }
        }

        //Search combobox
        private void CboSifraKnjige_KeyDown(object sender, KeyEventArgs e)
        {
            int Index = CboSifraKnjige.FindString(CboSifraKnjige.Text);
            if (e.KeyCode == Keys.Enter)
            {
                CboSifraKnjige.SelectedIndex = Index;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Search combobox
        private void CboSifraClana_KeyDown(object sender, KeyEventArgs e)
        {
            int Index = CboSifraClana.FindString(CboSifraClana.Text);
            if (e.KeyCode == Keys.Enter)
            {
                CboSifraClana.SelectedIndex = Index;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Show all rows
        private void BtnPrikaziSve_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in DataGridView.Rows)
            {
                Row.Visible = Row.Index > -1;
            }
        }

        //Hide everythig but two rows
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
        private void BtnIzvjestajKasnjenje_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "IzvjestajKasnjenje")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                new IzvjestajKasnjenje().Show();
            }
        }

        //Delete record method
        private void Izbrisi1()
        {
            DataGridViewRow Row = DataGridView.CurrentCell.OwningRow;
            string Value = Row.Cells["Sifra"].Value.ToString();
            DialogResult Result = MessageBox.Show("Da li stvarno zelite izrisati posudbu " + Value, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string DeleteState = @"Delete from Posudba4 where Sifra= '" + Value + "'";
            using (SqlConnection Conn= new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    SqlCommand Comm = new SqlCommand(DeleteState, Conn);
                    Comm.ExecuteNonQuery();
                    GetData(SelectCommand);
                    DataGridView.Update();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Delete record
        private void BtnIzbrisi1_Click(object sender, EventArgs e)
        {
            Izbrisi1();
        }

        private void BtnIzvjestajZanrovi_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form F in Application.OpenForms)
            {
                if (F.Text == "PosudbaZanrovi")
                {
                    IsOpen = true;
                    F.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                new PosudbaZanrovi().Show();
            }
        }
    }
}
