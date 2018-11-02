<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="www.PaginaWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 95%;
            height: 143px;
        }
        .auto-style2 {
            height: 59px;
        }
        .auto-style3 {
            margin-top: 0px;
        }
        .auto-style5 {
            height: 59px;
            width: 96px;
        }
        .auto-style6 {
            width: 309px;
        }
        .auto-style7 {
            height: 59px;
            width: 309px;
        }
        .auto-style8 {
            width: 309px;
            height: 40px;
        }
        .auto-style9 {
            width: 96px;
            height: 40px;
        }
        .auto-style10 {
            height: 40px;
        }
        .auto-style24 {
            width: 121px;
        }
        .auto-style25 {
            width: 96px;
        }
        .auto-style26 {
            margin-left: 139px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <strong><h1 id="Login" class="auto-style24">Login</h1></strong>
                </td>
                <td class="auto-style10">
                </td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Label ID="Lbl_usuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="Tbox_usuario" runat="server" Width="260px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style5">
                    <asp:Label ID="Lbl_contraseña" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="Tbx_contraseña" runat="server" CssClass="auto-style3" TextMode="Password" Width="257px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style25">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Btn_Login" runat="server" Text="Entrar" Width="127px" OnClick="Btn_Login_Click" CssClass="auto-style26" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style25">
                    <asp:Label ID="Label_ErrorLogin" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
