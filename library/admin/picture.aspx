<%@ Page Title="" Language="C#" MasterPageFile="~/library/admin/admin.master" AutoEventWireup="true" CodeFile="picture.aspx.cs" Inherits="library_admin_picture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" style="float:left;max-height:120px;overflow-y:scroll" >
    <% Response.Write(Session["@picture"].ToString()); %>
    </asp:Panel>
    
    <asp:Panel ID="Panel2" runat="server" style="float:left;margin-left:100px;">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="İd giriniz..."></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Fotoğrafı Seç" 
        CssClass="myButton" onclick="Button1_Click" /><br />
        <asp:Panel ID="Panel3" runat="server" Visible="False">
            <asp:Panel ID="tablom" runat="server">
            
        <table border="1" >
        <tr>
        <td rowspan="4">
        <asp:Image ID="Image1" runat="server" Width="100px" Height="100px" />
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Enabled="false"></asp:TextBox></td></td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Enabled="false"></asp:TextBox>
            </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Enabled="false"></asp:TextBox></td></td>
        </tr>
        <tr>
        <td colspan="2">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="RadioButtonList1_SelectedIndexChanged"  >
                <asp:ListItem Value="delete" >Silmek istiyorum.</asp:ListItem>
                <asp:ListItem Value="update" >Güncellemek istiyorum.</asp:ListItem>
            </asp:RadioButtonList>
            
        </td>
        </tr>
        
        <tr>
        <td colspan="2" align="center">
            <asp:FileUpload ID="FileUpload1" runat="server" Visible="false"/>
        
            <asp:Button ID="Button2" runat="server" Text="Sil" CssClass="myButton" 
                onclick="Button2_Click" /></td>
        </tr>
        </table>
        </asp:Panel>

            <br /><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </asp:Panel>
        </asp:Panel>
        <br /><br /><br /><br /><br /><br /><br /><br /><br />
        <asp:Panel ID="Panel4" runat="server" style="">
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                oncheckedchanged="CheckBox1_CheckedChanged" 
                Text="Resim eklemek istiyorum." />
            <asp:Panel ID="Panel5" runat="server" Visible="False">

                Dosyanın Konumu = <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                
                <asp:FileUpload ID="FileUpload2" runat="server" /><br />
                <asp:Button ID="Button3" runat="server" Text="Ekle" CssClass="myButton" 
                    onclick="Button3_Click" />
            </asp:Panel>
    </asp:Panel>
</asp:Content>

