<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="index-cat.aspx.cs" Inherits="Presentacion.Paginas.Productos.index_cat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gr_cat" runat="server" AutoGenerateColumns="False" OnRowCommand="gr_cat_RowCommand" OnSelectedIndexChanged="gr_cat_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="cat_Id" HeaderText="Id" />
            <asp:BoundField DataField="cat_Descripcion" HeaderText="Nombre" />
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>

    <asp:Button ID="btn_catNueva" runat="server" Text="Categoria Nueva" OnClick="btn_catNueva_Click" />

</asp:Content>
