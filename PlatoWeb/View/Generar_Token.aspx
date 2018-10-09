<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Generar_Token.aspx.cs" Inherits="View_Generar_Token" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }
        .auto-style28 {
            text-align: right;
        }
        .auto-style29 {
            text-align: center;
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style27">
        <tr>
            <td class="auto-style29" colspan="2">
                <asp:Label ID="LB_recuperar" runat="server" Text="RECUPERAR CONTRASEÑA"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">
                <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style28" style="width: 40%">&nbsp;</td>
            <td>
                <asp:Label ID="LB_nombre" runat="server" Text="Ingrese su nombre de usuario"></asp:Label>
                <asp:TextBox ID="TB_generar_token" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="2">
                <asp:Button ID="Aceptar" runat="server" OnClick="Aceptar_Click" Text="ACEPTAR" />
            </td>
        </tr>
    </table>
</asp:Content>

