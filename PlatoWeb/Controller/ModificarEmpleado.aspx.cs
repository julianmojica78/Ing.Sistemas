using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_ModificarEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 26;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        

        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaModificarempleado(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaModificarempleado(FORMULARIO, DDL);
        }


        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_modiemp.Text = com.A;
        LB_nombre.Text = com.B;
        LB_apellido.Text = com.C;
        LB_usuario.Text = com.D;
        LB_email.Text = com.E;
        LB_contra.Text = com.F;
        LB_cedula.Text = com.G;
        LB_concon.Text = com.H;
        LB_celu.Text = com.I;
        LB_rol.Text = com.J;
        RFV_Nombre.Text = com.K;
        //RFV_Apellido.Text = com.L;
        REV_Apellido.Text = com.M;
        RFV_Usuario.Text = com.N;
        RFV_Email.Text = com.O;
        CV_CContrasena.Text = com.P;
        RFV_Cedula.Text = com.Q;
        REV_Nombre1.Text = com.R;
        REV_Nombre2.Text = com.T;
        RV_Rol.Text = com.W;
        B_Modificar.Text = com.X;
        Session["modificar"] = com.Y;

        UUsuario datos = new UUsuario();
        LUser user = new LUser();
        ClientScriptManager cm = this.ClientScript;
        string nombre = Session["nombre"].ToString();
        datos = user.ObtenerIds(nombre);
        if (!IsPostBack)
        {
            DDL_Rol.SelectedItem.Text = com.S;
            DDL_Rol.SelectedIndex = 1;
            DDL_Rol.SelectedItem.Text = com.U;
            DDL_Rol.SelectedIndex = 2;
            DDL_Rol.SelectedItem.Text = com.V;
            TB_Nombre.Text = (datos.Nombre);
            TB_Apellido.Text = (datos.Apellido);
            TB_Email.Text = (datos.Email);
            TB_Celular.Text = (datos.Telefono);
            TB_Cedula.Text = (datos.Cedula);
            TB_Usuario.Text = (datos.User_Name1);
            TB_Contrasena.Text = (datos.Clave);
            TB_CConrasena.Text = (datos.Rclave);
            Int32 rol = (datos.Id_Rol);
            datos = user.rol(rol);
            DDL_Rol.SelectedValue = (datos.Url);
        }
    }



    protected void B_Crear_Click(object sender, EventArgs e)
    {

        UEmpleados datos = new UEmpleados();
        UUsuario data = new UUsuario();
        LUser user = new LUser();
        LUsuario modificar = new LUsuario();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        data = user.ObtenerId(nombre);

        datos.Nombre = TB_Nombre.Text.ToString();
        datos.Apellido = TB_Apellido.Text.ToString();
        datos.Email = TB_Email.Text.ToString();
        datos.Telefono = TB_Celular.Text.ToString();
        datos.Cedula = TB_Cedula.Text.ToString();
        datos.Id_Rol = int.Parse(DDL_Rol.SelectedValue.ToString());
        datos.User_Name1 = TB_Usuario.Text.ToString();
        datos.Clave = TB_Contrasena.Text.ToString();
        datos.Rclave = TB_CConrasena.Text.ToString();
        datos.User_id = (data.User_id); 
        datos.Session = "a";
        //datos.User_id = int.Parse(Session["codigo"].ToString());
        data.Mensaje = Session["modificar"].ToString();


        data = modificar.modificarUsuario(datos,data);
        this.RegisterStartupScript("mensaje", data.Mensaje);

    }



    protected void TB_Email_TextChanged(object sender, EventArgs e)
    {

    }
}