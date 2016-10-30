<%@ Page Title="" Language="C#" MasterPageFile="~/library/admin/admin.master" AutoEventWireup="true" CodeFile="pages.aspx.cs" Inherits="library_admin_pages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:80%;margin:0 auto 15px auto;text-align:center;font-size:16px;padding:5px;">
        <asp:Button ID="Button1" runat="server" Text="Sayfa Ekle" 
            onclick="Button1_Click" CssClass="myButton" />
        <asp:Button ID="Button2" runat="server" Text="Sayfa Güncelle" 
            onclick="Button2_Click" CssClass="myButton" />
        <asp:Button ID="Button4" runat="server" Text="Sayfa Sil" 
            onclick="Button4_Click" CssClass="myButton" />
    </div>
    <asp:Panel ID="Panel1" runat="server" Visible="true" >
    
    <%Response.Write(Session["@sayfalar"]); %>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="false">
        
        <center>
        <asp:ListBox ID="ListBox1" runat="server" CssClass="listbox1"></asp:ListBox>
        <br />
            <asp:Button ID="Button3" runat="server" Text="Sayfa Seç" onclick="Button3_Click" CssClass="myButtonS" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Seçim yapmadınız..." Visible="false"></asp:Label>
        </center>

    </asp:Panel>
</asp:Content>

