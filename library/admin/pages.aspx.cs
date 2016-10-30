using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_pages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
            SqlCommand sayfa = new SqlCommand("select * from pages", baglan);
            SqlDataReader oku = sayfa.ExecuteReader();
            if (oku.Read())
            {
                ListBox1.Items.Clear();
                Session["@sayfalar"] = "";
                Session["@sayfaid"] = "";
                int x = 1;
                do
                {
                    ListBox1.Items.Add(oku["name"].ToString());
                    Session["@sayfalar"] = Session["@sayfalar"].ToString() + x + " .......... " + oku["name"].ToString() + "<br>";
                    x++;
                } while (oku.Read());
            }
            baglan.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("page_add.aspx");
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["@durum"] = "guncelleme";
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex == -1)
        {
            Label1.Visible = true;
            
        }
        else
        {
            Session["@update"] = ListBox1.SelectedItem.Value;
            Session["@delete"] = ListBox1.SelectedItem.Value;
            if (Session["@durum"] == "guncelleme")
            {
                Response.Redirect("page_update.aspx");
            }
            else if (Session["@durum"] == "silme")
            {
                Response.Redirect("delete.aspx");
            }
        }
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["@durum"] = "silme";
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
}