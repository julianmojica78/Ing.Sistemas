using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_Cerrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        L_Persistencia user = new L_Persistencia();
        UUsuario datos = new UUsuario();
        datos.Session = Session.SessionID;
        datos.User_Name1 = Session["name"].ToString();
        datos = user.Cerrar(datos);
        Session["user_id"] = null;
        Session["nombre"] = null;
        Response.Redirect(datos.Mensaje);
        Response.Cookies.Clear();
    }
}