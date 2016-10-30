using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_page_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string durum = "no"; ;
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand ekle = new SqlCommand("insert into pages(name,menu) values(@name,@menu)",baglan);
        ekle.Parameters.Add("@name",TextBox1.Text);
        if (CheckBox1.Checked)
        {
            durum = "yes";
        }
        ekle.Parameters.Add("@menu",durum);
        
        try
        {
            Session["@page_header"]=TextBox1.Text;
            Session["@page_content"] = TextBox2.Text;
            ekle.ExecuteNonQuery();
            Response.Redirect("page_addc.aspx");
            

        }
        catch (Exception)
        {
            
            Response.Write("Hata Oluştu");
        }
        baglan.Close();
    }
}