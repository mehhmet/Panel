using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_adminone_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["@benim"] != null)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand sor = new SqlCommand("select * from users where mail=@mail and pass=@pass", baglan);
        sor.Parameters.Add("@mail",TextBox1.Text);
        sor.Parameters.Add("@pass",TextBox2.Text);
        SqlDataReader oku = sor.ExecuteReader();
        if (oku.Read())
        {
            Session["@benim"] = oku["mail"].ToString();
            Response.Redirect("HomePage.aspx");
        }
        else
        {
            LinkButton1.Visible = true;
            Label1.Visible = true;
        }


    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("reset_pw.aspx");
    }
}