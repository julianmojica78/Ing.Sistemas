using System;
using Utilitarios;
using Logica;
using System.Collections;
using System.Data;
using System.Web;

public partial class View_AgregarControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 44;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        Int32 DDL;
        try
        {
            DDL = int.Parse(Session["ddl"].ToString());
        }
        catch
        {
            DDL = 1;
        }
        
        //com = idioma.idiomaCanje(FORMULARIO, DDL);

        DataTable info = idioma.obtenerControl(FORMULARIO, DDL);
        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        compIdioma = idioma.hastableIdioma(info, compIdioma);
        Label2.Text = compIdioma["Label2"].ToString();
        LB_Idioma.Text = compIdioma["LB_Idioma"].ToString();
        LB_Formulario.Text = compIdioma["LB_Formulario"].ToString();
        LB_Control.Text = compIdioma["LB_Control"].ToString();
        LB_Texto.Text = compIdioma["LB_Texto"].ToString();
        LB_Traduccion.Text = compIdioma["LB_Traduccion"].ToString();
        BT_AControl.Text = compIdioma["BT_AControl"].ToString();

        L_Formulario.Text = Session["formulario_id"].ToString();
        L_Control.Text = Session["control"].ToString();
        l_Texto.Text = Session["texto"].ToString();
        Session["men"] = compIdioma["JS_agreCon"].ToString();
        Session["men1"] = compIdioma["JS_agreCon1"].ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UIdioma user = new UIdioma();
        LIdioma datos = new LIdioma();



        user.Idioma = int.Parse(DDL_Idioma.SelectedValue.ToString());
        user.Formulario = int.Parse(L_Formulario.Text.ToString());
        user.Control = L_Control.Text.ToString();
        user.Texto = TB_Texto.Text.ToString();
        user.Mensaje = Session["men"].ToString();
        user.A = Session["men1"].ToString();
        user = datos.agregarControl(user);
        this.RegisterStartupScript("mensaje", user.Mensaje);
    }
}