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
    public partial class Clanovi : Form
    {
        string ConnString = (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjiznica2;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Connection to database
        SqlDataAdapter DataAdapter;
        DataTable Table;
        string SelectCommand = "Select * from Clanovi";
        int IndexRows;

        public Clanovi()
        {
            InitializeComponent();
        }

        private void Clanovi_Shown(object sender, EventArgs e)
        {
            //bind the datagrid view to table in database
            DataGridView.DataSource = BindingSource1;
            GetData(SelectCommand);

            //makes rows invisible
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

        //Get data to fill datagridview
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

        //clear textboxes
        private void OcistiTxtbox()
        {
            TxtOIB.Text = "";
            TxtIme.Text = "";
            TxtPrezime.Text = "";
            TxtAdresa.Text = "";
            TxtPostanskiBroj.Text = "";
            TxtGrad.Text = "";
        }

        //method to add values to database
        private void Dodaj()
        {
            SqlCommand Command;
            string Insert = @"insert into Clanovi (OIB, Ime, Prezime, Adresa, PostanskiBroj, Grad) 
                          values (@OIB, @Ime, @Prezime, @Adresa, @PostanskiBroj, @Grad)";
            using (SqlConnection Conn = new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue("OIB", TxtOIB.Text);
                    Command.Parameters.AddWithValue("Ime", TxtIme.Text);
                    Command.Parameters.AddWithValue("Prezime", TxtPrezime.Text);
                    Command.Parameters.AddWithValue("Adresa", TxtAdresa.Text);
                    Command.Parameters.AddWithValue("PostanskiBroj", TxtPostanskiBroj.Text);
                    Command.Parameters.AddWithValue("Grad", TxtGrad.Text);
                    Command.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GetData(SelectCommand);
            DataGridView.Update();
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
            OcistiTxtbox();
        }

        //add values to textboxes
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              IndexRows = e.RowIndex;
              DataGridViewRow Row = DataGridView.Rows[IndexRows];
              TxtOIB.Text = Row.Cells[1].Value.ToString();
              TxtIme.Text = Row.Cells[2].Value.ToString();
              TxtPrezime.Text = Row.Cells[3].Value.ToString();
              TxtAdresa.Text = Row.Cells[4].Value.ToString();
              TxtPostanskiBroj.Text = Row.Cells[5].Value.ToString();
              TxtGrad.Text = Row.Cells[6].Value.ToString();
        }

        //add values from textboxes to database
        private void BtnUredi_Click(object sender, EventArgs e)
        { 
            DataGridViewRow NewDataRow = DataGridView.Rows[IndexRows];
            NewDataRow.Cells[1].Value = TxtOIB.Text;
            NewDataRow.Cells[2].Value = TxtIme.Text;
            NewDataRow.Cells[3].Value = TxtPrezime.Text;
            NewDataRow.Cells[4].Value = TxtAdresa.Text;
            NewDataRow.Cells[5].Value = TxtPostanskiBroj.Text;
            NewDataRow.Cells[6].Value = TxtGrad.Text;
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
            OcistiTxtbox();
        }

        //Delete record method
        private void Izbrisi()
        {
            DataGridViewRow Row = DataGridView.CurrentCell.OwningRow;
            string Value = Row.Cells["Sifra"].Value.ToString();
            DialogResult Result = MessageBox.Show("Da li stvarno zelite izbrisati clana " + Value, "Poruka",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string DeleteState = @"Delete from Clanovi where Sifra='" + Value + "'";
            if (Result == DialogResult.Yes)
            {
                using (SqlConnection Conn = new SqlConnection(ConnString))
                {
                    try
                    {
                        Conn.Open();
                        SqlCommand Command1 = new SqlCommand(DeleteState, Conn);
                        Command1.ExecuteNonQuery();
                        GetData(SelectCommand);
                        DataGridView.Update();
                    }
                    catch (SqlException Ex)
                    {
                        MessageBox.Show(Ex.Message, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            //Execute deletion
            Izbrisi();
        }

        //Search
        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            string Data = "Select * from Clanovi where lower";
            string TextBox = " like '%" + TxtPretrazi.Text.ToLower() + "%'";
            switch (CboPretrazi.SelectedItem.ToString())
            {
                case "Sifra":
                        GetData("" + Data +" (Sifra) "+ TextBox + "");
                    break;
                case "OIB":
                    GetData("" + Data + " (OIB) " + TextBox + "");
                    break;
                case "Prezime":
                    GetData("" + Data + " (Prezime)" + TextBox + "");
                    break;
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

        //Hide everyting but two rows
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
                    Row.Visible = Row.Index > - 1;
                }
            }
        }
      
        private static string String1 = "PopisClanova";    

        private static void NewForm()
        {
            new PopisClanova().Show();
        }

        public static void OtvoriJednom()
        {
            Form F = Application.OpenForms[String1];
                if (F!=null)
                {
                    F.BringToFront();
                }
                else
                {
                    Clanovi.NewForm();
                }
        }

        //Crystal report
        private void BtnPopisClanova_Click(object sender, EventArgs e)
        {
            OtvoriJednom();
        }

        private void BtnDodaj_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnDodaj.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void BtnUredi_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnUredi.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void BtnIzbrisi_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnIzbrisi.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void BtnPretrazi_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnPretrazi.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void BtnPrikaziSve_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnPrikaziSve.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void BtnSakrij_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnSakrij.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void BtnPopisClanova_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, BtnPopisClanova.ClientRectangle,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
        SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
