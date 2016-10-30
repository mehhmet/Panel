using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_visitor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand getir = new SqlCommand("select * from visitor where reading=@reading ",baglan);
        getir.Parameters.Add("@reading",Convert.ToInt16(0));
        SqlDataReader oku = getir.ExecuteReader();
        if (oku.Read())
        {
            
            Session["@mesajid"] = Convert.ToInt16(oku["id"]);
            Session["@mesaj"] = "";
            Session["@mesaj"] = Session["@mesaj"].ToString() + "<br>" + "mesajı yazanın adı = " + oku["name"].ToString() + "<br>Mesajı yazanın mail adresi = " + oku["mail"].ToString() + "<br>Mesaj içeriği = " + oku["note"].ToString();

            
        }
        else
        {
            Session["@mesaj"] = "Okunmamış mesajınız bulunmamaktadır.";
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand okudum = new SqlCommand("update visitor set reading=@read where id=@p_id ",baglan);
        okudum.Parameters.AddWithValue("@read", Convert.ToInt16(1));
        okudum.Parameters.AddWithValue("@p_id", Convert.ToInt16(Session["@mesajid"]));
        okudum.ExecuteNonQuery();
        Response.Redirect("visitor.aspx");
    }
}