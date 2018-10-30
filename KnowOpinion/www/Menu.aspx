<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="www.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style24 {
            width: 274px;
        }
        .auto-style25 {
            width: 307px;
        }
        .auto-style26 {
            width: 272px;
        }
        .auto-style27 {
            width: 89%;
        }
        .auto-style22 {
            margin-left: 359px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style27">
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25"><strong><h1 class="auto-style24">Menú Principal</h1></strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:Button ID="Button_AltaEncuesta" runat="server" Height="54px" OnClick="Button1_Click" Text="Alta Encuesta" Width="213px" />
                    </td>
                    <td>
                        <asp:Button ID="Button_BorrarEncuesta" runat="server" Height="46px" OnClick="Button1_Click" Text="Borrar Encuesta" Width="203px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:Button ID="Button_ModificarEncuesta" runat="server" Height="63px" OnClick="Button1_Click" Text="Modificar Encuesta" Width="214px" />
                    </td>
                    <td>
                        <asp:Button ID="Button_ADEncuesta0" runat="server" Height="54px" OnClick="Button1_Click" Text="Activar/Desactivar Encuesta" Width="314px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td>
                    <asp:Button ID="Button_CerrarSesion" runat="server" CssClass="auto-style22" OnClick="Button1_Click" Text="Cerrar Sesión" Width="170px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
