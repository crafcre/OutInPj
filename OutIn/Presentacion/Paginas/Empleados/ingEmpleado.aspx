<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="ingEmpleado.aspx.cs" Inherits="Presentacion.Paginas.Empleados.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_Registrar" runat="server" Text="Registrar Empleado"></asp:Label>
    <br />
    <asp:Label ID="lbl_Id" runat="server" Text="Identificacion: "></asp:Label>
    <asp:TextBox ID="txt_Id" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Nacimiento" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
    <asp:Calendar ID="fec_Nacimiento" runat="server"></asp:Calendar>
    <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_contrasena" runat="server" Text="Contraseña: "></asp:Label>
    <asp:TextBox ID="txt_contrasena" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_TipoId" runat="server" Text="Tipo de Identificacion"></asp:Label>
    <asp:DropDownList ID="dr_TipoId" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="lbl_Direccion" runat="server" Text="Direccion: "></asp:Label>
    <asp:TextBox ID="txt_Direccion" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Cargo" runat="server" Text="Cargo: "></asp:Label>
    <asp:DropDownList ID="dr_Cargo" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="lbl_Telefono" runat="server" Text="Telefono de Contacto: "></asp:Label>
    <asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btn_Registrar" runat="server" Text="Registrar" OnClick="btn_Registrar_Click" />







    <br />
    <asp:Label ID="lbl_info" runat="server" Text="Label" Visible="false"></asp:Label>







</asp:Content>
