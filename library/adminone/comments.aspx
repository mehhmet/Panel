<%@ Page Title="" Language="C#" MasterPageFile="~/library/adminone/admin.master" AutoEventWireup="true" CodeFile="comments.aspx.cs" Inherits="library_adminone_comments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row">
<div class="col-lg-12">
<div class="page-header"><h2>Gelen Yorum/Mesajlar</h2></div>
</div>


</div>




<div class="row">

<div class="col-lg-6">
Mesaj Başlığı Seçiniz : 

</div>
<div class="col-lg-6">
    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="btn btn-primary dropdown-toggle">
    <asp:ListItem>Seçiniz</asp:ListItem>
    <asp:ListItem>Gelen ilk mesaj</asp:ListItem>
    </asp:DropDownList>

</div>

</div>

<div class="row">
<div class="col-lg-6">Mesaj Başlığı</div>
<div class="col-lg-6">Gelen İlk Mesaj</div>
</div>

<div class="row">
<div class="col-lg-6">Mesajı Yazan</div>
<div class="col-lg-6">Mehmet CABAOĞLU</div>
</div>

<div class="row">
<div class="col-lg-6">Mesajı Yazanın Mail Adresi</div>
<div class="col-lg-6">iletisim@mehmetcabaoglu.com</div>
</div>

<div class="row">
<div class="col-lg-6">Mesaj</div>
<div class="col-lg-6">Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan "de Finibus Bonorum et Malorum" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan "Lorem ipsum dolor sit amet" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir.

1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.</div>
</div>

<div class="row">
<div class="col-lg-6">Bırakılan Dosyalar</div>
<div class="col-lg-6"><a href="#modal">Deneme</a></div>
</div>
<div class="row">
<div class="col-lg-6">İşlem</div>
<div class="col-lg-6">
    <div class="col-lg-4"><asp:Button ID="Button1" runat="server" Text="Okundu" CssClass="btn btn-primary" /></div>
    <div class="col-lg-4"><asp:Button ID="Button2" runat="server" Text="Cevap Yaz" CssClass="btn btn-success" /></div>
    <div class="col-lg-4"><asp:Button ID="Button3" runat="server" Text="Mesajı Sil" CssClass="btn btn-danger" /></div>
    
</div>
</div>



<div id="modal" class="modalDialog">
	<div>


		<a href="#close" title="Close" class="close"><i class="fa fa-times" aria-hidden="true"></i></a>
		<div class="page-header"><h2>Dosya Adı &nbsp&nbsp&nbsp<a href="#" style="color:#151515"><i class="fa fa-download" aria-hidden="true"></i></a></h2></div>

        <div class="row">
            <div class="col-lg-8"><img src="../../library/images/1.jpg" width="100%" style="max-height:450px;" /></div>
            <div class="col-lg-4">
                <div class="row">
                Dosya adı: berkay.jpg<br />
                Dosya türü: image/jpg<br />
                Yüklenme tarihi: 31 Ekim 2016<br />
                Dosya boyutu: 1.31 MB<br />
                Ölçüler: 1840 x 3264<br />
                
                </div>
                <hr />
                
                
                
            
            
            
            
            </div>
        
        </div>




	</div>
</div>


</asp:Content>

