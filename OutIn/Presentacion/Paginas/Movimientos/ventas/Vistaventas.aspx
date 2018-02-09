<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="Vistaventas.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.ventas.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvventa" runat="server" OnSelectedIndexChanged="grvventa_SelectedIndexChanged">
    </asp:GridView>
<asp:Label ID="lbl_Info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="RegistrarVenta" />
</asp:Content>
