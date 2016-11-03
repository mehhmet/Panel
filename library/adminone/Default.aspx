<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="library_adminone_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      
      <% Response.Write(Session["@browser"].ToString()); %>

      <div class="row">
          <div class="col-lg-12">
            <div class="bs-example">
              <div class="alert alert-dismissable alert-success">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                <h4>Neler Yeni</h4>
                <p>Panele gelen güncelleme ile aşağıdaki özellikler eklenmiştir.<br /><br />
                
                <ul>
                        <li>List Item</li>
                        <li>List Item</li>
                        <ul>
                            <li>List Item</li>
                            <li>List Item</li>
                            <li>List Item</li>
                        </ul>
                        <li>List Item</li>
                    </ul>
                
                
                </p>
              </div>
            </div>
          </div>
        </div>

      <div class="row">
          <div class="col-lg-12">
            <div class="bs-example">
              <div class="alert alert-dismissable alert-warning">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                <h4>Dikkat!</h4>
                <p>Okunmamış <a href="#" class="alert-link">40</a> adet mesajınız bulunmakta.</p>
              </div>
            </div>
          </div>
        </div><!-- /.row -->

        <div class="row">
         <div class="col-lg-12">
         <h2>İstatistikler</h2>
         </div>
        </div>




          <div class="row">
               <div class="col-lg-6">
                 
              <p>
              <button type="button" class="btn btn-success">Online Ziyaretçi Sayınız <span class="badge"> 15</span></button>
                <button type="button" class="btn btn-primary">Toplam Ziyaretçi Sayınız <span class="badge"> 5</span></button>
                
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

