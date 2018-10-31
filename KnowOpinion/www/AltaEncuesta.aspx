<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaEncuesta.aspx.cs" Inherits="www.AltaEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 55%;
        }
        .auto-style24 {
            width: 295px;
        }
        .auto-style25 {
            width: 247px;
        }
        .auto-style26 {
            width: 225px;
        }
        .auto-style27 {
            margin-left: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25"><strong><h1 class="auto-style24">Alta de Encuesta</h1></strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26"><strong>Nombre encuesta:</strong></td>
                    <td class="auto-style25">
                    <asp:TextBox ID="Tbox_NombreEncuesta" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26"><strong>Descripción:</strong></td>
                    <td class="auto-style25">
                    <asp:TextBox ID="Tbox_Descripcion" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button_Aceptar" runat="server" CssClass="auto-style27" OnClick="Button_Aceptar_Click" Text="Aceptar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
