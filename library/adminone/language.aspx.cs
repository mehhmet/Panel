using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_adminone_language : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand getir = new SqlCommand("select * from keywords",baglan);
        SqlDataReader oku = getir.ExecuteReader();

        if (oku.Read())
        {
            TextBox1.Text = oku["turkish"].ToString();
        
        }
    }
}