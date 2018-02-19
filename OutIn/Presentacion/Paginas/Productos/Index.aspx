<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Paginas.Productos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gr_Producto" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gr_Producto_SelectedIndexChanged" OnRowCommand="grProducto_RowCommand">
        <Columns>
            <asp:BoundField DataField="pd_IdProducto" HeaderText="Id" >
            <HeaderStyle CssClass="header" />
            </asp:BoundField>
            <asp:BoundField DataField="pd_Nombre" HeaderText="Nombre" >
            <HeaderStyle CssClass="header" />
            </asp:BoundField>
            <asp:BoundField DataField="pd_Cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="pd_Precio" HeaderText="Precio" />
            <asp:BoundField DataField="pd_Unidades" HeaderText="Existencias" />
            <asp:BoundField DataField="pd_StockMin" HeaderText="Stock Minimo" />
            <asp:BoundField DataField="pd_StockMax" HeaderText="Stock Maximo" />
            <asp:BoundField DataField="pd_CantidadXUnidad" HeaderText="Tamaño" />
            <asp:BoundField DataField="cat_Descripcion" HeaderText="Categoria" />
            <asp:ButtonField ButtonType="Button" HeaderText="Eliminar" Text="Eliminar" CommandName="Eliminar" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn_nuevoProducto" runat="server" Text="Ingresar Producto" OnClick="btn_nuevoProducto_Click" />
</asp:Content>
