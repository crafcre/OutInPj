<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="VistaOC.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.Orden_Compra.VistaOC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grv_OrdenCompra" runat="server" OnSelectedIndexChanged="grv_OrdenCompra_SelectedIndexChanged">
</asp:GridView>
    <asp:Label ID="lbl_Info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn_ingresar" runat="server" Text="Registrar orden de compra" OnClick="btn_ingresar_click" />
</asp:Content>
