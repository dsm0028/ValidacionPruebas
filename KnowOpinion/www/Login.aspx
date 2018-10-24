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
        .auto-style4 {
            width: 414px;
        }
        .auto-style5 {
            height: 59px;
            width: 414px;
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
            width: 414px;
            height: 40px;
        }
        .auto-style10 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Label ID="Lbl_usuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="Tbox_usuario" runat="server" Width="171px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style5">
                    <asp:Label ID="Lbl_contraseña" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="Tbx_contraseña" runat="server" CssClass="auto-style3" TextMode="Password" Width="171px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Btn_Login" runat="server" Text="Iniciar sesión" Width="98px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
