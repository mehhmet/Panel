<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="library_adminone_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Giriş Yap</title>

    <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="font-awesome/css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/local.css" />

    <script type="text/javascript" src="js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-wrapper">

            <div class="row">

                <div class="col-lg-12 text-center v-center">

                    <h1>Giriş Yap</h1>
                    


                    <br>
                    <br>

                    <div class="col-lg-12">
                        <div class="input-group" style="width: 330px; text-align: center; margin: 0 auto;">
                            <asp:TextBox ID="TextBox1" runat="server" class="form-control input-lg" style="border-radius:10px;" placeholder="Mail Adresinizi Girin"></asp:TextBox>
                            <br /><br><br>
                        <asp:TextBox ID="TextBox2" class="form-control input-lg" style="border-radius:10px;" placeholder="Şifrenizi Girin" runat="server" TextMode="Password"></asp:TextBox>
                                
                            <span class="input-group-btn">
                                
                        </div>
                    </div>
                    
                    <div class="col-lg-12">
                            
                            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" class="btn btn-lg btn-primary" onclick="Button1_Click" />
                            
                            <asp:LinkButton ID="LinkButton1" Visible="false" runat="server" CssClass="btn btn-link" onclick="LinkButton1_Click">Şifremi Unuttum</asp:LinkButton>
                           <br /><br />
                            <asp:Label ID="Label1" runat="server" Visible="false" CssClass="label label-danger" Text="Yanlış Giriş Yaptınız..."></asp:Label>
                                
                       
                    </div>
                </div>
            </div>
            <br /><br /><br /><br />
            <div class="text-center">
                <h1>Bizi Takip Edin</h1>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center v-center" style="font-size: 39pt;">
                    <a href="#"><span class="avatar"><i class="fa fa-facebook"></i></span></a>
                    <a href="#"><span class="avatar"><i class="fa fa-instagram"></i></span></a>
                    <a href="#"><span class="avatar"><i class="fa fa-twitter"></i></span></a>
                    <a href="#"><span class="avatar"><i class="fa fa-github"></i></span></a>
                </div>

            </div>
            <!-- /.row -->

        </div>
    </form>
</body>
</html>
