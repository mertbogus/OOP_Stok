<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="OOP_Stok.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Urun ID</th>
            <th>Ürün ADI</th>
            <th>Ürün Fiyatı</th>
            <th>Ürün Adetiş</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Urunid") %></td>
                        <td><%# Eval("Urunad") %></td>
                        <td><%# Eval("Urunfiyat") %></td>
                        <td><%# Eval("Urunadet") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="MusteriEkle.aspx" class="btn btn-info">YENİ ÜRÜN EKLE</a>
</asp:Content>
