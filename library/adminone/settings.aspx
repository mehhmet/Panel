<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="settings.aspx.cs" Inherits="library_adminone_settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="row">
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox1" runat="server" />
        Panel Güncelleme Bildirimi
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox2" runat="server" />
        Tarayıcı bildirimi
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox3" runat="server" />
        Mesaj Bildirimi
    </div>
    <div class="col-lg-3">
        <asp:CheckBox ID="CheckBox4" runat="server" />
        Sliderı
    </div>
    
</div>
<div class="row">
<div class="col-lg-12">
    <asp:Button ID="Button1" runat="server" Text="Kaydet" 
        CssClass="btn btn-success" onclick="Button1_Click"/></div>
</div>
</asp:Content>

