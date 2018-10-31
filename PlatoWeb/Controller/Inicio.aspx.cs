using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using Utilitarios;


public partial class View_Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Int32 FORMULARIO = 7;

        Estado est = new Estado();
        UUser datos = new UUser();
        LIdioma user = new LIdioma();

        try
        {
              Session["ddl"] = DDL_Idioma.SelectedValue.ToString();

        }   
        catch
        {

            Session["ddl"] = 1;
        }

        int DDL = int.Parse(Session["ddl"].ToString()); ;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        com = idioma.idiomaInicio(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;


        L_MInicio.Text =com.A;
        L_PPopulares.Text = com.B;
        L_Opciones.Text = com.C;

        L_Plato1.Text = com.D;
        L_Detalle1.Text = com.E;
        L_Precio1.Text = com.F;

        L_Plato2.Text = com.G;
        L_Detalle2.Text = com.H;
        L_Precio2.Text = com.I;

        L_Plato3.Text = com.J;
        L_Detalle3.Text = com.K;
        L_Precio3.Text = com.L;

        Session["user_name"] = "";
        Session["correo"] = "";

    }

    protected void DDL_Idioma_SelectedIndexChanged(object sender, EventArgs e)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
    }
}