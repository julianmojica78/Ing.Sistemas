<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/ModificarEmpleado.aspx.cs" Inherits="View_ModificarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style27">
        <tr>
            <td class="auto-style13" colspan="6">
                <h1 class="text-center">
                    <asp:Label ID="LB_modiemp" runat="server" Text="Modificar Empleado"></asp:Label>
                </h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%; height: 25px;"></td>
            <td style="width; height: 25px;" class="text-right"></td>
            <td class="auto-style30" style="height: 25px">
                &nbsp;</td>
            <td class="auto-style35" style="height: 25px"></td>
            <td class="auto-style39" style="height: 25px">
                </td>
            <td style="width: 5%; height: 25px;"></td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td style="width" class="text-right">
                <asp:Label ID="LB_nombre" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_Nombre" class="form-control" runat="server" Width="160px" MaxLength="20" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                
                 <asp:RegularExpressionValidator ID="REV_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="Solo Puede Ingresar Letras" ForeColor="Red" ValidationExpression="^[A-Za-z]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
                
            </td>
            <td class="auto-style35">&nbsp;
                <asp:Label ID="LB_apellido" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style39">
                <asp:TextBox ID="TB_Apellido" runat="server" Width="161px" MaxLength="20" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Apellido" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Apellido" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="Solo Puede Ingresar Letras" ForeColor="Red" ValidationExpression="^[A-Za-z]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style40" style="width: 5%"></td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_usuario" runat="server" Text="Usuario:"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_Usuario" runat="server" Width="160px" MaxLength="20" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Usuario" runat="server" ControlToValidate="TB_Usuario" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style35">
                <asp:Label ID="LB_email" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="auto-style39">
                <asp:TextBox ID="TB_Email" runat="server" Width="160px" TextMode="Email" MaxLength="20" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Email" runat="server" ControlToValidate="TB_Email" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 5%" class="auto-style38"></td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_contra" runat="server" Text="Contraseña:"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_Contrasena" runat="server" Width="160px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Contrasena" runat="server" ControlToValidate="TB_Contrasena" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_cedula" runat="server" Text="Cedula:"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:TextBox ID="TB_Cedula" runat="server" Width="160px" MaxLength="10" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Cedula" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre1" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="Solo Puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^[0-9]*" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_concon" runat="server" Text="Confirmar Contraseña:"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_CConrasena" runat="server" Width="160px" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:CompareValidator ID="CV_CContrasena" runat="server" ControlToCompare="TB_Contrasena" ControlToValidate="TB_CConrasena" ErrorMessage="La Contraseña no es identica " ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:CompareValidator>
            </td>
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_celu" runat="server" Text="Celular"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:TextBox ID="TB_Celular" runat="server" Width="160px" Height="24px" TextMode="Phone" MaxLength="10" class="form-control" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Celular" runat="server" ControlToValidate="TB_Celular" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre2" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="Solo Puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^[0-9]*" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41"></td>
            <td class="text-right"><asp:Label ID="LB_rol" runat="server" Text="Rol"></asp:Label>
            </td>
            <td class="auto-style44">
                <asp:DropDownList ID="DDL_Rol" runat="server" Height="34px" Width="221px" class="form-control" ValidationGroup="uno">
                    <asp:ListItem Value="1">----SELECCIONE OPCION----</asp:ListItem>
                    <asp:ListItem Value="2">Cocinero</asp:ListItem>
                    <asp:ListItem Value="3">Mesero</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style32">
                <asp:RangeValidator ID="RV_Rol" runat="server" ControlToValidate="DDL_Rol" ErrorMessage="Seleccione una Opcion" MaximumValue="3" MinimumValue="2" SetFocusOnError="True" ForeColor="Red" ValidationGroup="uno"></asp:RangeValidator>
                </td>
            <td class="auto-style45">
                </td>
            <td class="auto-style41"></td>
        </tr>
        <tr>
            <td class="auto-style41"></td>
            <td class="auto-style42" colspan="4">&nbsp;</td>
            <td class="auto-style41"></td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 5%; height: 26px;"></td>
            <td class="text-center" colspan="4" style="height: 26px">
                <asp:Button ID="B_Modificar" runat="server" OnClick="B_Crear_Click" Text="Modificar" class="btn btn-primary" style="height: 36px" ValidationGroup="uno"/>
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

