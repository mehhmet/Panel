<%@ Page Title="" Language="C#" MasterPageFile="~/library/admin/admin.master" AutoEventWireup="true" CodeFile="visitor.aspx.cs" Inherits="library_admin_visitor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <% Response.Write(Session["@mesaj"].ToString()); %>
    <br />
    <asp:Button ID="Button1" runat="server" Text="okudum" CssClass="myButton" 
        onclick="Button1_Click" />
</asp:Content>

