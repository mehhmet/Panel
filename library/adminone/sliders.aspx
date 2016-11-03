<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="sliders.aspx.cs" Inherits="library_adminone_sliders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div class="row">
<div class="page-header"><h2>Slider Ayarları</h2></div>
</div>

<div class="row">
<div class="col-lg-12">

<div class="bs-example">
              <ul class="nav nav-tabs" style="margin-bottom: 15px;">
                <li class="active"><a href="#home" data-toggle="tab">Slider Ekle</a></li>
                <li><a href="#pdelete" data-toggle="tab">Slider Sil</a></li>
                <li><a href="#pass" data-toggle="tab">Slider 1</a></li>
                
                
              </ul>


              <div id="myTabContent" class="tab-content">
                <div class="tab-pane fade active in" id="home">
                  <p>
                  
                    <div class="col-lg-12">
                        <asp:TextBox ID="TextBox1" runat="server" PlaceHolder="Slider Adını Giriniz..." CssClass="form-control"></asp:TextBox>
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
                  <div class="col-lg-6">
                      <center><asp:FileUpload ID="FileUpload1" runat="server" style="margin-top:10px;" /></center>
                  
                  
                  </div>
                  <div class="col-lg-6">
                      <asp:Button ID="Button2" runat="server" Text="Kaydet" CssClass="btn btn-primary" /></div>

                  </div>


                  </div>
                  <div class="row">
                  <hr />
                  </div>


                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-4">
                  <img src="../images/1.jpg" width="100%" />
                  <div class="row">
                  <hr />
                  </div>
                  </div>
                  <div class="col-lg-8">
                  
                  
                  
                  </div>

                  </div>


                  </div>

                  

                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-6">Fotoğraf</div>
                  <div class="col-lg-6">Seçenekler</div>

                  </div>


                  </div>
                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-6">Fotoğraf</div>
                  <div class="col-lg-6">Seçenekler</div>

                  </div>


                  </div>
                  <div class="row">
                  <div class="col-lg-12">
                  <div class="col-lg-6">Fotoğraf</div>
                  <div class="col-lg-6">Seçenekler</div>

                  </div>


                  </div>
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  
                  </p>
                </div>
                
              </div>
            </div>
            </div>
            </div>


</asp:Content>

