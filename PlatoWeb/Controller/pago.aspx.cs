using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_pago : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 35;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
       

        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaPago(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaPago(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_pago.Text = com.A;
        LB_preciore.Text = com.B;
        LB_valor.Text = com.C;
        BT_Pagar.Text = com.D;
        Session["men"] = com.E;

        UUser datos = new UUser();
        LUser user = new LUser();


        try
        {

            datos.User_name = Session["nombre"].ToString();
            user.validarlogin(datos);
        }
        catch
        {
            datos = user.validarlogin(datos);
            Response.Redirect(datos.Url);

        }
    }

    protected void BT_Pagar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        L_Persistencia user = new L_Persistencia();
        UReservation datos = new UReservation();
        UReserva mensaje = new UReserva();


        datos.Id_usuario = int.Parse(Session["user_id"].ToString());
        mensaje.Mensaje = Session["men"].ToString();
       mensaje = user.pago(datos,mensaje);
        this.RegisterStartupScript("mensaje",mensaje.Mensaje);

        Session["user_id"] = null;

    }
}