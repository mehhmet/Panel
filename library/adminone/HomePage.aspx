<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="library_adminone_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      
      <%Response.Write(Session["@browser"].ToString()); %>

      <%Response.Write(Session["@pver"].ToString()); %>
      
      
    <asp:Panel ID="message" runat="server">
    <div class="row">
          <div class="col-lg-12">
            <div class="bs-example">
              <div class="alert alert-dismissable alert-warning">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                <h4>Dikkat!</h4>
                <p>Okunmamış <a href="#" class="alert-link"><% Response.Write(Session["@okunmamis"]); %></a>, ve okunmuş 
                <a href="#" class="alert-link"><% Response.Write(Session["@okunmus"]); %></a> olmak üzere toplamda 
                <a href="#" class="alert-link"><% Response.Write(Session["@toplam"]); %></a>
                 adet mesajınız bulunmakta.</p>
              </div>
            </div>
          </div>
        </div>
    </asp:Panel>
      <!-- /.row -->

        <div class="row">
         <div class="col-lg-12">
         <h2>İstatistikler</h2>
         </div>
        </div>




          <div class="row">
               <div class="col-lg-6">
                 
              <p>
              <button type="button" class="btn btn-success">Toplam Ziyaretçi Sayınız <span class="badge"> <% Response.Write(Session["@online"].ToString()); %></span></button>
                <button type="button" class="btn btn-primary">Toplam Mesaj Sayınız <span class="badge"> <% Response.Write(Session["@toplam"].ToString()); %></span></button>
                
              </p>
              </div>
              
              <div class="col-lg-6">
             
              <p>
              <button type="button" class="btn btn-danger" >Toplam Fotoğraf Sayınız <span class="badge"> 15</span></button>
                <button type="button" class="btn btn-danger" >Toplam Sayfa Sayınız <span class="badge"> 5</span></button>
                
              </p>


               </div>


          </div>





          


          




          




</asp:Content>

