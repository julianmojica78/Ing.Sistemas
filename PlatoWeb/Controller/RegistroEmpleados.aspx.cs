using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;
using System.Data;

public partial class View_RegistroEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 30;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
 
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaRegistrarempleado(FORMULARIO, DDL);

        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaRegistrarempleado(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        
        LB_regisemp.Text = com.A;
        LB_nombre.Text = com.B;
        LB_user.Text = com.C;
        LB_pas.Text = com.D;
        LB_rpas.Text = com.E;
        LB_apellido.Text = com.F;
        LB_email.Text = com.G;
        LB_cedula.Text = com.H;
        LB_celu.Text = com.I;
        CV_CContrasena.Text = com.J;
        LB_rol.Text = com.K;
        B_Crear.Text = com.O;
        Session["men"] = com.P; 
    }

    protected void B_Crear_Click(object sender, EventArgs e)
    {

        UEmpleados datos = new UEmpleados();
        LUsuario user = new LUsuario();
        UUsuario mensaje = new UUsuario();
        ClientScriptManager cm = this.ClientScript;
        LUser us = new LUser();


        datos.Nombre = TB_Nombre.Text.ToString();
        datos.Apellido = TB_Apellido.Text.ToString();
        datos.Email = TB_Email.Text.ToString();
        datos.Telefono = TB_Celular.Text.ToString();
        datos.Cedula = TB_Cedula.Text.ToString();
        datos.Id_Rol = int.Parse(DDL_Rol.SelectedValue.ToString());
        datos.User_Name1 = TB_Usuario.Text.ToString();
        datos.Clave = TB_Contrasena.Text.ToString();
        datos.Rclave = TB_CConrasena.Text.ToString();
        datos.Puntos = 0;
        datos.Session = "a";
        datos.Sesiones = 0;
        datos.Intentos = 0;
        mensaje.Mensaje = Session["men"].ToString();

        mensaje = user.insertarUsuario(datos, mensaje);
        this.RegisterStartupScript("mensaje", mensaje.Mensaje);
        DataTable regis = user.ToDataTable(user.obtenerAu());
        String esquema = "usuario";
        String tabla = "usuario";
        String pk = Session["user_id"].ToString();
        String session = Session.SessionID;
        us.insert(regis, esquema, tabla, pk, session);

    }
}