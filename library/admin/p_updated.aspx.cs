using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


public partial class library_admin_p_updated : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt16(Session["@id"]);
        Response.Write(id + " ");
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand guncelle = new SqlCommand("update page_content set head=@head,page_content=@p_cont where page_id=@p_id ", baglan);
        guncelle.Parameters.AddWithValue("@head", Session["@header"].ToString());
        guncelle.Parameters.AddWithValue("@p_cont", Session["@contenter"].ToString());
        guncelle.Parameters.AddWithValue("@p_id", id);
        Response.Write(Session["@header"].ToString() + " " + Session["@contenter"].ToString());
        SqlCommand update = new SqlCommand("update pages set name=@name where id=@p_id ", baglan);
        update.Parameters.AddWithValue("@name", Session["@header"].ToString());
        update.Parameters.AddWithValue("@p_id", id);
        guncelle.ExecuteNonQuery();
        update.ExecuteNonQuery();
        Response.Redirect("pages.aspx");
        baglan.Close();
    }
}