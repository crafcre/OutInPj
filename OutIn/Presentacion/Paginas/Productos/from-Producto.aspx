<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="from-Producto.aspx.cs" Inherits="Presentacion.Paginas.Productos.from_Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_presentacion" runat="server" Text="Nuevo Producto"></asp:Label>
    <br />
    <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Cantidad" runat="server" Text="Cantidad: "></asp:Label>
    <asp:TextBox ID="txt_Cant" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Precio" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="txt_Precio" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Unidades" runat="server" Text="Unidades: "></asp:Label>
    <asp:TextBox ID="txt_Unidades" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_sMin" runat="server" Text="Stock Minimo"></asp:Label>
    <asp:TextBox ID="txt_sMin" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_sMax" runat="server" Text="Stock Maximo"></asp:Label>
    <asp:TextBox ID="txt_sMax" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_canXUnidad" runat="server" Text="Peso: "></asp:Label>
    <asp:TextBox ID="txt_canXunidad" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_cat" runat="server" Text="Categoria"></asp:Label>
    <asp:DropDownList ID="drl_Categoria" runat="server" OnSelectedIndexChanged="drl_Categoria_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <asp:Button ID="btn_Registrar" runat="server" Text="Guardar" OnClick="btn_Registrar_Click" />
    <asp:Label ID="lbl_Info" runat="server" Text="Label"></asp:Label>
</asp:Content>
