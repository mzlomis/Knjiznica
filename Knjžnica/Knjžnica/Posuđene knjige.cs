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
using System.Data.Sql;

namespace Knjžnica
{
    public partial class Posuđene_knjige : Form
    {
        string connString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Knjižnica3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter;//connects the database with the program
        DataTable table;//table the hod the information in the datagridview
        public Posuđene_knjige()
        {
            InitializeComponent();
        }

        private void Posuđene_knjige_Load(object sender, EventArgs e)
        {
            cboTraži3.SelectedIndex = 0;//first item frm combobox shows when loading
            dataGridView1.DataSource = bindingSource1;//binds the datasource with te bindingsource

            //metoda GetData
            GetData ("Select Autor, Naslov_knjige, Signatura, ID_korisnika, Ime, Prezime, Posuđena_knjiga, Datum_posudbe from Knjige JOIN Korisnici on Knjige.ID_broj_knjige=Korisnici.Posuđena_knjiga order by Datum_posudbe ");           
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new DataTable();//create new object, data table
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);//fill the data table
                bindingSource1.DataSource = table;//connect binding source with data source
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//error message
            }

        }

        private void btnTraži3_Click(object sender, EventArgs e)//Search by selected item in combobox
        {
            switch (cboTraži3.SelectedItem.ToString())//combobox select option
            {
                case "ID_Korisnika":
                    GetData("select Autor, Naslov_knjige, Signatura, ID_Korisnika, Ime, Prezime, Posuđena_knjiga, Datum_posudbe from knjige join korisnici on Knjige.ID_broj_knjige=Korisnici.Posuđena_knjiga where lower (id_korisnika) like '%" + txtTraži3.Text.ToLower() + "%'");
                    break;
                case "Posuđena_knjiga":
                    GetData("select Autor, Naslov_knjige, Signatura, ID_Korisnika, Ime, Prezime, Posuđena_knjiga, Datum_posudbe from knjige join korisnici on Knjige.ID_broj_knjige=Korisnici.Posuđena_knjiga where lower (Posuđena_knjiga) like '%" + txtTraži3.Text.ToLower() + "%'");
                    break;
                case "Prezime":
                    GetData("select Autor, Naslov_knjige, Signatura, ID_Korisnika, Ime, Prezime, Posuđena_knjiga, Datum_posudbe from knjige join korisnici on Knjige.ID_broj_knjige=Korisnici.Posuđena_knjiga where lower (prezime) like '%" + txtTraži3.Text.ToLower() + "%'");
                    break;
                case "Datum_posudbe":
                    GetData("select Autor, Naslov_knjige, Signatura, ID_Korisnika, Ime, Prezime, Posuđena_knjiga, Datum_posudbe from knjige join korisnici on Knjige.ID_broj_knjige=Korisnici.Posuđena_knjiga where datum_posudbe >= '" + dateTimePicker1.Value.ToString(System.Globalization.CultureInfo.InvariantCulture) +"'");
                    break;
            }
        }

        private void btnIspiši3_Click(object sender, EventArgs e)//print report
        {
            Popis_posuđenih_knjiga frm = new Popis_posuđenih_knjiga();
            frm.Show();
        }
    }
}
