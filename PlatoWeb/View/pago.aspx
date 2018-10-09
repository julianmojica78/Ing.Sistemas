<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPago.master" AutoEventWireup="true" CodeFile="~/Controller/pago.aspx.cs" Inherits="View_pago" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table class="nav-justified">
        <tr>
            <td colspan="2">
                <h3 class="text-center">
                    <asp:Label ID="LB_pago" runat="server" Text="Pago de Reservas"></asp:Label>
                </h3>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 50%">
                <asp:Label ID="LB_preciore" runat="server" CssClass="auto-style1" Text="Precio Reserva:"></asp:Label>
            </td>
            <td style="width: 50%">
                <asp:Label ID="LB_valor" runat="server" CssClass="auto-style1" Text="$20.000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Button ID="BT_Pagar" runat="server" Text="Pagar" class="btn btn-primary" OnClick="BT_Pagar_Click"/>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>

