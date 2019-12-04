using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class Proba1 : System.Web.UI.Page
    {
        String Connstring = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Proba5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter da;
        DataTable dt;
        SqlConnection cn = new SqlConnection(@"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=Proba5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT Autori.Autor, Knjige.Knjiga FROM Autori, Knjige, Autori_Knjige WHERE Knjige.ID_Knjige = Autori_knjige.ID_Knjige AND Autori.ID_Autora = Autori_knjige.ID_Autora AND Knjige.ID_Knjige = 1 ORDER BY Autori.Autor; ", cn);
            dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        public void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}