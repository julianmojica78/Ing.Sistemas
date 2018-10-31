<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Loggin.aspx.cs" Inherits="View_Loggin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }

        .auto-style29 {
            height: 26px;
        }

        .auto-style30 {
            text-align: right;
            height: 26px;
        }

        .auto-style28 {
            text-align: right;
            height: 27px;
        }

        .auto-style31 {
            text-align: center;
        }

        .auto-style32 {
            height: 27px;
        }
        .auto-style33 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 2px;
            top: 23px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style34 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 1px;
            top: 22px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style35 {
            height: 27px;
            text-align: center;
        }
        .auto-style36 {
            height: 59px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <ajaxToolkit:NoBot ID="NoBot1" runat="server" ResponseMinimumDelaySeconds="3" CutoffWindowSeconds="10" CutoffMaximumInstances="3"  />
                   <%-- Cantidad minina de segundos en la devolucion de datos // intervalo de tiempo en el que son medidas la devolucion de datos desde una ip// Maximos segundos por intervalo de tiempo --%>

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
                        <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em" class="form-control" Width="520px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RFV_User" runat="server" ControlToValidate="UserName" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validator_username" 
                    runat="server" ControlToValidate="UserName" 
                    ErrorMessage="Ingrese solo letras Y Numeros" 
                    ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-ñÑ]*$" ValidationGroup="Uno"></asp:RegularExpressionValidator>
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
                <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" class="form-control" Width="520px" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Clave" runat="server" ControlToValidate="Password" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Uno"></asp:RequiredFieldValidator>
            </div>
                                </div>
                   </td>
            <td class="auto-style32"></td>
        </tr>
        <tr>
            <td class="auto-style32"></td>
            <td class="auto-style35" colspan="2">
                &nbsp;</td>
            <td class="auto-style32"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style31" colspan="2">
                <asp:LinkButton ID="LB_Recuperar" runat="server" OnClick="LB_Recuperar_Click">Recuperar Contraseña</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style31" colspan="2">
                 <div class="form-group">
                <asp:Button ID="B_Login" runat="server" OnClick="Button8_Click" Text="Inicio de Sesión" ValidationGroup="Uno" class="btn btn-primary" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="B_Registrarse" runat="server" OnClick="B_Registrarse_Click" Text="Registrarse" class="btn btn-primary" ValidationGroup="dos" />
                &nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ImageButton1" runat="server"  Text="Ingresar con Gmail" class="btn btn-primary" ValidationGroup="tres" OnClick="B_Ingresar_Gmail_Click" />
                &nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="B_Facebook" runat="server"  Text="Ingresar con FaceBook" class="btn btn-primary" ValidationGroup="cuatro" OnClick="B_Facebook_Click" />
                &nbsp;&nbsp;&nbsp;
                </div>

                     </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>