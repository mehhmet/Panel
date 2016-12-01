using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;


public partial class library_adminone_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Online Ziyaretçi Sayısını aldık.
        int ziyaretci = Convert.ToInt32(Application["OnlineZiyaretci"]) ;
        Session["@online"] = ziyaretci;
        //Db Bağlantısı Sağlandı.
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        //Tarayıcı Tavsiyesi verildi.
            Session["@browser"] = "";
            System.Web.HttpBrowserCapabilities browser = Request.Browser;
            string name = browser.Browser;
            float version = (float)(browser.MajorVersion + browser.MinorVersion);
            if (name != "Chrome")
            {
                SqlCommand tarayici = new SqlCommand("select * from settings where b_turu=@b_turu",baglan);
                tarayici.Parameters.Add("@b_turu","tarayici");
                SqlDataReader tar_oku = tarayici.ExecuteReader();
                if (tar_oku.Read())
                {
                    if (Convert.ToInt16(tar_oku["visible"].ToString()) == 1)
                    {
                        Session["@browser"] = tar_oku["b_cont"].ToString();
                    }
                    
                }

                
            }
        //Panel Versiyonu Kontrol Edildi.
            Session["@pver"] = "";
            SqlCommand p_ver = new SqlCommand("select * from p_update where id=@id",baglan);
            p_ver.Parameters.Add("@id",1);
            SqlDataReader ver_read = p_ver.ExecuteReader();
            if (ver_read.Read())
            {
                if (Convert.ToInt16(ver_read["visible"].ToString()) ==1)
                {
                    if (ver_read["versiyon"].ToString() != ver_read["new_versiyon"].ToString())
                    {
                        Session["@pver"] = ver_read["cont"].ToString();
                    }
                    else
                    {
                        Session["@pver"] = "";
                    }
                    
                }
            }
        //Mesajlar Kontrol Edildi.
            Session["message"] = "";
            SqlCommand mesaj = new SqlCommand("select * from settings where b_turu=@b_turu",baglan);
            mesaj.Parameters.Add("@b_turu","message");
            SqlDataReader m_oku = mesaj.ExecuteReader();
            if (m_oku.Read())
            {
                
                if (Convert.ToInt16(m_oku["visible"].ToString()) == 1)
                {
                    message.Visible = true;
                }
                else
                {
                    message.Visible = false;
                }
            }
        
        

    }
    
}