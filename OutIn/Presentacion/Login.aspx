<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_Presentacion" runat="server" Text="OUTIN"></asp:Label>
            <br />
            <asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_contrasena" runat="server" Text="Contraseña"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_contrasena" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btn_Ingresar" runat="server" Text="Button" OnClick="btn_Ingresar_Click" />
            <br />
            <asp:Label ID="lbl_info" runat="server" Text="label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
