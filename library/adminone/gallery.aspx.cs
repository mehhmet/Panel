using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_adminone_gallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["@fotolar"] = "";
        Session["@popup"] = "";
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand gallery = new SqlCommand("select * from gallery",baglan);
        SqlDataReader oku = gallery.ExecuteReader();
        if(oku.Read())
        {
            do
            {
                
                Session["@fotolar"] = Session["@fotolar"].ToString() + "<a href=\"#" + oku["name"].ToString() + "\"><div class=\"col-lg-2\"><img width=\"100%\" height=\"100%\" src=\"../../library/images/"+oku["name"].ToString()+"\" /></div></a>";
                Session["@popup"] = Session["@popup"].ToString() + "<div id=\"" + oku["name"].ToString() + "\" class=\"modalDialog\"><div><a href=\"#close\" title=\"Kapat\" class=\"close\"><i class=\"fa fa-times\" aria-hidden=\"true\"></i></a><div class=\"page-header\"><h2>Dosya Detayları </h2></div><div class=\"row\"><div class=\"col-lg-8\"><img src=\"../../library/images/"+oku["name"].ToString()+"\" width=\"100%\" /></div><div class=\"col-lg-4\"><div class=\"row\">Dosya adı: "+oku["name"].ToString()+"<br />Dosya türü: image/jpg<br />Yüklenme tarihi: "+ oku["upload_date"].ToString() +"<br />Dosya boyutu: "+oku["size"].ToString()+"<br />Ölçüler: "+oku["resulation"].ToString()+"<br /></div><hr /><div class=\"row\" style=\"text-align:right;margin-bottom:5px;\"><div class=\"col-lg-4\" style=\"text-align:right;\">URL "+ oku["url"].ToString() +" </div><div class=\"col-lg-8\"><asp:TextBox ID=\"TextBox1\" runat=\"server\" CssClass=\"form-control\" Enabled=\"false\" Text=\"deneme\"></asp:TextBox></div></div><div class=\"row\" style=\"text-align:right;margin-bottom:5px;\"><div class=\"col-lg-4\" style=\"text-align:right;\">Açıklama</div><div class=\"col-lg-8\"><asp:TextBox ID=\"TextBox2\" runat=\"server\" CssClass=\"form-control\" style=\"max-width:100%;max-height:150px;\" TextMode=\"MultiLine\"></asp:TextBox></div></div><div class=\"row\" style=\"text-align:right;margin-bottom:5px;\"><div class=\"col-lg-4\" style=\"text-align:right;\">Yükleyen</div><div class=\"col-lg-8\"><p class=\"text-danger\">Mehmetcbgl</p></div></div></div></div></div></div>";
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    ;
            } while (oku.Read());
        }
        //<a href="#modal"><div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/1.jpg" /></div></a>
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}