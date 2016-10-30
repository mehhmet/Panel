using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand menu = new SqlCommand("select * from pages where menu=@menu order by priority asc", baglan);
        menu.Parameters.Add("@menu","yes");
        SqlDataReader menu_oku = menu.ExecuteReader();
        if (menu_oku.Read())
        {
            Session["@menum"]="";
            int number=1;
            string durum = "class=\"active\"";
            do
            {

                Session["@menum"] = Session["@menum"].ToString() + "<li " + durum + "><a href=\"#" + menu_oku["konum"].ToString() + "    \">" + menu_oku["name"].ToString() + "</a></li>";
                if (number > 0)
                {
                    durum = "";
                }
                number++;


            } while (menu_oku.Read());
        }



        SqlCommand logo = new SqlCommand("select * from picture where location=@location", baglan);
        logo.Parameters.Add("@location", "logo");
        SqlDataReader l_oku = logo.ExecuteReader();
        if (l_oku.Read())
        {
            Image1.ImageUrl = "library/images/" + l_oku["name"].ToString();
        }


        SqlCommand slider = new SqlCommand("select * from picture where location=@location",baglan);
        slider.Parameters.Add("@location","slider");
        SqlDataReader oku = slider.ExecuteReader();
        if (oku.Read())
        {
            Session["@slide"] = "";
            int slide_number = 1;
                string sliderr="item active";
            do
            {
                
                Session["@slide"] = Session["@slide"].ToString()+
"<div class=\" " + sliderr + "\"><img src=\"" + "library/images/" + oku["name"].ToString() + "\"" + " alt=\"banner\"><div class=\"carousel-caption\"><div class=\"caption-wrapper\"><div class=\"caption-info\"><img src=\"" + "library/images/" + oku["logo"].ToString() + "\" class=\"animated bounceInUp\" alt=\"logo\"><h1 class=\"animated bounceInLeft\">" + oku["cont"].ToString() + "</h1><p class=\"animated bounceInRight\">" + oku["cont1"].ToString() + "</p><!--<div class=\"scroll animated fadeInUp\"><a href=\"#works\" class=\"btn btn-default\"><i class=\"fa fa-flask\"></i>  Diğer Projeler</a> <a href=\"#contact\" class=\"btn btn-default\"><i class=\"fa fa-paper-plane-o\"></i> Projenize Başlayalım</a></div>--></div></div></div></div>";
                if (slide_number > 0)
                {
                    sliderr = "item";
                }
                slide_number++;


                   



            } while (oku.Read());
        }



        Session["@hakkımızda"] = "";
        SqlCommand hakkımızda = new SqlCommand("select * from page_content where head=@head", baglan);
        hakkımızda.Parameters.Add("@head", "Hakkımızda");
        SqlDataReader h_oku = hakkımızda.ExecuteReader();
        if (h_oku.Read())
        {
            Session["@hakkımızda"] = h_oku["page_content"].ToString();
        }



        Session["@referans"]="";
        SqlCommand referans=new SqlCommand("select * from picture where location=@header",baglan);
        referans.Parameters.Add("@header","referans");
        SqlDataReader r_oku=referans.ExecuteReader();
        if (r_oku.Read())
        {
            do
            {
                Session["@referans"] = Session["@referans"].ToString() + "<figure class=\"effect-oscar  wowload fadeInUp\"><img src=\"" + "library/images/" + r_oku["name"].ToString() + "\" alt=\"img01\"/><figcaption><h2>" + r_oku["cont"].ToString() + "</h2><p>" + r_oku["cont1"].ToString() + "<br><a href=\"library/images/" + r_oku["name"].ToString() + "\" title=\"1\" data-gallery>Projeyi Gör</a></p></figcaption></figure>";
            } while (r_oku.Read());
            
        }

        Session["@ortak"] = "";
        SqlCommand ortak = new SqlCommand("select * from picture where location=@location",baglan);
        ortak.Parameters.Add("@location","ortak");
        SqlDataReader o_oku = ortak.ExecuteReader();
        if (o_oku.Read())
        {
            do
            {
                Session["@ortak"] = Session["@ortak"].ToString() + "<img src=\"library/images/"+o_oku["name"].ToString()+"\"  alt=\"partners\">";

            } while (o_oku.Read());
        }


        Session["@social"] = "";
        SqlCommand social_oku = new SqlCommand("select * from social_media",baglan);
        SqlDataReader s_oku = social_oku.ExecuteReader();
        if (s_oku.Read())
        {
            do
            {
                Session["@social"] = Session["@social"].ToString() + "<a target=\"_blank\" href=\"" + s_oku["link"].ToString() + " \"><img src=\"library/images/" + s_oku["foto"].ToString() + "\"style=\"width:35px;height:35px;\">    </a>  " /*"<a href=\"" + s_oku["link"].ToString() + "\"><i class=\"fa fa-facebook fa-2x\"></i></a>"*/;
            } while (s_oku.Read());
            
        }



        Session["@copy"] = "";
        SqlCommand copy_oku = new SqlCommand("select * from content where konum=@konum", baglan);
        copy_oku.Parameters.Add("@konum","copy");
        SqlDataReader c_oku = copy_oku.ExecuteReader();
        if (c_oku.Read())
        {
            Session["@copy"] = c_oku["text"].ToString();
        }



        Session["@team"] = "";
        SqlCommand team_oku = new SqlCommand("select * from team", baglan);
        SqlDataReader t_oku = team_oku.ExecuteReader();
        if (t_oku.Read())
        {
            do
            {
                Session["@team"] = Session["@team"].ToString() + "<div class=\" col-sm-3 col-xs-6\"><figure class=\"effect-chico\"><img src=\"library/images/" + t_oku["image"].ToString() + "\" alt=\"\" class=\"img-responsive\" /><figcaption><p><b>" + t_oku["name"].ToString() + "</b><br>" + t_oku["class"].ToString() + "<br><br><a target=\"_blank\" href=\"" + t_oku["social"].ToString() + "\"><i class=\"fa fa-instagram\"></i></a> <a target=\"_blank\" href=\"" + t_oku["social2"].ToString() + "\"><i class=\"fa fa-facebook\"></i></a> <a target=\"_blank\" href=\""+t_oku["social3"].ToString()+"\"><i class=\"fa fa-twitter\"></i></a></p></figcaption></figure></div>";
                
            } while (t_oku.Read());
        }


        Session["@yorum"] = "";
        Session["@yorumbtn"] = "";
        SqlCommand yorum_oku = new SqlCommand("select * from yorum where reading=@read", baglan);
        yorum_oku.Parameters.Add("@read","1");
        SqlDataReader y_oku = yorum_oku.ExecuteReader();
        if (y_oku.Read())
        {
            int xm=1;
            int x = 0;
            string active = "item active animated bounceInRight row";
            string btnactive = "active";
            do
            {
                Session["@yorum"] = Session["@yorum"].ToString() + "<div class=\"" + active + "\"><div class=\"animated slideInLeft col-xs-2\"><img alt=\"portfolio\" src=\"library/images/" + y_oku["image"].ToString() + "\" width=\"100\" class=\"img-circle img-responsive\"></div><div  class=\"col-xs-10\"><p> " + y_oku["cont"].ToString() + "</p><span>" + y_oku["name"].ToString() + " - <b>" + y_oku["company"].ToString() + "</b></span></div></div>";
                Session["@yorumbtn"] = Session["@yorumbtn"].ToString() + "<li data-target=\"#carousel-testimonials\" data-slide-to=\"" + x + "\" class=\""+btnactive+"\"></li>";
                if (xm > 0)
                {
                    active = "item  animated bounceInRight row";
                }
                if (x == 0)
                {
                    btnactive = "";
                }
                xm++;
                x++;


            } while (y_oku.Read());

            

        }



         
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand mesaj = new SqlCommand("insert into visitor(name,mail,note,reading) values(@name,@mail,@note,@reading)",baglan);
        mesaj.Parameters.Add("@name",TextBox1.Text);
        mesaj.Parameters.Add("@mail",TextBox2.Text);
        mesaj.Parameters.Add("@note",TextBox4.Text);
        mesaj.Parameters.Add("@reading",Convert.ToInt16("0"));
        
        string bos="";
        
        
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox4.Text == "")
        {
            if (TextBox1.Text == "")
            {
                bos = bos + "Ad ve soyad girmediniz.<br>";
                Label1.Visible = true;
                Label1.Text = bos;
            }
            if (TextBox2.Text == "")
            {
                bos = bos + "Mail adresi girmediniz.<br>";
                Label1.Visible = true;
                Label1.Text = bos;
            }
            if (TextBox2.Text == "")
            {
                bos = bos + "Mesaj girmediniz.<br>";
                Label1.Visible = true;
                Label1.Text = bos;
            }
            if (TextBox1.Text == "" && TextBox2.Text == "" && TextBox4.Text == "")
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=" + "JavaScript" + ">alert(\"Spamdan dolayı ip adresiniz alınmıştır.\")</SCRIPT>");
            }

        }
        else
        {
            try
            {
                mesaj.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox4.Text = "";
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=" + "JavaScript" + ">alert(\"Mesajınız bize ulaşmıştır. Mesaj bıraktığınız için teşekkürler.\")</SCRIPT>");
            }
            catch (Exception)
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=" + "JavaScript" + ">alert(\"Mesajınızda hata oluştu. Lütfen kontrol edip tekrar deneyiniz. <br> İletişim@mehmetcabaoglu.com\")</SCRIPT>");
            }
        }
    }
}