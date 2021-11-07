<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunSorgula.aspx.cs" Inherits="OOP_Stok.UrunSorgula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Button" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
    
</asp:Content>
