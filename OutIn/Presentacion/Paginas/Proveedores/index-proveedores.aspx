<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="index-proveedores.aspx.cs" Inherits="Presentacion.Paginas.Proveedores.index_proveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_proveedores" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnRowCommand="gv_proveedores_RowCommand" OnSelectedIndexChanged="gv_proveedores_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="pv_IdProveedor" HeaderText="Id" />
            <asp:BoundField DataField="pv_Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="pv_Contacto" HeaderText="Contacto" />
            <asp:BoundField DataField="pv_Direccion" HeaderText="Dirección" />
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn_nuevo_proveedor" runat="server" Text="Nuevo Proveedor" OnClick="btn_nuevo_proveedor_Click" />
</asp:Content>
