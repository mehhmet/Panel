using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class library_admin_page_update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        /*CKEditor1.config.toolbar = new object[]
			{
				new object[] { "Source", "-", "NewPage", "Preview", "-", "Templates" },
				new object[] { "Cut", "Copy", "Paste", "PasteText", "PasteFromWord", "-", "Print", "SpellChecker", "Scayt" },
				new object[] { "Undo", "Redo", "-", "Find", "Replace", "-", "SelectAll", "RemoveFormat" },
				new object[] { "Form", "Checkbox", "Radio", "TextField", "Textarea", "Select", "Button", "ImageButton", "HiddenField" },
				"/",
				new object[] { "Bold", "Italic", "Underline", "Strike", "-", "Subscript", "Superscript" },
				new object[] { "NumberedList", "BulletedList", "-", "Outdent", "Indent", "Blockquote", "CreateDiv" },
				new object[] { "JustifyLeft", "JustifyCenter", "JustifyRight", "JustifyBlock" },
				new object[] { "BidiLtr", "BidiRtl" },
				new object[] { "Link", "Unlink", "Anchor" },
				new object[] { "Image", "Flash", "Table", "HorizontalRule", "Smiley", "SpecialChar", "PageBreak", "Iframe" },
				"/",
				new object[] { "Styles", "Format", "Font", "FontSize" },
				new object[] { "TextColor", "BGColor" },
				new object[] { "Maximize", "ShowBlocks" }
			};*/







        if(!IsPostBack)
        {
            Session["@pa_cont"] = "";
            string baglanti = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
            SqlCommand getir = new SqlCommand("select * from page_content where head=@head", baglan);
            getir.Parameters.Add("@head", Session["@update"].ToString());
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                int id = Convert.ToInt16(oku["page_id"]);
                TextBox1.Text = oku["head"].ToString();
                CKEditor1.Text = oku["page_content"].ToString();
                TextBox3.Text = id.ToString();

            }
            baglan.Close();
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            Session["@id"] = TextBox3.Text;
            Session["@header"] = TextBox1.Text;
            Session["@contenter"] = CKEditor1.Text;
            Response.Redirect("p_updated.aspx");
        

    }
}