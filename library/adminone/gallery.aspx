<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="library_adminone_gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<style>
    
        .col-lg-2 img {
            filter: gray; /* IE6-9 */
            -webkit-filter: grayscale(1); /* Google Chrome, Safari 6+ & Opera 15+ */
            -webkit-box-shadow: 0px 2px 6px 2px rgba(0,0,0,0.75);
            -moz-box-shadow: 0px 2px 6px 2px rgba(0,0,0,0.75);
            box-shadow: 0px 2px 6px 2px rgba(0,0,0,0.75);
            margin-bottom: 20px;
        }
        .col-lg-2 img:hover {
            filter: none; /* IE6-9 */
            -webkit-filter: grayscale(0); /* Google Chrome, Safari 6+ & Opera 15+ */
        }
        
        
        
        
        

        
        
        
    </style>


<div class="row">
<div class="page-header"><h2><p class="text-primary">Dosya Galerisi</p></h2></div>
</div>

    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" Visible="false"/>
<% Response.Write(Session["@fotolar"].ToString()); %>
<% Response.Write(Session["@popup"].ToString()); %>
<!--

<a href="#modal"><div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/1.jpg" /></div></a>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/2.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/3.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/4.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/5.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/6.jpg" /></div>





<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/1.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/2.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/3.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/4.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/5.jpg" /></div>
<div class="col-lg-2"><img width="100%" height="100%" src="../../library/images/6.jpg" /></div>









<div id="modal" class="modalDialog">
	<div>


		<a href="#close" title="Close" class="close"><i class="fa fa-times" aria-hidden="true"></i></a>
		<div class="page-header"><h2>Dosya Detayları</h2></div>

        <div class="row">
            <div class="col-lg-8"><img src="../../library/images/1.jpg" width="100%" /></div>
            <div class="col-lg-4">
                <div class="row">
                Dosya adı: berkay.jpg<br />
                Dosya türü: image/jpg<br />
                Yüklenme tarihi: 31 Ekim 2016<br />
                Dosya boyutu: 1.31 MB<br />
                Ölçüler: 1840 x 3264<br />
                
                </div>
                <hr />
                <div class="row" style="text-align:right;margin-bottom:5px;">
                    <div class="col-lg-4" style="text-align:right;">URL</div>
                    <div class="col-lg-8">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Enabled="false" Text="http://localhost:52970/myweb/library/images/berkay.jpg"></asp:TextBox></div>


                </div>
                <div class="row" style="text-align:right;margin-bottom:5px;">
                    <div class="col-lg-4" style="text-align:right;">Açıklama</div>
                    <div class="col-lg-8">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" style="max-width:100%;max-height:150px;" TextMode="MultiLine"></asp:TextBox></div>


                </div>
                <div class="row" style="text-align:right;margin-bottom:5px;">
                    <div class="col-lg-4" style="text-align:right;">Yükleyen</div>
                    <div class="col-lg-8"><p class="text-danger">Mehmetcbgl</p></div>


                </div>
            
            
            
            
            </div>
        
        </div>




	</div>
</div>-->


</asp:Content>

