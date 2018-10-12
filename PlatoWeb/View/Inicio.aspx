<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPagePrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Inicio.aspx.cs" Inherits="View_Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
        .fh5co-card-item .fh5co-text {
  padding: 0px 10px 10px 20px;
  text-align: center;
  position: relative;
  z-index: 22;
}
        .auto-style3 {
        width: 100%;
    }
    .auto-style4 {
        text-align: right;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE HTML>
<!--
	Aesthetic by gettemplates.co
	Twitter: http://twitter.com/gettemplateco
	URL: http://gettemplates.co
-->
<html>
	<head>
	<meta charset="utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
	<title>Inicio</title>


	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet"/>
	<link href="https://fonts.googleapis.com/css?family=Kaushan+Script" rel="stylesheet"/>
	

	<link rel="stylesheet" href="../Styles/css/animate.css"/>
	<link rel="stylesheet" href="../Styles/css/icomoon.css"/>
	<link rel="stylesheet" href="../Styles/css/themify-icons.css"/>
	<link rel="stylesheet" href="../Styles/css/bootstrap.css"/>
	<link rel="stylesheet" href="../Styles/css/magnific-popup.css"/>
	<link rel="stylesheet" href="../Styles/css/bootstrap-datetimepicker.min.css"/>
	<link rel="stylesheet" href="../Styles/css/owl.carousel.min.css"/>
	<link rel="stylesheet" href="../Styles/css/owl.theme.default.min.css"/>
	<link rel="stylesheet" href="../Styles/css/style.css"/>
	<script src="../Styles/js/modernizr-2.6.2.min.js"></script>


	</head>
	<body>
		
	<div class="gtco-loader"></div>
	
	<div id="page">
        <table class="auto-style3">
            <tr>
                <td class="auto-style4" style="width: 10%">
            <asp:DropDownList ID="DDL_Idioma" runat="server" AutoPostBack="True" class="form-control" Width="181px" OnSelectedIndexChanged="DDL_Idioma_SelectedIndexChanged" DataSourceID="ODS_Idioma" DataTextField="nombre" DataValueField="id">
                <asp:ListItem Value="1">Español</asp:ListItem>
                <asp:ListItem Value="2">Ingles</asp:ListItem>
            </asp:DropDownList>

                    <asp:ObjectDataSource ID="ODS_Idioma" runat="server" SelectMethod="obtenerIdioma" TypeName="Logica.L_Persistencia"></asp:ObjectDataSource>

                </td>
                <td>

                    &nbsp;</td>
            </tr>
        </table>
	<header id="gtco-header" class="gtco-cover gtco-cover-sm" role="banner" style="background-image: url(../imagen/fondo.jpeg)" data-stellar-background-ratio="0.5">
		<div class="overlay">
        </div>
		<div class="gtco-container">
			<div class="row">
				<div class="col-md-12 col-md-offset-0 text-center">
					

					<div class="row row-mt-15em">
						<div class="col-md-12 mt-text animate-box" data-animate-effect="fadeInUp">
							<span class="intro-text-small">
                                <asp:Label ID="L_MInicio" runat="server" Text="LA MEJOR PAGINA DE RESTAURANTES"></asp:Label></span>
							<h1 class="cursive-font">Plato Web</h1>	
						</div>
						
					</div>
							
					
				</div>
			</div>
		</div>
	</header>

	
	
	<div class="gtco-section">
		<div class="gtco-container">
			<div class="row">
				<div class="col-md-8 col-md-offset-2 text-center gtco-heading">
					<h2 class="cursive-font primary-color">
                        <asp:Label ID="L_PPopulares" runat="server" Text="Platos Populares"></asp:Label>
					</h2>
					<p><asp:Label ID="L_Opciones" runat="server" Text="Las Mejores Opciones."></asp:Label></p>
				</div>
			</div>
			<div class="row">

				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="../Imagen/arroz.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="../Imagen/arroz.jpg" alt="Image" class="img-responsive"/>
						</figure>
						<div class="fh5co-text">
							<h1>
							    <strong>
							<asp:Label ID="L_Plato1" runat="server" Text="Arroz" CssClass="fh5co-text" style="font-size: xx-large; color: #000000"></asp:Label>
							    </strong>
							</h1>
							<p>
                                <asp:Label ID="L_Detalle1" runat="server" Text="El mejor arroz del mundo."></asp:Label>
                            </p>
							<p><span class="price cursive-font">
                                <asp:Label ID="L_Precio1" runat="server" Text="$10.000"></asp:Label>
                                </span></p>
						</div>
					</a>
				</div>
				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="../Imagen/salchipapa.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="../Imagen/salchipapa.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>
                                <asp:Label ID="L_Plato2" runat="server" Text="Salchipapa"></asp:Label>
                            </h2>
							<p>
                                <asp:Label ID="L_Detalle2" runat="server" Text="La mejor salchipapa."></asp:Label>
                            </p>
							<p><span class="price cursive-font">
                                <asp:Label ID="L_Precio2" runat="server" Text="$15.000"></asp:Label>
                                </span></p>
						</div>
					</a>
				</div>
				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="../Imagen/sushi.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="../Imagen/sushi.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>
                                <asp:Label ID="L_Plato3" runat="server" Text="Sushi"></asp:Label>
                            </h2>
							<p>
                                <asp:Label ID="L_Detalle3" runat="server" Text="El mejor sushi."></asp:Label>
                            </p>
							<p><span class="price cursive-font">
                                <asp:Label ID="L_Precio3" runat="server" Text="$20.000"></asp:Label>
                                </span></p>

						</div>
					</a>
				</div>


<%--				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="images/img_4.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="images/img_4.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Organic Egg</h2>
							<p>Far far away, behind the word mountains, far from the countries Vokalia..</p>
							<p><span class="price cursive-font">$12.99</span></p>
						</div>
					</a>
				</div>

				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="images/img_5.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="images/img_5.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Tomato Soup with Chicken</h2>
							<p>Far far away, behind the word mountains, far from the countries Vokalia..</p>
							<p><span class="price cursive-font">$23.10</span></p>
						</div>
					</a>
				</div>

				<div class="col-lg-4 col-md-4 col-sm-6">
					<a href="images/img_6.jpg" class="fh5co-card-item image-popup">
						<figure>
							<div class="overlay"><i class="ti-plus"></i></div>
							<img src="images/img_6.jpg" alt="Image" class="img-responsive">
						</figure>
						<div class="fh5co-text">
							<h2>Salad with Crispy Chicken</h2>
							<p>Far far away, behind the word mountains, far from the countries Vokalia..</p>
							<p><span class="price cursive-font">$5.59</span></p>
						</div>
					</a>
				</div>--%>

			</div>
		</div>
	</div>
	<!-- </div> -->

	</div>
	
	<script src="../Styles/js/jquery.min.js"></script>
	<script src="../Styles/js/jquery.easing.1.3.js"></script>
	<script src="../Styles/js/bootstrap.min.js"></script>
	<script src="../Styles/js/jquery.waypoints.min.js"></script>
	<script src="../Styles/js/owl.carousel.min.js"></script>
	<script src="../Styles/js/jquery.countTo.js"></script>
	<script src="../Styles/js/jquery.stellar.min.js"></script>
	<script src="../Styles/js/jquery.magnific-popup.min.js"></script>
	<script src="../Styles/js/magnific-popup-options.js"></script>
	
	<script src="../Styles/js/moment.min.js"></script>
	<script src="../Styles/js/bootstrap-datetimepicker.min.js"></script>
	<script src="../Styles/js/main.js"></script>

	</body>
</html>

</asp:Content>

