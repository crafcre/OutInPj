<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Paginas.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_Empleados" runat="server" OnSelectedIndexChanged="gv_Empleados_SelectedIndexChanged">
            </asp:GridView>
        <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
</asp:Content>
