<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="personel.aspx.cs" Inherits="library_adminone_personel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="row">
<div class="col-lg-12">
<div class="bs-example">
              <ul class="nav nav-tabs" style="margin-bottom: 15px;">
                <li class="active"><a href="#home" data-toggle="tab">Admin Ekle</a></li>
                <li><a href="#pdelete" data-toggle="tab">Admin Sil</a></li>
                <li><a href="#pass" data-toggle="tab">Şifre İşlemleri</a></li>
                <li><a href="#profil" data-toggle="tab">Profil Görüntüle</a></li>
                
              </ul>
              <div id="myTabContent" class="tab-content">
                <div class="tab-pane fade active in" id="home">
                  <p>
                  
                    <div class="col-lg-12">
                        <asp:TextBox ID="TextBox1" runat="server" PlaceHolder="E-Mail Adresini Giriniz..." CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-lg-12" style="text-align:center;">
                    
                            <asp:Button ID="Button1" runat="server" Text="Kaydet" 
                                CssClass="btn btn-primary" onclick="Button1_Click" />
                    </div>
                    
                  
                  </p>
                </div>
                <div class="tab-pane fade" id="pdelete" style="text-align:center">
                  <p>




                  




                  </p>
                </div>
                <div class="tab-pane fade" id="pass">
                  <p>Şifre Tabı</p>
                </div>
                <div class="tab-pane fade" id="profil" >
                  <p>


                  <div class="row" >
                  <div class="col-lg-2">
                  İD

                  </div>
                  <div class="col-lg-2">
                  1167008035

                  </div>
                  
                  </div>
                  
                  <div class="row" >
                  <div class="col-lg-2">
                  İsim Soyisim

                  </div>
                  <div class="col-lg-2">
                  Mehmet CABAOĞLU

                  </div>
                  
                  </div>

                  <div class="row" >
                  <div class="col-lg-2">
                  Mail Adresi

                  </div>
                  <div class="col-lg-2">
                  iletisim@mehmetcabaoglu.com

                  </div>
                  
                  </div>

                  <div class="row" >
                  <div class="col-lg-2">
                  Telefon Numarası

                  </div>
                  <div class="col-lg-2">
                  05419568818

                  </div>
                  
                  </div>

                  



                  <div class="row" >
                  <div class="col-lg-4">

                  
                  <ul class="pager">
                <li class="previous"><a href="#">← Önceki</a></li>
                               
                <li class="next"><a href="#">Sonraki →</a></li>
              </ul>
                  
                  
                  </div>
                  </div>
                  
                  
                  
                  
                  
                  </p>
                </div>
              </div>
            </div>
            </div>
            </div>
</asp:Content>

