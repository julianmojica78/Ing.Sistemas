<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/menuPrincipal.aspx.cs" Inherits="View_menuPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style27 {
            width: 100%;
        }

        .auto-style28 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <div id="fb-root"></div>
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = 'https://connect.facebook.net/es_LA/sdk.js#xfbml=1&version=v3.2&appId=184076195845739&autoLogAppEvents=1';
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
    <div>
    <table class="auto-style27">
        <tr>
            <td>
                <h1 class="auto-style28">
                    <asp:Label ID="L_MenuPrin" runat="server" Text="Menu"></asp:Label>
                </h1>
                <p class="auto-style28">
                    &nbsp;
                     <iframe src="https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fpermalink.php%3Fstory_fbid%3D648813295513479%26id%3D648812685513540&width=500" width="500" height="163" style="border:none;overflow:hidden" scrolling="no" frameborder="0" allowTransparency="true" allow="encrypted-media"" width="500" height="163" style="border:none;overflow:hidden" scrolling="no" frameborder="0" allowTransparency="true" allow="encrypted-media"></iframe>
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DL_Menuprin" runat="server" DataSourceID="ODS_Plato" RepeatDirection="Horizontal" RepeatColumns="4">
                    <ItemTemplate>
                        <table class="auto-style27">
                            <tr>
                                <td colspan="3">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                              <div class="row">
                                <div class="col-lg-4 col-md-4 col-sm-6">
                                    <td>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("imagen") %>' width="20%" />
                                    </td>
                                </div>
                            </div>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                <asp:ObjectDataSource ID="ODS_Plato" runat="server" SelectMethod="listadeMenu" TypeName="Logica.L_Persistencia"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

