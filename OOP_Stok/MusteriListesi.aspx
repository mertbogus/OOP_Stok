<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriListesi.aspx.cs" Inherits="OOP_Stok.MusteriListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Müşteri ID</th>
            <th>Müşteri ADI</th>
            <th>Müşteri SOYADI</th>
            <th>Sil</th>
            <th>Güncelle</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("musteriıd") %></td>
                        <td><%# Eval("Musteriad") %></td>
                        <td><%# Eval("Musterisoyad") %></td>
                        <td><asp:HyperLink NavigateUrl='<%#"~/MusteriSil.aspx?musteriıd"+Eval("musteriıd") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                        <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
     <a href="MusteriEkle.aspx" class="btn btn-info">YENİ MÜŞTERİ EKLE</a>
</asp:Content>
