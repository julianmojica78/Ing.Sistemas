using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using Logica;
using Utilitarios;


public partial class View_InicioCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Int32 FORMULARIO = 41;

        UUser datos = new UUser();
        LIdioma user = new LIdioma();

        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaInicio1(FORMULARIO, DDL);
        }
        catch
        {

            int DDL = 1;
            com = idioma.idiomaInicio1(FORMULARIO, DDL);
        }


        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;


        L_MInicio.Text = com.A;
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



    }
}