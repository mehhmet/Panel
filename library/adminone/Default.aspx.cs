using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;


public partial class library_adminone_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            Session["@browser"] = "";
            System.Web.HttpBrowserCapabilities browser = Request.Browser;
            string name = browser.Browser;
            float version = (float)(browser.MajorVersion + browser.MinorVersion);
            if (name != "Chrome")
            {

                Session["@browser"] = "<div class=\"row\"><div class=\"col-lg-12\"><div class=\"bs-example\"><div class=\"alert alert-dismissable alert-danger\"><button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button><h4>Tarayıcı Tavsiyesi!</h4><p>Bu paneli Google Chrome ile kullanmanız tavsiye edilir. Henüz diğer tarayıcılarda test edilmemiştir.<br> Diğer tarayıcıda oluşan sorunlar için mail atabilirsiniz : iletisim@mehmetcabaoglu.com</p></div></div></div></div>";
            }
        

    }
    
}