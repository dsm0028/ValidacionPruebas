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
        .auto-style27 {
            width: 53%;
        }
        .auto-style29 {
            margin-left: 0px;
        }
        .auto-style30 {
            width: 400px;
        }
        .auto-style31 {
            width: 322px;
        }
        .auto-style32 {
            margin-left: 71px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style27">
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style25"><strong><h1 class="auto-style24">Menú Principal</h1></strong></td>
                    <td>
                        <asp:Label ID="Lbl_usuario" runat="server" Text="Bienvenido usuario: "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:Button ID="Button_AltaEncuesta" runat="server" Height="54px" OnClick="Button1_Click" Text="Alta Encuesta" Width="213px" CssClass="auto-style29" />
                    </td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style30">
                        <asp:Button ID="Button_BorrarEncuesta" runat="server" Height="52px" OnClick="Button_BorrarEncuesta_Click" Text="Borrar Encuesta" Width="228px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style30">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:Button ID="Button_ModificarEncuesta" runat="server" Height="51px" OnClick="Button_ModificarEncuesta_Click" Text="Modificar Encuesta" Width="212px" />
                    </td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style30">
                        <asp:Button ID="Button_ADEncuesta" runat="server" Height="50px" OnClick="Button_ADEncuesta_Click" Text="Activar/Desactivar Encuesta" Width="228px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style30">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:Button ID="Button_CerrarSesion" runat="server" CssClass="auto-style32" OnClick="Button_CerrarSesion_Click" Text="Cerrar Sesion" />
                    </td>
                    <td class="auto-style30">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
