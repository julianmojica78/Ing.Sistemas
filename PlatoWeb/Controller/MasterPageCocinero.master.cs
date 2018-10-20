using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_MasterPageCocinero : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();

        Int32 FORMULARIO = 18;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaMastercocinero(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaMastercocinero(FORMULARIO, DDL);
        }


        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_Pedidos.Text = com.A;
        LB_cerrar.Text = com.B;

        try
        {

            datos.User_name = Session["nombre"].ToString();
            user.validarlogin(datos);
            datos.User_name = Session["nombre"].ToString();
        }
        catch
        {
            datos = user.validarlogin(datos);
            Response.Redirect(datos.Url);

        }
    }
}
