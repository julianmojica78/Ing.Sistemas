<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Registro.aspx.cs" Inherits="View_Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }
        .auto-style28 {
            text-align: right;
        }
        .auto-style29 {
        width: 4%;
    }
        .auto-style30 {
            width: 439px;
        }
        .auto-style32 {
        width: 353px;
            height: 23px;
        }
    .auto-style33 {
        width: 530px;
    }
    .auto-style35 {
        text-align: right;
        width: ;
        height: 45px;
    }
    .auto-style38 {
        width: 5%;
        height: 45px;
    }
    .auto-style39 {
        width: 530px;
        height: 45px;
    }
    .auto-style40 {
        width: 4%;
        height: 45px;
    }
    .auto-style41 {
        width: 5%;
        height: 23px;
    }
    .auto-style42 {
        text-align: right;
        height: 23px;
    }
        .auto-style43 {
            width: 117px;
            height: 23px;
        }
        .auto-style45 {
            width: 530px;
            height: 23px;
        }
        .auto-style46 {
            text-align: center;
        }
        .auto-style47 {
            width: 439px;
            height: 23px;
        }
        .auto-style48 {
            width: 117px;
        }
        .auto-style49 {
            text-align: right;
            width: 117px;
        }
        .auto-style50 {
            width: 117px;
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     
    <table class="auto-style27">
        <tr>
            <td class="auto-style13" colspan="6">
                <h1 class="auto-style46">
                    <asp:Label ID="LB_regis" runat="server" Text="Registro de Usuario"></asp:Label>
                </h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 1%" rowspan="3">&nbsp;</td>
           <div class="row form-group">
             <td class="auto-style48">&nbsp;</td>
            <td class="auto-style30" rowspan="2">
               
                 <asp:TextBox ID="TB_Nombre" runat="server" class="form-control"  MaxLength="20"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                
                 <asp:RegularExpressionValidator ID="REV_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="Solo Puede Ingresar Letras" ForeColor="Red" ValidationExpression="^[A-Za-z]*$"></asp:RegularExpressionValidator>
                
            </td>
        </div>
         <div class="row form-group">
            <td class="auto-style35" rowspan="3">
                <asp:Label ID="LB_apellido" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td class="auto-style39" rowspan="3">
                <asp:TextBox ID="TB_Apellido" runat="server" class="form-control" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Apellido" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre0" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="Solo Puede Ingresar Letras" ForeColor="Red" ValidationExpression="^[A-Za-z]*$"></asp:RegularExpressionValidator>
            </td>
        </div>
            <td style="width: 5%" rowspan="3">&nbsp;</td>
        </tr>
        <tr>
             <td class="auto-style50">
                 <asp:Label ID="LB_nombre" runat="server" Text="Nombre"></asp:Label>
             </td>
        </tr>
        <tr>
             <td class="auto-style48">&nbsp;</td>
            <td class="auto-style30">
               
                 &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style40" style="width: 1%" rowspan="3"></td>
         <div class="row form-group">
            <td class="auto-style49">
                <asp:Label ID="LB_user" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td class="auto-style30" rowspan="3">
                <asp:TextBox ID="TB_Usuario" runat="server" class="form-control" MaxLength="20"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Usuario" runat="server" ControlToValidate="TB_Usuario" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="validator_username" 
                    runat="server" ControlToValidate="TB_Usuario" 
                    ErrorMessage="Ingrese solo letras Y Numeros" 
                    ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-ñÑ]*$"></asp:RegularExpressionValidator>
                </td>
        </div>
         <div class="row form-group">
            <td class="auto-style35" rowspan="3">
                <asp:Label ID="LB_email" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style39" rowspan="3">
                <asp:TextBox ID="TB_Email" runat="server" class="form-control" TextMode="Email" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Email" runat="server" ControlToValidate="TB_Email" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </div>
            <td style="width: 5%" class="auto-style38" rowspan="3"></td>
        </tr>
        <tr>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 1%">&nbsp;</td>
         <div class="row form-group">
            <td class="auto-style49">
                
                <asp:Label ID="LB_pass" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:TextBox ID="TB_Contrasena" runat="server" class="form-control" TextMode="Password" ></asp:TextBox>
                <ajaxToolkit:PasswordStrength StrengthIndicatorType="Text"
                    ID="PasswordStrength1"  
                    runat="server" 
                    BehaviorID="PasswordStrength1" 
                    MinimumLowerCaseCharacters="2" 
                    MinimumNumericCharacters="2" 
                    MinimumSymbolCharacters="2" 
                    MinimumUpperCaseCharacters="2" 
                    PreferredPasswordLength="10" 
                    HelpStatusLabelID="LB_status2" 
                    TextStrengthDescriptions="muy debil; debil; media; fuerte; irrompible" 
                    TargetControlID="TB_Contrasena" 
                    DisplayPosition="BelowLeft" 
                    PrefixText="Seguridad:" 
                    RequiresUpperAndLowerCaseCharacters="True" />
                   <asp:RequiredFieldValidator ID="RFV_Contrasena" runat="server" ControlToValidate="TB_Contrasena" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
             <asp:Label ID="LB_status2" runat="server"></asp:Label>
            </td>
        </div>
     <div class="row form-group">
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_cedula" runat="server" Text="Cedula"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:TextBox ID="TB_Cedula" runat="server" class="form-control"  MaxLength="10" Height="46px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Cedula" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre1" runat="server" ControlToValidate="TB_Cedula" ErrorMessage="Solo Puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            </td>
    </div>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29" style="width: 1%">&nbsp;</td>
     <div class="row form-group">
            <td class="auto-style49">
                <asp:Label ID="LB_rpass" runat="server" Text="Confirmar Contraseña"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:TextBox ID="TB_CConrasena" runat="server" class="form-control" TextMode="Password" ></asp:TextBox>
                <asp:CompareValidator ID="CV_CContrasena" runat="server" ControlToCompare="TB_Contrasena" ControlToValidate="TB_CConrasena" ErrorMessage="La Contraseña no es identica " ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
            </td>
    </div>
             <div class="row form-group">
            <td class="auto-style28" style="width">
                <asp:Label ID="LB_celu" runat="server" Text="Celular"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:TextBox ID="TB_Celular" runat="server" class="form-control" Height="46px"  MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Celular" runat="server" ControlToValidate="TB_Celular" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV_Nombre2" runat="server" ControlToValidate="TB_Celular" ErrorMessage="Solo Puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            </td>
        </div>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41" style="width: 1%"></td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style47">
                &nbsp;</td>
            <td class="auto-style32">
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
            <td class="auto-style29" style="width: 5%">&nbsp;</td>
            <td class="auto-style13" colspan="4">
            <div class="form-group">
                <asp:Button ID="B_Crear" class="btn btn-primary" runat="server" OnClick="B_Crear_Click" Text="Crear Usuario" />
            </div>
            </td>
            <td style="width: 5%">&nbsp;</td>
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

