<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarOC.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.Orden_Compra.IngresarOC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Insertar Orden de Compra"></asp:Label>
    <br />
    Prductos
    <asp:DropDownList ID="dl_Productos" runat="server" OnSelectedIndexChanged="dl_Productos_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    Cantidad Producto
    <asp:TextBox ID="txt_cant" runat="server"></asp:TextBox>
    <br />
    Ubicación
    <asp:TextBox ID="txt_ubicacion" runat="server"></asp:TextBox>

    Precio
    <asp:TextBox ID="txt_precio" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnIng" runat="server" Text="Registrar"  OnClick="btnIng_click"/>
    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
    <br />
</asp:Content>
