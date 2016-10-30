<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        Application["OnlineZiyaretci"] = 0;
        Application["ToplamZiyaretci"] = 0;

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        Application.Remove("OnlineZiyaretci");

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["OnlineZiyaretci"] = (int)Application["OnlineZiyaretci"] + 1; //Burada sitemize yeni bir kullanıcı girdiğini anlıyoruz ve OnlineZiyaretçi sayımızı 1 artırıyoruz.
        Application["ToplamZiyaretci"] = (int)Application["ToplamZiyaretci"] + 1;
        Application.UnLock();

    }

    void Session_End(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["OnlineZiyaretci"] = (int)Application["OnlineZiyaretci"] - 1;  //Burada sitemizden bir kullanıcının ayrılmış olduğunu anlıyoruz ve OnlineZiyaretçi sayımızı 1 azaltıyoruz.
        Application.UnLock();

    }
       
</script>
