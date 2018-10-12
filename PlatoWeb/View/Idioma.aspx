<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/Idioma.aspx.cs" Inherits="View_Idioma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="nav-justified">
        <tr>
            <td style="width: 5%; height: 63px;"></td>
            <td class="text-center" colspan="4" style="height: 63px">
                <h2><strong>
                    <asp:Label ID="LB_TIdioma" runat="server" Text="Idioma"></asp:Label>
                    </strong></h2>
            </td>
            <td style="width: 5%; height: 63px;"></td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;"></td>
            <td style="width: 45%" colspan="2"></td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%"></td>
            <td style="width: 5%; height: 20px;"></td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
            <td style="width: 45%" colspan="2">
                <h4>
                    <asp:Label ID="LB_Idioma" runat="server" Text="Idioma"></asp:Label>
                </h4>
            </td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">
                <h4>
                    <asp:Label ID="LB_Controles" runat="server" Text="Controles"></asp:Label>
                </h4>
            </td>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
            <td style="width: 45%">
                <asp:Label ID="LB_Nombre" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="TB_Nombre" runat="server" Height="18px" MaxLength="50" Width="215px"></asp:TextBox>
            </td>
            <td style="width: 45%">
                &nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%" rowspan="2">
                <asp:Button ID="BT_Agregarc" runat="server" Text="Traducir" class="btn btn-primary" OnClick="BT_Agregarc_Click"/>
&nbsp;</td>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
            <td style="width: 45%">
                <asp:Label ID="LB_Terminacion" runat="server" Text="Terminacion:"></asp:Label>
                <asp:TextBox ID="TB_Terminacion" runat="server" Height="18px" MaxLength="50" Width="214px"></asp:TextBox>
            </td>
            <td style="width: 45%">
                &nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
            <td style="width: 45%" class="text-center">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Button ID="BT_Agregar" runat="server" OnClick="BT_Agregar_Click" Text="Agregar" class="btn btn-primary"/>
                &nbsp;
                <asp:Button ID="BT_Eliminar" runat="server" OnClick="Eliminar_Click" Text="Eliminar" class="btn btn-primary" />
                <ajaxToolkit:ConfirmButtonExtender ID="BT_Eliminar_ConfirmButtonExtender" runat="server" BehaviorID="BT_Eliminar_ConfirmButtonExtender" ConfirmText="Esta Seguro de Eliminar Este Idioma" TargetControlID="BT_Eliminar" />
            </td>
            <td style="width: 45%">
                &nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">
                <asp:Label ID="LB_Control" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="LB_Texto" runat="server"></asp:Label>
            </td>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
            <td style="width: 45%" class="text-center">
                &nbsp;</td>
            <td style="width: 45%">
                &nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">
                &nbsp;<asp:TextBox ID="TB_Texto" runat="server" Height="16px" Width="201px"></asp:TextBox>
                <asp:Button ID="BT_ModificarC" runat="server" Text="Modificar" class="btn btn-primary" OnClick="BT_ModificarC_Click" />
            </td>
            <td style="width: 5%; height: 20px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">
                <asp:GridView ID="GV_Idioma" runat="server" CellPadding="4" DataKeyNames="id" DataSourceID="ODS_Idioma" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GV_Idioma_SelectedIndexChanged1" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="terminacion" HeaderText="Terminacion" />
                        <asp:BoundField DataField="id" HeaderText="Codigo" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Idioma" runat="server" SelectMethod="obtenerIdioma" TypeName="Logica.L_Persistencia"></asp:ObjectDataSource>
            </td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">
                <asp:GridView ID="GV_Controles" runat="server" CellPadding="4" DataSourceID="ODS_Controles" ForeColor="#333333" GridLines="None" Height="100%" OnSelectedIndexChanged="GV_Controles_SelectedIndexChanged" Width="100%" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Select" Text="Seleccionar" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="control" HeaderText="Control" />
                        <asp:BoundField DataField="idioma_id" HeaderText="Codigo Idioma" />
                        <asp:BoundField DataField="formulario_id" HeaderText="Codifo Formulario" />
                        <asp:BoundField DataField="texto" HeaderText="Texto" />
                        <asp:BoundField DataField="id" HeaderText="Codigo" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Controles" runat="server" SelectMethod="listarcontroles" TypeName="Logica.LIdioma">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GV_Formulario" Name="formulario" PropertyName="SelectedValue" Type="Int32" />
                        <asp:ControlParameter ControlID="GV_Idioma" Name="idioma" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">
                <h4>
                    <asp:Label ID="LB_Formularios" runat="server" Text="Formularios"></asp:Label>
                </h4>
            </td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">
                <asp:GridView ID="GV_Formulario" runat="server" CellPadding="4" DataKeyNames="id" DataSourceID="ODS_Formulario" ForeColor="#333333" GridLines="None" Height="100%" Width="100%" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:Button ID="BT_SFormulario" runat="server" CausesValidation="False" CommandName="Select" Text="Seleccionar" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="url" HeaderText="URL" />
                        <asp:BoundField DataField="id" HeaderText="Codigo" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Formulario" runat="server" SelectMethod="listarformulario" TypeName="Logica.LIdioma"></asp:ObjectDataSource>
            </td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">&nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">&nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">&nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">&nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 5%">&nbsp;</td>
            <td style="width: 45%" colspan="2">&nbsp;</td>
            <td style="width: 1%">&nbsp;</td>
            <td style="width: 45%">&nbsp;</td>
            <td style="width: 5%">&nbsp;</td>
        </tr>
    </table>
    
</asp:Content>

