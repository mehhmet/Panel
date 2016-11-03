<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="pages.aspx.cs" Inherits="library_adminone_pages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div class="row">
<div class="page-header"><h2>Sayfa Yönetimi</h2></div>
</div>

<div class="row">
<div class="col-lg-12">

<div class="bs-example">
              <ul class="nav nav-tabs" style="margin-bottom: 15px;">
                <li class="active"><a href="#home" data-toggle="tab">Sayfa Ekle</a></li>
                <li><a href="#pdelete" data-toggle="tab">Sayfa Sil</a></li>
                <li><a href="#pass" data-toggle="tab">Sayfa Düzenle</a></li>
                
                
              </ul>


              <div id="myTabContent" class="tab-content">
                <div class="tab-pane fade active in" id="home">
                  <p>
                  
                    <div class="col-lg-12">
                        <asp:TextBox ID="TextBox1" runat="server" PlaceHolder="Sayfa Adını Giriniz..." CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-lg-12" style="text-align:center;">
                    
                            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" />
                    </div>
                    
                  
                  </p>
                </div>
                <div class="tab-pane fade" id="pdelete" style="text-align:center">
                  <p>


                  Silme Tabı

                  




                  </p>
                </div>
                <div class="tab-pane fade" id="pass">
                  <p>
                  
                  
                 


                  

                  

                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-6"><a href="#modal">Sayfa Adı</a></div>
                  <div class="col-lg-6">
                      
                      </div>

                  </div>


                  </div>
                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-6">Sayfa Adı</div>
                  <div class="col-lg-6"></div>

                  </div>


                  </div>
                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-6">Sayfa Adı</div>
                  <div class="col-lg-6"></div>

                  </div>


                  </div>
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  </p>
                </div>
                
              </div>
            </div>
            </div>
            </div>



            <div id="modal" class="modalDialog">
	<div>


		<a href="#close" title="Close" class="close"><i class="fa fa-times" aria-hidden="true"></i></a>
		<div class="page-header"><h2>Sayfa Detayları</h2></div>

        <div class="row">
            <div class="col-lg-8">
            
            <CKEditor:CKEditorControl ID="CKEditor1" runat="server" Height="300" Width="95%" BasePath="~/ckeditor">
		
		</CKEditor:CKEditorControl>
            
            
            
            
            
            </div>
            <div class="col-lg-4">
                <div class="row">
                Sayfa Adı: Anasayfa<br />
                Menü Durumu:     
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked  /><br />
                Oluşturulma Tarihi: 31 Ekim 2016<br />
                
                
                </div>
                <hr />
                <div class="row" style="text-align:right;margin-bottom:5px;">
                    <div class="col-lg-4" style="text-align:right;">URL</div>
                    <div class="col-lg-8">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Enabled="false" Text="http://localhost:52970/myweb/library/images/berkay.jpg"></asp:TextBox></div>


                </div>
                
                <div class="row" style="text-align:right;margin-bottom:5px;">
                    <div class="col-lg-4" style="text-align:right;">Oluşturan</div>
                    <div class="col-lg-8"><p class="text-danger">Mehmetcbgl</p></div>


                </div>
                <div class="row" style="text-align:right;margin-bottom:5px;">
                    <div class="col-lg-12" style="text-align:center;">
                        <asp:Button ID="Button2" runat="server" Text="Kaydet"  CssClass="btn btn-success"/></div>
                    


                </div>
            
            
            
            
            </div>
        
        </div>




	</div>
</div>



</asp:Content>

