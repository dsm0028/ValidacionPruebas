<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElegirEncuestas.aspx.cs" Inherits="www.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 317px;
        }
        .auto-style2 {
            width: 442px;
        }
        .auto-style3 {
            width: 241px;
        }
        .auto-style4 {
            width: 317px;
            height: 8px;
        }
        .auto-style5 {
            width: 241px;
            height: 8px;
        }
        .auto-style6 {
            height: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="Lbl_usuario" runat="server" Text="Bienvenido, "></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Btn_Logoff" runat="server" Text="Cerrar sesión" />
                        <asp:Button ID="Btn_Manage" runat="server" Text="Administrar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Elija una encuesta:</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="Desp_encuestas" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Btn_Start" runat="server" Text="Empezar" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
