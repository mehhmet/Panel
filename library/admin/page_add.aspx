<%@ Page Title="" Language="C#" MasterPageFile="~/library/admin/admin.master" AutoEventWireup="true" CodeFile="page_add.aspx.cs" Inherits="library_admin_page_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Sayfa Başlığı 
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    Sayfa İçeriği
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox><br />
    Menü'ye Eklensin mi? 
    <asp:CheckBox ID="CheckBox1" runat="server" /><br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" onclick="Button1_Click" />

</asp:Content>

