using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_picture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["@picture"] = "<table style=\"text-align:center;min-width:200px;\"><tr><td>İd</td><td width=10px></td><td>Konum</td><td>Fotoğraf Adı</td><td>Açıklama</td</tr>";
        string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection baglan = new SqlConnection(baglanti);
        baglan.Open();
        SqlCommand sayfa = new SqlCommand("select * from picture", baglan);
        SqlDataReader oku = sayfa.ExecuteReader();
            if (oku.Read())
            {
                int x=1;
                do
                {
                    Session["@picture"] =Session["@picture"].ToString() +"<tr><td>" + oku["id"] +"</td><td></td><td>"+ oku["location"].ToString() +"</td><td>"+ oku["name"].ToString() + "</td><td>" + oku["cont"].ToString()+ "</td></tr>";
                    x++;
                } while (oku.Read());
                Session["@picture"] = Session["@picture"].ToString() + "</table>";
            }
            baglan.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != null && TextBox1.Text != "")
        {
            tablom.Visible = true;
            Panel3.Visible = true;
            string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
            SqlCommand getir = new SqlCommand("select * from picture where id=@id",baglan);
            getir.Parameters.Add("@id", Convert.ToInt32(TextBox1.Text));
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                TextBox2.Text = oku["location"].ToString();
                TextBox3.Text = oku["name"].ToString();
                TextBox5.Text = oku["cont"].ToString();
                Image1.ImageUrl = "../images/" + oku["name"].ToString();
                Label1.Text = "";
                TextBox1.Enabled = false;

            }
            else
            {
                tablom.Visible = false;
                Label1.Text = "Girdiğiniz id hiçbir fotoğraf ile eşleşmedi...";
            }
        }
        else
        {
            Panel3.Visible = true;
            tablom.Visible = false;
            Label1.Visible = true;
            Label1.Text = "İd girmediniz.";
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Value == "delete")
        {
            FileUpload1.Visible = false;
            TextBox2.Enabled = false;
            Button2.Text = "Sil";
        }
        else
        {
            FileUpload1.Visible = true;
            TextBox2.Enabled = true;
            TextBox5.Enabled = true;
            Button2.Text = "Güncelle";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Button2.Text == "Sil")
        {
            string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from picture where id=@id",baglan);
            sil.Parameters.Add("@id",Convert.ToInt32(TextBox1.Text));
            try
            {
                sil.ExecuteNonQuery();
                TextBox1.Enabled = true;
                Response.Redirect("picture.aspx");
            }
            catch (Exception)
            {
                
                
            }
            baglan.Close();
 
        }
        else if (Button2.Text == "Güncelle")
        {
            string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
            SqlCommand update = new SqlCommand("update picture set location=@location,name=@name,cont=@cont where id=@id",baglan);
            update.Parameters.AddWithValue("@location",TextBox2.Text);
            if(FileUpload1.HasFile)
            {
                update.Parameters.AddWithValue("@name",FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/library/images/") + FileUpload1.FileName);
            }
            else
            {
                update.Parameters.AddWithValue("@name",TextBox3.Text);
                Label1.Visible = true;
                Label1.Text = "Resim seçmediğiniz için eski fotoğraf kaldı...";
            }
            update.Parameters.AddWithValue("@cont",TextBox5.Text);
            update.Parameters.AddWithValue("@id",TextBox1.Text);
            try
            {
                update.ExecuteNonQuery();
                TextBox1.Enabled = true;
                Response.Redirect("picture.aspx");
            }
            catch (Exception)
            {
                
               
            }
            
        }

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            Panel5.Visible = true;
        }
        else
        {
            Panel5.Visible = false;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (FileUpload2.HasFile && TextBox4.Text != null)
        {
            string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into picture(location,name) values(@location,@name)",baglan);
            ekle.Parameters.Add("@location",TextBox4.Text);
            ekle.Parameters.Add("@name", FileUpload2.FileName);
            FileUpload2.SaveAs(Server.MapPath("~/library/images/")+FileUpload2.FileName);
            ekle.ExecuteNonQuery();
        
        }
    }
}