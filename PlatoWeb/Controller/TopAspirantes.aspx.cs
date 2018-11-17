using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;
using System.Data;

public partial class View_TopAspirantes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
        //    Servicios.ServiciosSoapClient men = new Servicios.ServiciosSoapClient();
        //    //men.ClientCredentials.UserName.UserName = "";

        //    Servicios.Seguridad obSeguridad = new Servicios.Seguridad()
        //    {
        //        stToken = DateTime.Now.ToString("yyyyMMdd")
        //    };

        //    String StToken = men.AutenticationUsuario(obSeguridad);
        //    if (StToken.Equals("-1")) throw new Exception("Requiere Validacion");

        //    obSeguridad.AutenticationToken = StToken;

        //    String ofertas = men.Ofertas(obSeguridad);

        //    DataTable ofer = JsonConvert.DeserializeObject<DataTable>(ofertas);
    //    SRUniempleo.ServidorUniempleoSoapClient servicio = new SRUniempleo.ServidorUniempleoSoapClient();
    //    DataSet topaaspirantes = servicio.Top_5_Aspirantes();
    //    GridView1.DataSource = topaaspirantes;
    //    GridView1.DataBind();
    //}
    //catch (Exception ex)
    //{
    //    Response.Write("<Script language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
    }
}