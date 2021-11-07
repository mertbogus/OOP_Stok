<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOP_Stok.PersonelEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel Adı"></asp:TextBox>
        </div>
        <br />
          <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel Soyadı"></asp:TextBox>
        </div>
        <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel Maaşı"></asp:TextBox>
        </div>
        <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Müşteri Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click"/>
        </div>
    </form>
</asp:Content>
