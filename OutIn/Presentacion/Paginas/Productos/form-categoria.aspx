<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="form-categoria.aspx.cs" Inherits="Presentacion.Paginas.Productos.form_categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_presentacion" runat="server" Text="Ingresar Categoria"></asp:Label>
    <br />
    <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn_ok" runat="server" Text="Guardar" OnClick="btn_ok_Click" />
</asp:Content>
