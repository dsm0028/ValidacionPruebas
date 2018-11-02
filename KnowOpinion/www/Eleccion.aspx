<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eleccion.aspx.cs" Inherits="www.Eleccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
            width: 65px;
        }
        .auto-style2 {
            height: 26px;
            width: 187px;
        }
        .auto-style3 {
            width: 187px;
        }
        .auto-style7 {
            height: 26px;
            width: 199px;
        }
        .auto-style8 {
            width: 199px;
        }
        .auto-style9 {
            height: 26px;
            width: 190px;
        }
        .auto-style10 {
            width: 190px;
        }
        .auto-style12 {
            height: 26px;
            width: 203px;
        }
        .auto-style13 {
            width: 203px;
        }
        .auto-style14 {
            margin-left: 3px;
        }
        .auto-style15 {
            margin-left: 60px;
        }
        .auto-style16 {
            width: 65px;
        }
        .auto-style17 {
            width: 82%;
        }
        .auto-style18 {
            margin-left: 85px;
        }
        .auto-style19 {
            margin-left: 35px;
        }
        .auto-style22 {
            margin-left: 135px;
        }
        .auto-style24 {
            width: 380px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style17">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"><strong><h1 class="auto-style24">Formulario Encuestas</h1></strong></td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9"></td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Elegir encuesta:</strong></td>
                <td class="auto-style3">
                    <asp:DropDownList ID="SeleccionarEncuesta" runat="server" Width="378px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style7"></td>
                <td class="auto-style9"></td>
                <td class="auto-style12"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style7"></td>
                <td class="auto-style9"></td>
                <td class="auto-style12"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Valoración:</strong></td>
                <td class="auto-style3">
                    <asp:Label ID="Lbl_valoracion" runat="server" Text="Escoja una cara."></asp:Label>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:ImageButton ID="ImageButton_Enfadado" runat="server" CssClass="auto-style14" Height="189px" ImageUrl="./Emojis/enfadado.png" Width="253px" OnClick="ImageButton_Enfadado_Click" />
                </td>
                <td class="auto-style3">
                    <asp:ImageButton ID="ImageButton_Triste" runat="server" CssClass="auto-style18" Height="159px" ImageUrl="./Emojis/triste.jpg" Width="162px" OnClick="ImageButton_Triste_Click" />
                </td>
                <td class="auto-style8">
                    <asp:ImageButton ID="ImageButton_Contento" runat="server" CssClass="auto-style19" Height="182px" ImageUrl="./Emojis/contento.jpg" Width="187px" OnClick="ImageButton_Contento_Click" />
                </td>
                <td class="auto-style10">
                    <asp:ImageButton ID="ImageButton_Enamorado" runat="server" CssClass="auto-style15" Height="179px" ImageUrl="./Emojis/enamorado.jpg" Width="171px" OnClick="ImageButton_Enamorado_Click" />
                </td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td><strong>Descripción:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="178px" Width="383px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button_Enviar_Click" Text="Enviar" />
                </td>
                <td>
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Lbl_ok" runat="server" Text="Enviado correctamente." Visible="False"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Button_IniciarSesion" runat="server" CssClass="auto-style22" OnClick="Button1_Click" Text="Iniciar Sesión" Width="170px" />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
