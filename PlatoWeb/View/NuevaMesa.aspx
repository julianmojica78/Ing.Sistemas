﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/NuevaMesa.aspx.cs" Inherits="View_NuevaMesa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table class="nav-justified">
        <tr>
            <td colspan="4">
                <h1 class="text-center">
                    <asp:Label ID="LB_nuevamesa" runat="server" Text="Ingresar Mesas"></asp:Label>
                </h1>
            </td>
        </tr>
        <tr>
            <td style="height: 20px"></td>
            <td class="text-right" style="height: 20px">
                <asp:Label ID="LB_cantper" runat="server" Text="Cantidad de Personas"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:TextBox ID="TB_Cantidad" runat="server"  class="form-control" MaxLength="2" ValidationGroup="uno"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RFV_numeros" runat="server" ControlToValidate="TB_Cantidad" ErrorMessage="*" ForeColor="Red" ValidationExpression="^[0-9_-]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Cantidad" ErrorMessage="Ingrese solo numeros" ForeColor="Red" ValidationExpression="^[0-9]*" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td class="text-right" style="height: 20px">&nbsp;</td>
            <td style="height: 20px">
                &nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-right">
                <asp:Label ID="LB_ubi" runat="server" Text="Ubicación"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_Ubicacion" runat="server" class="form-control" MaxLength="20" ValidationGroup="uno"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_Ubicacion" ErrorMessage="*" ForeColor="Red" ValidationGroup="uno"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RFV_ubi" runat="server" ControlToValidate="TB_Ubicacion" ErrorMessage="Ingrese solo letras Y Numeros" ForeColor="Red" ValidationExpression="^[A-Za-z0-9_-]*$" ValidationGroup="uno"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" colspan="4">
                <asp:Button ID="BT_Nuevo" runat="server" OnClick="BT_Nuevo_Click" Text="Nuevo" class="btn btn-primary" ValidationGroup="uno"/>
            </td>
        </tr>
    </table>


</asp:Content>

