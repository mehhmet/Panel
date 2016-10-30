using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int toplam=0, okunmamıs=0;
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand image = new SqlCommand("select * from picture where location=@location",baglan);
        image.Parameters.Add("@location","logo");
        SqlDataReader picture_read = image.ExecuteReader();
        if (picture_read.Read())
        {
            Image1.ImageUrl = "../images/" + picture_read["name"].ToString();
        }


        SqlCommand say = new SqlCommand("select * from visitor",baglan);
        SqlDataReader oku = say.ExecuteReader();
        if (oku.Read())
        {
            do
            {
                toplam++;
            } while (oku.Read());
        }
        SqlCommand say1 = new SqlCommand("select * from visitor where reading=@reading", baglan);
        say1.Parameters.Add("@reading", Convert.ToInt16(0));
        SqlDataReader oku1 = say1.ExecuteReader();
        if (oku1.Read())
        {
            do
            {
                okunmamıs++;

            } while (oku1.Read());
        }
       
        

        int ziyaretci = Convert.ToInt32(Application["OnlineZiyaretci"]) - 1;
        Label1.Text = "Online ziyaretçi sayınız &nbsp &nbsp : " + Convert.ToString(ziyaretci);
        Label2.Text = "Toplam ziyaretçi sayınız&nbsp&nbsp: " + Application["OnlineZiyaretci"].ToString();
        Label3.Text = "Toplam mesaj sayınız = " + toplam.ToString()+"<br>";
        Label4.Text = "Okunmamış mesaj sayınız = " + okunmamıs.ToString();
    }
}
