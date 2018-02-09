<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarVenta.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.ventas.IngresarVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre o Codigo&nbsp;
    <asp:TextBox ID="txtnomproducto" runat="server" OnTextChanged="txtnomproducto_TextChanged" Width="187px"></asp:TextBox>
    <asp:Button ID="btningresar" runat="server" OnClick="btningresar_Click" Text="OK" />
    <asp:GridView ID="grvproventa" runat="server" OnSelectedIndexChanged="grvproventa_SelectedIndexChanged">
    </asp:GridView>
    <asp:Label ID="lblrta" runat="server"></asp:Label>
</asp:Content>
