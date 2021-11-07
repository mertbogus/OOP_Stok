<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="OOP_Stok.Personel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Personel ID</th>
            <th>Personel ADI</th>
            <th>Departman</th>
            <th>Maaş</th>
            <th>Personel Fotoğrafı</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Personelid") %></td>
                        <td><%# Eval("Personelad") %></td>
                        <td><%# Eval("Personeldepartman") %></td>
                        <td><%# Eval("Personelmaas") %></td>
                        <td><%# Eval("Fotograf") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
     <a href="PersonelEkle.aspx" class="btn btn-info">YENİ PERSONEL EKLE</a>
</asp:Content>
