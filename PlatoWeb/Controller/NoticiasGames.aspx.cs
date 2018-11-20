using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NoticiasGames : System.Web.UI.Page
{
    SRGamesCol.ServiceToken token = new SRGamesCol.ServiceToken();
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            SRGamesCol.Facebook_servideSoapClient etiqueta = new SRGamesCol.Facebook_servideSoapClient();

            {
                token.sToken = "platoweb0pAy3jMuqHXIBV0H2y5v";
            };

            string sToken = etiqueta.AutenticacionCliente(token);

            if (sToken.Equals("-1"))
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('Token invalido');</Script>");
                throw new Exception("token invalido");
            }
            token.AutenticacionToken = sToken;
            etiqueta.postpc(token);

            string m = "probando mensajes";
            Servicios p = new Servicios();

            Response.Write("<Script Language='JavaScript'>parent.alert('" + m + "');</Script>");
            GridView1.DataSource = p.obtenerPost(token);
            GridView1.DataBind();
        }
        catch (Exception ex)
        {

            Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
        }

    }


}