using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 31;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        

        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaRegistro(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaRegistro(FORMULARIO, DDL);
        }


        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        
        LB_regis.Text = com.A;
        LB_nombre.Text = com.B;
        LB_user.Text = com.C;
        LB_pass.Text = com.D;
        LB_rpass.Text = com.E;
        REV_Nombre.Text = com.F;
        validator_username.Text = com.G;
        CV_CContrasena.Text = com.H;
        LB_apellido.Text = com.I;
        LB_email.Text = com.J;
        LB_cedula.Text = com.K;
        LB_celu.Text = com.L;
        REV_Nombre0.Text = com.M;
        REV_Nombre1.Text = com.N;
        REV_Nombre2.Text = com.O;
        B_Crear.Text = com.P;
        Session["mensaje"] = com.Q;
        Session["men1"] = com.R;
    }

    protected void B_Crear_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UEmpleados datos = new UEmpleados();
        UUsuario dato = new UUsuario();
        LUsuario user = new LUsuario();
        UUser mensaje = new UUser();

        datos.Nombre = TB_Nombre.Text.ToString();
        datos.Apellido = TB_Apellido.Text.ToString();
        datos.Email = TB_Email.Text.ToString();
        datos.Telefono = TB_Celular.Text.ToString();
        datos.Cedula = TB_Cedula.Text.ToString();
        datos.Puntos = 0;
        datos.Id_Rol = 4;
        datos.User_Name1 = TB_Usuario.Text.ToString();
        datos.Clave = TB_Contrasena.Text.ToString();
        datos.Rclave = TB_CConrasena.Text.ToString();
        datos.Sesiones = 0;
        datos.Intentos = 0;
        datos.Session = "a"; 

        dato.Mensaje = Session["mensaje"].ToString();
        dato.Extension = Session["men1"].ToString();

        dato = user.insertUsuario(datos , dato);
        this.RegisterStartupScript("mensaje",dato.Mensaje);

        //Response.Redirect(datos.Url);





    }
}