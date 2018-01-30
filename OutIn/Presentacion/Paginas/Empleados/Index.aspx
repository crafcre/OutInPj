<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Paginas.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_Empleados" runat="server" OnSelectedIndexChanged="gv_Empleados_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowCommand="Gv_Empleados_RowCommand">
        <Columns>
            <asp:BoundField DataField="Identificacion" HeaderText="ID" />
            <asp:BoundField DataField="Fecha_Nacimiento" HeaderText="Fecha Nacimiento" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Tipo_Documento" HeaderText="Tipo Documento" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
            <asp:BoundField DataField="Telefono_de_Contacto" HeaderText="Telefono de Contacto" />
            <asp:ButtonField ButtonType="Button" CommandName="Eliminar" HeaderText="Accion Eliminar" Text="Eliminar" />
            <asp:ButtonField ButtonType="Button" CommandName="Editar" HeaderText="Editar" Text="Editar" />
            <asp:BoundField DataField="contrasena" HeaderText="Contraseña" Visible="False" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn_regEmpleado" runat="server" OnClick="Button1_Click" Text="Empleado Nuevo" />
</asp:Content>
