using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand delete = new SqlCommand("delete from pages where name=@name",baglan);
        SqlCommand delete2 = new SqlCommand("delete from page_content where head=@head", baglan);
        delete.Parameters.Add("@name", Session["@delete"].ToString());
        delete2.Parameters.Add("@head", Session["@delete"].ToString());
        delete.ExecuteNonQuery();
        delete2.ExecuteNonQuery();
        Response.Redirect("pages.aspx");
    }
}