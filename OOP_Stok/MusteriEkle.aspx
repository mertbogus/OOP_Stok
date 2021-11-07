<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="OOP_Stok.MusteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" class="form-group">
        <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Müşteri Adı" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <br />
          <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Müşteri Soyadı"></asp:TextBox>
        </div>
         <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Müşteri Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
