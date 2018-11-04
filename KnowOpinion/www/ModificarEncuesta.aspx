<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarEncuesta.aspx.cs" Inherits="www.ModificarEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
            height: 166px;
        }
        .auto-style24 {
            width: 342px;
        }
        .auto-style25 {
            width: 317px;
        }
        .auto-style26 {
            width: 199px;
        }
        .auto-style27 {
            margin-left: 89px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25"><strong><h1 class="auto-style24">Modificar Encuesta</h1></strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26"><strong>Seleccionar Encuesta: </strong></td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="Seleccionar_ModificarEncuesta" runat="server" Height="22px" Width="329px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26"><strong>Modificación:</strong></td>
                    <td class="auto-style25">
                        <asp:TextBox ID="TextBox_Modificacion" runat="server" Width="330px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:Label ID="Lbl_ErrorModificar" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button_Aceptar" runat="server" CssClass="auto-style27" OnClick="Button_A_Click" Text="Aceptar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
