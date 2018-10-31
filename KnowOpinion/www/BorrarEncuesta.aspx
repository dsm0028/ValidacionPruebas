<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrarEncuesta.aspx.cs" Inherits="www.BorrarEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style24 {
            width: 295px;
        }
        .auto-style25 {
            width: 259px;
        }
        .auto-style26 {
            width: 450px;
        }
        .auto-style27 {
            width: 46%;
        }
        .auto-style29 {
            width: 291px;
            height: 55px;
        }
        .auto-style30 {
            width: 259px;
            height: 55px;
        }
        .auto-style31 {
            width: 450px;
            height: 55px;
        }
        .auto-style32 {
            width: 291px;
            height: 26px;
        }
        .auto-style33 {
            width: 259px;
            height: 26px;
        }
        .auto-style34 {
            width: 450px;
            height: 26px;
        }
        .auto-style35 {
            width: 291px;
        }
        .auto-style36 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style27">
                <tr>
                    <td class="auto-style29"></td>
                    <td class="auto-style30"><strong><h1 class="auto-style24">Borrar Encuesta</h1></strong></td>
                    <td class="auto-style31"></td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:CheckBox ID="CheckBox_E1" runat="server" OnCheckedChanged="CheckBox_E1_CheckedChanged" Text=" Encuesta 1" />
                    </td>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style26">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style32">
                        <asp:CheckBox ID="CheckBox_E2" runat="server" OnCheckedChanged="CheckBox_E1_CheckedChanged" Text=" Encuesta 2" />
                    </td>
                    <td class="auto-style33"></td>
                    <td class="auto-style34"></td>
                </tr>
                <tr>
                    <td class="auto-style32">
                        <asp:CheckBox ID="CheckBox_E3" runat="server" OnCheckedChanged="CheckBox_E1_CheckedChanged" Text=" Encuesta 3" />
                    </td>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style32">&nbsp;</td>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style34">
                        <asp:Button ID="Button_Aceptar" runat="server" CssClass="auto-style36" OnClick="Button_Aceptar_Click" Text="Aceptar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
