﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DepartmanEkle.aspx.cs" Inherits="OOP_Stok.DepartmanEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
           <%-- <asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Departman Adı Giriniz." OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Departmanı Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
