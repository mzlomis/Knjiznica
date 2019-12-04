using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace UK
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnString = (@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog = UK; Integrated Security = True; 
                            Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter DataAdapter;
        DataTable Table;
        string SelectCommand = "Select * from Korisnici";
        int IndexRow;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = SqlDataSource1;
            Baza(SelectCommand);
            GridView1.DataBind();
            GridView1.AutoGenerateColumns = true;
            GridView1.ShowHeader = true;
        }

        protected void BtnRegistracija_Click(object sender, EventArgs e)
        {
                Registracija();
        }

        protected void Baza(string SelectCommand)
        {
            try

            {
                DataAdapter = new SqlDataAdapter(SelectCommand, ConnString);
                Table = new DataTable()
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };
                DataAdapter.Fill(Table);
                SqlDataSource1.DataBind();
               
               
            }
            catch (SqlException Ex)
            {
                Response.Write(Ex); 
            }
        }
    

        protected void Registracija()
        {
            SqlCommand Command;
            StringBuilder ErrorMessages = new StringBuilder();
            string Insert = @"Insert into Korisnici(OIB, Ime, Prezime, Adresa, Postanski_broj, Grad, Korisnicko_ime, Lozinka) values 
                           (@OIB, @Ime, @Prezime, @Adresa, @Postanski_broj, @Grad, @Korisnicko_ime, @Lozinka)";
            using (SqlConnection Conn=new SqlConnection(ConnString))
            {
                try
                {
                    Conn.Open();
                    Command = new SqlCommand(Insert, Conn);
                    Command.Parameters.AddWithValue(@"OIB", TxtOIB.Text);
                    Command.Parameters.AddWithValue(@"Ime", TxtIme.Text);
                    Command.Parameters.AddWithValue(@"Prezime", TxtPrezime.Text);
                    Command.Parameters.AddWithValue(@"Adresa", TxtAdresa.Text);
                    Command.Parameters.AddWithValue(@"Postanski_broj", TxtPostnskiBroj.Text);
                    Command.Parameters.AddWithValue(@"Grad", TxtGrad.Text);
                    Command.Parameters.AddWithValue(@"Korisnicko_ime", TxtKorIme.Text);
                    Command.Parameters.AddWithValue(@"Lozinka", TxtLoz.Text);
                    Command.ExecuteNonQuery();
                    OcistiTxt();
                    Baza(SelectCommand);
                }

                catch (SqlException Ex)
                {
                    Response.Write(Ex);
                }
            }           
        }

        protected void OcistiTxt()
        {
            TxtOIB.Text = "";
            TxtIme.Text = "";
            TxtPrezime.Text = "";
            TxtAdresa.Text = "";
            TxtPostnskiBroj.Text = "";
            TxtGrad.Text = "";
            TxtKorIme.Text = "";
            TxtLoz.Text = "";
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlDataSource1.Update();
        }
    }
}