<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarOC.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.Orden_Compra.IngresarOC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Insertar Orden de Compra"></asp:Label>
    <br />
    
 
    
    
    <br />
    Prductos
    <asp:DropDownList ID="dl_Productos" runat="server" OnSelectedIndexChanged="dl_Productos_SelectedIndexChanged">
    </asp:DropDownList>
    Cantidad Producto
    <asp:TextBox ID="txt_cant" runat="server"></asp:TextBox>
    <br />
    Ubicación
    <asp:TextBox ID="txt_ubicacion" runat="server"></asp:TextBox>

    <br />

    Precio
    <asp:TextBox ID="txt_precio" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnIng" runat="server" Text="Registrar"  OnClick="btnIng_click"/>
    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
    <br />


        <script>
            function agregar() {
                var dlProductos = getElementById("dl_Productos").value;
                var cantidad = getElementById("txt_cant").value;
                var precio = getElementById("txt_precio").value;
                var ubic = getElementById("txt_ubicacion").value;
                var precio = getElementById("txt_precio").value;

                var todo = dlProductos + ";" + cantidad + ";" + precio+ ";" + ubic+ ";" + ";" + precio;

                while (productos != null) {
                    var productos = [];

                }

               


            } 
    
        </script>
</asp:Content>
