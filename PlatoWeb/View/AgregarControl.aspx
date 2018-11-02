<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/AgregarControl.aspx.cs" Inherits="View_AgregarControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <h3 class="text-center">
                    <asp:Label ID="Label2" runat="server" Text="Agregar Controlador"></asp:Label>
                </h3>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;"></td>
            <td class="text-right" style="width: 45%; height: 20px;">
                <asp:Label ID="LB_Idioma" runat="server" Text="Idioma:"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:DropDownList ID="DDL_Idioma" runat="server" DataSourceID="ODS_Idioma" DataTextField="nombre" DataValueField="id" Height="31px" Width="216px" AutoPostBack="True">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ODS_Idioma" runat="server" SelectMethod="obtenerIdioma" TypeName="Logica.L_Persistencia"></asp:ObjectDataSource>
            </td>
            <td style="width: 5%; height: 20px;"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-right" style="width: 45%">
                <asp:Label ID="LB_Formulario" runat="server" Text="Formulario:"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:Label ID="L_Formulario" runat="server"></asp:Label>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-right" style="width: 45%">
                <asp:Label ID="LB_Control" runat="server" Text="Control:"></asp:Label>
            </td>
            <td style="height: 20px">
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:Label ID="L_Control" runat="server"></asp:Label>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;"></td>
            <td class="text-right" style="width: 45%; height: 20px;">
                <asp:Label ID="LB_Texto" runat="server" Text="Texto"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:Label ID="l_Texto" runat="server"></asp:Label>
            </td>
            <td style="width: 5%; height: 20px;"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" class="text-right">
                <asp:Label ID="LB_Traduccion" runat="server" Text="Traducir"></asp:Label>
            </td>
            <td style="height: 20px">
                <asp:TextBox ID="TB_Texto" runat="server" Height="20px" TabIndex="50" Width="208px"></asp:TextBox>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-center" colspan="2">
                <asp:Button ID="BT_AControl" runat="server" OnClick="Button1_Click" Text="Agregar Control" />
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

