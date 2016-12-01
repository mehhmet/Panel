using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class library_adminone_settings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();



        //Panel güncelleme Check
        if (!IsPostBack)
        {
            //Panel güncelleme Check
            SqlCommand update = new SqlCommand("select * from p_update", baglan);
            SqlDataReader up_oku = update.ExecuteReader();
            if (up_oku.Read())
            {
                if (Convert.ToInt16(up_oku["visible"].ToString()) == 1)
                {
                    CheckBox1.Checked = true;
                }
                else
                {
                    CheckBox1.Checked = false;
                }
            }
            //Tarayıcı bildirimi Check
            SqlCommand tarayici = new SqlCommand("select * from settings where b_turu=@b_turu", baglan);
            tarayici.Parameters.Add("@b_turu","tarayici");
            SqlDataReader tar_oku = tarayici.ExecuteReader();
            if (tar_oku.Read())
            {
                if (Convert.ToInt16(tar_oku["visible"].ToString()) == 1)
                {
                    CheckBox2.Checked = true;
                }
                else
                {
                    CheckBox2.Checked = false;
                }
            }
            //Mesaj bildirimi Check
            SqlCommand mesaj = new SqlCommand("select * from settings where b_turu=@b_turu", baglan);
            mesaj.Parameters.Add("@b_turu", "message");
            SqlDataReader mesaj_oku = mesaj.ExecuteReader();
            if (mesaj_oku.Read())
            {
                if (Convert.ToInt16(mesaj_oku["visible"].ToString()) == 1)
                {
                    CheckBox3.Checked = true;
                }
                else
                {
                    CheckBox3.Checked = false;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();

        //update visible
        SqlCommand up_up = new SqlCommand("update p_update set visible=@visible where id='1'  ", baglan);
        if (CheckBox1.Checked)
        {
            up_up.Parameters.AddWithValue("@visible", 1);
        }
        else
        {
            up_up.Parameters.AddWithValue("@visible", 0);
        }

        
        up_up.Parameters.AddWithValue("@id", Convert.ToInt16("1"));
        up_up.ExecuteNonQuery();


        
        //tarayici visible
        SqlCommand tarayici = new SqlCommand("update settings set visible=@visible where b_turu=@b_turu",baglan);
        if (CheckBox2.Checked)
        {
            tarayici.Parameters.AddWithValue("@visible", 1);
        }
        else
        {
            tarayici.Parameters.AddWithValue("@visible", 0);
        }
        tarayici.Parameters.AddWithValue("@b_turu","tarayici");
        tarayici.ExecuteNonQuery();


        //mesaj visible
        SqlCommand mesaj = new SqlCommand("update settings set visible=@visible where b_turu=@b_turu", baglan);
        if (CheckBox3.Checked)
        {
            mesaj.Parameters.AddWithValue("@visible", 1);
        }
        else
        {
            mesaj.Parameters.AddWithValue("@visible", 0);
        }
        mesaj.Parameters.AddWithValue("@b_turu", "message");
        mesaj.ExecuteNonQuery();





        Response.Redirect("settings.aspx");

    }
}