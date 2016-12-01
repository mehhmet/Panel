using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_adminone_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["@benim"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand sor = new SqlCommand("select * from users where mail=@mail", baglan);
        sor.Parameters.Add("@mail",Session["@benim"].ToString());
        SqlDataReader oturum = sor.ExecuteReader();
        if (oturum.Read())
        { 
            Session["@name"]=oturum["name"].ToString();

        }
        else
        {
            Response.Redirect("Default.aspx");
        }


        //versiyon gösterimi
        Session["@versiyonum"] = "";
        SqlCommand p_ver = new SqlCommand("select * from p_update where id=@id",baglan);
        p_ver.Parameters.Add("@id",1);
        SqlDataReader p_ver_oku = p_ver.ExecuteReader();
        if (p_ver_oku.Read())
        {
            Session["@versiyonum"] = p_ver_oku["versiyon"].ToString();
            if (p_ver_oku["versiyon"].ToString() == p_ver_oku["new_versiyon"].ToString())
            {
                Session["@versiyonum"] += " Paneliniz güncel";
            }
            else
            {

            }
        }


        //Mesaj Kontrolü
        Session["@okunmamis"] = 0;
        Session["@okunmus"] = 0;
        Session["@toplam"] = 0;
        SqlCommand mesajlar = new SqlCommand("select * from message", baglan);
        SqlDataReader mesaj_oku = mesajlar.ExecuteReader();
        if (mesaj_oku.Read())
        {
            int toplam = 0, okunmamıs = 0, okunmus = 0,silinmis=0;
            do
            {
                toplam++;
                if (Convert.ToInt16(mesaj_oku["reading"]) == 0 && Convert.ToInt16(mesaj_oku["deleted"])==0)
                {
                    okunmamıs++;
                }
                else if (Convert.ToInt16(mesaj_oku["reading"]) == 1)
                {
                    okunmus++;
                }
                if (Convert.ToInt16(mesaj_oku["deleted"]) == 1)
                {
                    silinmis++;
                }

            } while (mesaj_oku.Read());
            toplam = toplam - silinmis;
            Session["@okunmus"] = okunmus;
            Session["@okunmamis"] = okunmamıs;
            Session["@toplam"] = toplam;
        }

    }
}
