<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="language.aspx.cs" Inherits="library_adminone_language" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div class="row">

    <div class="col-lg-3" style="text-align:center;">
    
    Türkçe
    </div>
    <div class="col-lg-3" style="text-align:center;">
    
    İngilizce
    </div>
    <div class="col-lg-3" style="text-align:center;">
    
    İspanyolca
    </div>
    <div class="col-lg-3" style="text-align:center;">
    
    Almanca
    </div>

</div>
<%Response.Write(Session["@form"].ToString()); %>


<div class="row">

<div class="col-lg-12" style="text-align:center;">
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Kaydet" />
</div>

</div>

</asp:Content>

