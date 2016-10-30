using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_page_addc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Session["@page_header"] + "<br>" + Session["@page_content"]);
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand id = new SqlCommand("select * from pages where name=@name",baglan);
        id.Parameters.Add("@name",Session["@page_header"].ToString());
        SqlDataReader oku = id.ExecuteReader();
        if (oku.Read())
        {
            string sid = oku["id"].ToString();
            Response.Write(sid);
            SqlCommand ekle = new SqlCommand("insert into page_content(page_id,head,page_content) values(@p_id,@head,@p_cont)", baglan);
            ekle.Parameters.Add("@p_id",sid);
            ekle.Parameters.Add("@head", Session["@page_header"]);
            ekle.Parameters.Add("@p_cont", Session["@page_content"]);
            ekle.ExecuteNonQuery();
            Response.Redirect("admin.aspx");
        }
        baglan.Close();
    }
}