<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dano_Devolucion.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.Dano_Devolucion.Dano_Devolucion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #TextArea1 {
            height: 92px;
            width: 230px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="producto"></asp:Label>
    <asp:DropDownList ID="Ddl_productos" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
    <asp:TextBox ID="txt_descripcion" runat="server" Height="107px" Width="247px"></asp:TextBox>
    <br />
    Cantidad
    <asp:TextBox ID="txt_cantidad" runat="server"></asp:TextBox>
    <br />
    ubicación<asp:TextBox ID="txt_ubicacion" runat="server" ></asp:TextBox>
    <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
</asp:Content>
