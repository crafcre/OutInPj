<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ingresar_Proveedores.aspx.cs" Inherits="Presentacion.Paginas.Proveedores.Ingresar_Proveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Lbl" runat="server" Text="Registrar Proveedores"></asp:Label>
    <br />
        <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Telefono" runat="server" Text="Teléfono"></asp:Label>
    <asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Direccion" runat="server" Text="Dirección"></asp:Label>
       <asp:TextBox ID="txt_direccion" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Btn_Registrar" runat="server" Text="Registrar" OnClick="Btn_Registrar_Click" />
    <asp:Label ID="lbl_info" Text="Info" runat="server" />


</asp:Content>
