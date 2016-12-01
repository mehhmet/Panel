<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="reset.aspx.cs" Inherits="library_adminone_reset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row">
    <div class="col-lg-12">
        
        <h2>Sıfırlama Seçenekleri</h2>
    </div>

</div>

<div class="row">
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox1" runat="server" />
        Dil Ayarları
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox2" runat="server" />
        Sayfaları 
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox3" runat="server" />
        Galeriyi
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox4" runat="server" />
        Sliderı
    </div>
    
</div>
<div class="row">
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox5" runat="server" />
        Ürünleri
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox6" runat="server" />
        Personelleri
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox7" runat="server" />
        Mesajları
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox8" runat="server" />
        Toplam Ziyaretçi
    </div>
    
</div>
<div class="row">

    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox9" runat="server" />
        Admin Giriş Tarihleri
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox10" runat="server" />
        Admin Fotoğrafları
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox11" runat="server" />
        Admin Profil Bilgileri
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox12" runat="server" />
        Adminleri(Master Hariç)
    </div>
    
</div>
<div class></div>
<div class="page-header"></div>




<div class="row" style="text-align:center;">
    <div class="col-lg-12">

        <asp:Button ID="Button1" runat="server" Text="Sıfırla" CssClass="btn btn-success" />
    </div>

</div>

</asp:Content>

