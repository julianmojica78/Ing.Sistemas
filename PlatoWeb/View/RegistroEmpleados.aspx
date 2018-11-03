<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/RegistroEmpleados.aspx.cs" Inherits="View_RegistroEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style27">
        <tr>
            <td class="auto-style13" colspan="6">
                <h1 class="text-center">
                    <asp:Label ID="LB_regisemp" runat="server" Text="Registro de Empleados"></asp:Label>
                </h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td style="width">
                <asp:Label ID="LB_nombre" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_Nombre" runat="server" Width="160px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                
                 <asp:RegularExpressionValidator ID="REV_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="Solo Puede Ingresar Letras" ForeColor="Red" ValidationExpression="^[A-Za-z]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
                
            </td>
            <td class="auto-style35">
                <asp:Label ID="LB_apellido" runat="server" Text="Apellido"></asp:Label>
                :</td>
            <td class="auto-style39">
                <asp:TextBox ID="TB_Apellido" runat="server" Width="161px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Apellido" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre0" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="Solo Puede Ingresar Letras" ForeColor="Red" ValidationExpression="^[A-Za-z]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style40" style="width: 5%"></td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_user" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_Usuario" runat="server" Width="160px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Usuario" runat="server" ControlToValidate="TB_Usuario" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="validator_username" 
                    runat="server" ControlToValidate="TB_Usuario" 
                    ErrorMessage="Ingrese solo letras Y Numeros" 
                    ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-ñÑ]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style35">
                <asp:Label ID="LB_email" runat="server" Text="Email"></asp:Label>
                :</td>
            <td class="auto-style39">
                <asp:TextBox ID="TB_Email" runat="server" Width="160px" TextMode="Email" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Email" runat="server" ControlToValidate="TB_Email" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 5%" class="auto-style38"></td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_pas" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_Contrasena" runat="server" Width="160px" TextMode="Password" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Contrasena" runat="server" ControlToValidate="TB_Contrasena" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_cedula" runat="server" Text="Cedula"></asp:Label>
                :</td>
            <td class="auto-style33">
                <asp:TextBox ID="TB_Cedula" runat="server" Width="160px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Cedula" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre1" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="Solo Puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^[0-9]*" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_rpas" runat="server" Text="Confirmar Contraseña"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_CConrasena" runat="server" Width="160px" TextMode="Password" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:CompareValidator ID="CV_CContrasena" runat="server" ControlToCompare="TB_Contrasena" ControlToValidate="TB_CConrasena" ErrorMessage="La Contraseña no es identica " ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:CompareValidator>
            </td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_celu" runat="server" Text="Celular"></asp:Label>
                :</td>
            <td class="auto-style33">
                <asp:TextBox ID="TB_Celular" runat="server" Width="160px" Height="24px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Celular" runat="server" ControlToValidate="TB_Celular" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre2" runat="server" ControlToValidate="TB_Celular" ErrorMessage="Solo Puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^[0-9]*" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41"></td>
            <td class="text-right">
                <asp:Label ID="LB_rol" runat="server" Text="Rol"></asp:Label>
                :</td>
            <td class="auto-style44">
                <asp:DropDownList ID="DDL_Rol" runat="server" Height="26px" Width="213px" class="form-control" ValidationGroup="uno">
                    <asp:ListItem>----SELECCIONE OPCION----</asp:ListItem>
                    <asp:ListItem Value="2">Cocinero</asp:ListItem>
                    <asp:ListItem Value="3">Mesero</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style32">
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="DDL_Rol" ErrorMessage="*" ForeColor="Red" MaximumValue="3" MinimumValue="2" SetFocusOnError="True" ValidationGroup="uno"></asp:RangeValidator>
                </td>
            <td class="auto-style45">
                </td>
            <td class="auto-style41"></td>
        </tr>
        <tr>
            <td class="auto-style41"></td>
            <td class="auto-style42" colspan="4"></td>
            <td class="auto-style41"></td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%; height: 26px;"></td>
            <td class="text-center" colspan="4" style="height: 26px">
                <asp:Button ID="B_Crear" runat="server" OnClick="B_Crear_Click" Text="Crear" class="btn btn-primary" ValidationGroup="uno" />
            </td>
            <td style="width: 5%; height: 26px;"></td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style28" colspan="4">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style13" colspan="4">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

