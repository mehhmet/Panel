using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_adminone_comments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        
        if (!IsPostBack)
        {
            SqlCommand cek = new SqlCommand("select * from message where reading=@reading and deleted=@deleted", baglan);
            cek.Parameters.Add("@reading", Convert.ToInt16("0"));
            cek.Parameters.Add("@deleted", Convert.ToInt16("0"));
            SqlDataReader oku = cek.ExecuteReader();
            if (oku.Read())
            {
                DropDownList1.Items.Add("Seçiniz");
                do
                {
                    DropDownList1.Items.Add(oku["head"].ToString());
                } while (oku.Read());
                
            }
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        baslik.Visible = true;
        name.Visible = true;
        mail.Visible = true;
        note.Visible = true;
        Panel1.Visible = true;
        Button1.Visible = true;
        Button2.Visible = true;
        Button3.Visible = true;
        if (DropDownList1.SelectedItem.Text == "Seçiniz")
        {
            baslik.Visible = false;
            name.Visible = false;
            mail.Visible = false;
            note.Visible = false;
            Panel1.Visible=false;
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
        }
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        
            SqlCommand cek = new SqlCommand("select * from message where head=@baslik", baglan);
            cek.Parameters.Add("@baslik", DropDownList1.SelectedItem.Text);
            SqlDataReader oku = cek.ExecuteReader();
            if (oku.Read())
            {
                baslik.Text = oku["head"].ToString();
                name.Text = oku["name"].ToString();
                mail.Text = oku["mail"].ToString();
                note.Text = oku["note"].ToString();

            }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand okundu = new SqlCommand("update message set reading=@reading where head=@baslik",baglan);
        okundu.Parameters.Add("@reading",Convert.ToInt16("1"));
        okundu.Parameters.Add("@baslik",DropDownList1.SelectedItem.Text);
        okundu.ExecuteNonQuery();
        Response.Redirect("comments.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand okundu = new SqlCommand("update message set deleted=@reading where head=@baslik", baglan);
        okundu.Parameters.Add("@reading", Convert.ToInt16("1"));
        okundu.Parameters.Add("@baslik", DropDownList1.SelectedItem.Text);
        okundu.ExecuteNonQuery();
        Response.Redirect("comments.aspx");
    }
}