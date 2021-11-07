<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satis.aspx.cs" Inherits="OOP_Stok.Satis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Satış ID</th>
            <th>Ürün ADI</th>
            <th>Personel</th>
            <th>Müşteri</th>
            <th>Tutar</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Satisid") %></td>
                        <td><%# Eval("Urunad") %></td>
                        <td><%# Eval("Personelad") %></td>
                        <td><%# Eval("Musteriad") %></td>
                        <td><%# Eval("Fiyat") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
     <a href="SatisEkle.aspx" class="btn btn-info">YENİ SATIŞ EKLE</a>
</asp:Content>
