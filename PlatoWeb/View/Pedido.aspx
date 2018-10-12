<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageMesero.master" AutoEventWireup="true" CodeFile="~/Controller/Pedido.aspx.cs" Inherits="View_Pedido" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 76px;
        }
        .auto-style2 {
            width: 80px;
        }
        .auto-style3 {
            width: 82px;
        }
        .auto-style5 {
            width: 148px;
        }
        .auto-style6 {
            width: 178px;
        }
        .auto-style7 {
            width: 232px;
        }
        .auto-style8 {
            width: 5%;
            height: 27px;
        }
        .auto-style9 {
            height: 27px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <h3 class="text-center">
                    <asp:Label ID="LB_pedidoT" runat="server" Text="Pedido"></asp:Label>
                </h3>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-right" style="width: 45%">
                <asp:Label ID="LB_seleccion" runat="server" Text="Seleccione la Mesa"></asp:Label>
            </td>
            <td style="width: 45%">
                <asp:DropDownList ID="DDL_Ubicacion" runat="server" DataSourceID="ODS_Ubicacion" DataTextField="ubicacion" DataValueField="id_mesa" Height="20px" Width="246px">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ODS_Ubicacion" runat="server" SelectMethod="obtenerubi" TypeName="Logica.LUser"></asp:ObjectDataSource>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="BT_Mesa" runat="server" OnClick="BT_Mesa_Click" Text="Ingresar Mesa" />
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <h3 class="text-center">
                    <asp:Label ID="LB_menuT" runat="server" Text="Menú"></asp:Label>
                </h3>
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="2">
                <%--<asp:DataList ID="DL_MenuPedi" runat="server" DataSourceID="ODS_Plato" RepeatDirection="Horizontal"  OnRowDataBound="DL_MenuPedi">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td colspan="3" class="auto-style7"><strong>
                                    <asp:Label ID="LB_Codigop" runat="server" CssClass="auto-style8" Text='<%# Bind("id_plato") %>'></asp:Label>
                                    <asp:Label ID="LB_Nombre" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style1" colspan="3">
                                    <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl='<%# Bind("imagen") %>' Width="114px" />
                                    <br />
                                    <asp:Label ID="LB_des" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                                    <br />
                                    <asp:Label ID="LB_prec" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    <asp:Label ID="LB_ingreCant" runat="server" Text="Ingrese la cantidad del pedido"></asp:Label>
                                </td>
                                <td class="auto-style5">
                                    <asp:TextBox ID="TB_insertarPedido" runat="server" MaxLength="2" ValidationGroup="1"></asp:TextBox>
                                </td>
                                <td rowspan="3" class="auto-style3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1" colspan="2">
                                    <asp:Button ID="B_guardar" runat="server" OnClick="B_guardar_Click" Text="ENVIAR" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>--%>
                
            </td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9" colspan="2">
<%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">--%>
                    <ContentTemplate>
                        <asp:DataList ID="DL_Pedido" runat="server" DataSourceID="ODS_Plato" OnItemDataBound="DataList1_SelectedIndexChanged" OnSelectedIndexChanged="B_guardar_Click" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <table class="auto-style7">
                                    <tr>
                                        <td class="auto-style7" colspan="3"><strong>
                                            <asp:Label ID="LB_Codigop" runat="server" CssClass="auto-style8" Text='<%# Bind("id_plato") %>'></asp:Label>
                                            <asp:Label ID="LB_Nombre" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                            </strong></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style1" colspan="3">
                                            <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl='<%# Bind("imagen") %>' Width="114px" />
                                    <br />
                                            <asp:Label ID="LB_des" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                                    <br />
                                            <asp:Label ID="LB_Prec" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                    <br />
                                    <br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">
                                            <asp:Label ID="LB_ingreCant" runat="server" Text="Ingrese la Cantidad del Pedido"></asp:Label>
                                        </td>
                                        <td class="auto-style5">
                                            <asp:TextBox ID="TB_insertarPedido" runat="server" Height="20px" MaxLength="2" ValidationGroup="1" Width="122px"></asp:TextBox>
                                        </td>
                                        <td class="auto-style3" rowspan="3">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">&nbsp;</td>
                                        <td class="auto-style2">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style1" colspan="2">
                                            <asp:Button ID="B_guardar" runat="server" OnClick="B_guardar_Click" Text="ENVIAR" />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>
                        <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="listadeMenu" TypeName="Logica.L_Persistencia"></asp:ObjectDataSource>
                    </ContentTemplate>
              <%--  </asp:UpdatePanel>--%>
            </td>
            <td aria-atomic="False" aria-busy="False" class="auto-style8"></td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td class="text-center" colspan="2">&nbsp;</td>
            <td aria-atomic="False" aria-busy="False" style="width: 5%">&nbsp;</td>
        </tr>
    </table>
&nbsp;
</asp:Content>


