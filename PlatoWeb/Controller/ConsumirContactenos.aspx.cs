using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;
using System.Data;

public partial class View_ConsumirContactenos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BT_Enviar_Click1(object sender, EventArgs e)
    {
        try
        {

            // SRContactenos es el nombre q el cliente le da al servicio
            SRContactenos.WSContactenosSoapClient obwsClienteSoap = new SRContactenos.WSContactenosSoapClient();


            SRContactenos.clsSeguridadContactenos obclsSeguridad = new SRContactenos.clsSeguridadContactenos()
            {
                stToken = "contactenos" /// es la llave con la que se conecta al servicio, no tocar ya q no serviria el servivio
                //stToken = "hola"
            };

            string stToken = obwsClienteSoap.AutenticacionUsuario(obclsSeguridad);

            if (stToken.Equals("-1")) throw new Exception("Requiere Validacion");

            obclsSeguridad.AutenticacionToken = stToken;


            // ESOS SON LAS COSAS QUE PIDE EL SERVICIO, 5 TEXTBOX, DEJAR obclsSeguridad YA QUE ES LA SEGURIDAD DEL TOKEN
            obwsClienteSoap.contactenos(obclsSeguridad, TB_Nombre.Text, TB_apellido.Text, TB_Email.Text, TB_Telefono.Text, TB_Detalle.Text);

            UUser dato = new UUser();
            LUser contacto = new LUser();
            L_Persistencia logica = new L_Persistencia();
            UContacto menu = new UContacto();
            menu.Nombre = TB_Nombre.Text.ToString();
            menu.Telefono = TB_Telefono.Text.ToString();
            menu.Email = TB_Email.Text.ToString();
            menu.Detalle = TB_Detalle.Text.ToString();
            menu = logica.insertarcontacto(menu);
            ClientScriptManager cm = this.ClientScript;
            //dato = contacto.contactenos(TB_Nombre.Text, TB_Telefono.Text, TB_Email.Text, TB_Detalle.Text);
            //String mens = Session["men"].ToString();
            //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"Inicio.aspx\"</script>");
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('mensaje enviado correctamente');window.location=\"Inicio.aspx\"</script>");

            //DataTable regis = contacto.ToDataTable(contacto.obtenerAcontacto());
            //String esquema = "usuario";
            //String tabla = "contacto";
            //String pk = "1";
            //String session = Session.SessionID;
            //contacto.insert(regis, esquema, tabla, pk, session);

        }
        catch (Exception ex)
        {
            Response.Write("<Script Languaje='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
        }
    }
}