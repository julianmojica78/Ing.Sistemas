<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/LoginGames.aspx.cs" Inherits="View_LoginGames" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style27">
                <tr>
                    <td class="auto-style36" colspan="4">
                        <h1 class="auto-style31">
                            <asp:Label ID="LB_Login" runat="server" Text="Iniciar Sesion"></asp:Label>
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29"></td>
                    <td id="L_User" class="auto-style30" style="width: 30%"><strong>
                        <asp:Label ID="LB_username" runat="server" Text="Nombre de Usuario:"></asp:Label>
                        </strong></td>
                    <td class="auto-style29">
                        <div class="row form-group">
                            <div class="auto-style33">
                                <asp:TextBox ID="UserName" runat="server" class="form-control" Font-Size="0.8em" Width="520px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFV_User" runat="server" ControlToValidate="UserName" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="validator_username" runat="server" ControlToValidate="UserName" ErrorMessage="Ingrese solo letras Y Numeros" ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-ñÑ_ ]*$" ValidationGroup="Uno"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                    </td>
                    <td class="auto-style29"></td>
                </tr>
                <tr>
                    <td class="auto-style32"></td>
                    <td id="L_Clave" class="auto-style28" style="width: 30%"><strong>
                        <asp:Label ID="LB_pass" runat="server" Text="Contraseña:"></asp:Label>
                        </strong>:</td>
                    <td class="auto-style32">
                        <div class="row form-group">
                            <div class="auto-style34">
                                <asp:TextBox ID="Password" runat="server" class="form-control" Font-Size="0.8em" TextMode="Password" Width="520px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RFV_Clave" runat="server" ControlToValidate="Password" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </td>
                    <td class="auto-style32"></td>
                </tr>
                <tr>
                    <td class="auto-style32"></td>
                    <td class="auto-style35" colspan="2">&nbsp;</td>
                    <td class="auto-style32"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style31" colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style31" colspan="2">
                        <div class="auto-style1">
                            <asp:Button ID="B_Login" runat="server" class="btn btn-primary" OnClick="Button8_Click" Text="Inicio de Sesión" ValidationGroup="Uno" />
                            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                        </div>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style31" colspan="2">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
