<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="VistaMov.aspx.cs" Inherits="Presentacion.Paginas.Movimientos.VistaMov" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grv_Movimientos" runat="server" OnRowCommand="grv_Movimientos_RowCommand">
    </asp:GridView>
    <asp:Label ID="lbl_Info" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn_OC" runat="server" Text="Orden Compra" OnClick="btn_OC_Click" />
</asp:Content>
