<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="comments.aspx.cs" Inherits="library_adminone_comments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row">
<div class="col-lg-12">
<div class="page-header"><h2>Gelen Yorum/Mesajlar</h2></div>
</div>


</div>




<div class="row">

<div class="col-lg-6" style="color:#cc0000;">
Mesaj Başlığı Seçiniz : 

</div>
<div class="col-lg-6">
    <asp:DropDownList ID="DropDownList1" runat="server" 
        CssClass="btn btn-primary dropdown-toggle" AutoPostBack="True" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    
    </asp:DropDownList>

</div>

</div>
<br />
<div class="row">
<div class="col-lg-6" style="color:#77b300;">Mesaj Başlığı</div>
<div class="col-lg-6">
    <asp:Label ID="baslik" runat="server" Text="Label" Visible="false"></asp:Label></div>
</div>
<br />
<div class="row">
<div class="col-lg-6" style="color:#77b300;">Mesajı Yazan</div>
<div class="col-lg-6">
    <asp:Label ID="name" runat="server" Text="Label" Visible="false"></asp:Label></div>
</div>
<br />
<div class="row">
<div class="col-lg-6" style="color:#77b300;">Mesajı Yazanın Mail Adresi</div>
<div class="col-lg-6">
    <asp:Label ID="mail" runat="server" Text="Label" Visible="false"></asp:Label></div>
</div>
<br />
<div class="row">
<div class="col-lg-6" style="color:#77b300;">Mesaj</div>
<div class="col-lg-6">
    
</div>
</div>

<br />


<div class="row">
<div class="col-lg-3"></div>
<div class="col-lg-6" style="color:#2a9fd6;">
    <asp:Label ID="note" runat="server" Text="Label" Visible="false"></asp:Label>
</div>
<div class="col-lg-3"></div>
</div>


<br />
<div class="row">
<div class="col-lg-6" style="color:#77b300;">Bırakılan Dosyalar</div>
<div class="col-lg-6">
    <asp:Panel ID="Panel1" runat="server" Visible="false">
    <a href="#modal" style="text-decoration:underline;">Deneme</a>
    </asp:Panel>
    
    
    </div>
    
    
</div>
<br /><br />
<div class="row">
<div class="col-lg-4"></div>
<div class="col-lg-4">

    <div class="col-lg-4"><asp:Button ID="Button1" runat="server" Text="Okundu" 
            CssClass="btn btn-primary" onclick="Button1_Click" Visible="false" /></div>

    <div class="col-lg-4"><asp:Button ID="Button2" runat="server" Text="Cevap Yaz" CssClass="btn btn-success" Visible="false"/></div>
    <div class="col-lg-4"><asp:Button ID="Button3" runat="server" Text="Mesajı Sil" 
            CssClass="btn btn-danger" onclick="Button3_Click" Visible="false" /></div>
    
</div>
<div class="col-lg-4"></div>
</div>



<div id="modal" class="modalDialog">
	<div>
    

		<a href="#close" title="Close" class="close"><i class="fa fa-times" aria-hidden="true"></i></a>
		<div class="page-header"><h2>Dosya Adı &nbsp&nbsp&nbsp<a class="myicon" href="Download/Download.aspx" style="color:#151515"><i class="fa fa-download" aria-hidden="true"></i></a></h2></div>

        <div class="row">
            <div class="col-lg-8"><img src="../../library/images/1.jpg" width="100%" style="max-height:450px;" /></div>
            <div class="col-lg-4">
                <div class="row">
                Dosya adı: berkay.jpg<br />
                Dosya türü: image/jpg<br />
                Yüklenme tarihi: 31 Ekim 2016<br />
                Dosya boyutu: 1.31 MB<br />
                Ölçüler: 1840 x 3264<br />
                
                </div>
                <hr />
                
                
                
            
            
            
            
            </div>
        
        </div>




	</div>
</div>


</asp:Content>

