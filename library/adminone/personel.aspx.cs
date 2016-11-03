using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class library_adminone_personel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage mesaj = new MailMessage();
        string host = "mail.mehmetcabaoglu.com";
        string smtpuser = "iletisim@mehmetcabaoglu.com";
        string smtppassword = "password";
        mesaj.From = new MailAddress("iletisim@mehmetcabaoglu.com");
        mesaj.Subject = "Konu Buraya";
        mesaj.Body = "Mail içeriği buraya";
        mesaj.IsBodyHtml = true;
        mesaj.BodyEncoding = System.Text.Encoding.UTF8;
        mesaj.To.Add(new MailAddress("iletisim@mehmetcabaoglu.com"));
        int smtpport = 587;
        SmtpClient smtp = new SmtpClient(host, smtpport);
        smtp.EnableSsl = false;
        smtp.Credentials = new System.Net.NetworkCredential(smtpuser, smtppassword);
        smtp.Send(mesaj);
    }
}