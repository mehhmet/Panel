
<%@ Page Title="" Language="C#" MasterPageFile="~/library/admin/admin.master" AutoEventWireup="true" CodeFile="page_update.aspx.cs" Inherits="library_admin_page_update" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    Başlık =
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
Sayfa İd =
<asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
    <br />
    İçerik
    <CKEditor:CKEditorControl ID="CKEditor1" runat="server" Height="200" Width="95%" BasePath="~/ckeditor">
		
		</CKEditor:CKEditorControl>
    
    <br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" 
    onclick="Button1_Click" />


</asp:Content>

