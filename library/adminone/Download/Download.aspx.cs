using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class library_adminone_Download_Download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string FileName = Session["@inecek_dosya_adi"].ToString() ;
        System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
        response.ClearContent();
        response.Clear();
        response.ContentType = Session["@inecek_dosya_turu"].ToString();
        response.AddHeader("Content-Disposition", "attachment; filename=" + FileName + ";");
        response.TransmitFile(Server.MapPath(Session["@inecek_dosya_yolu"].ToString()));
        response.Flush();
        response.End();
    }
}