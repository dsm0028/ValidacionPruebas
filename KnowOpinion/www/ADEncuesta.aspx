<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADEncuesta.aspx.cs" Inherits="www.ADEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 68%;
            margin-top: 15px;
        }
        .auto-style24 {
            width: 497px;
            margin-left: 0px;
        }
        .auto-style25 {
            width: 310px;
        }
        .auto-style26 {
            width: 188px;
        }
        .auto-style27 {
            margin-left: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25"><strong><h1 class="auto-style24">Activar/Desactivar Encuesta</h1></strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26"><strong>Seleccionar Encuesta:</strong></td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="DropDownList_SelecEncu" runat="server" Height="25px" Width="399px">
                        </asp:DropDownList>
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
                    <td class="auto-style25">
                        <asp:CheckBox ID="CheckBox_Activar" runat="server" Text=" Activar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:CheckBox ID="CheckBox_Desactivar" runat="server" Text=" Desactivar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:Label ID="Lbl_err" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style25">
                        <asp:Button ID="Button_Aceptar" runat="server" CssClass="auto-style27" OnClick="Button_Aceptar_Click" Text="Aceptar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
