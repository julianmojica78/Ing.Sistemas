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


        LUser user = new LUser();
        UUsuario datos = new UUsuario();
        datos.Session = Session.SessionID;
        datos.User_Name1 = Session["nombre"].ToString();
        datos = user.Cerrar(datos);
        Session["user_id"] = null;
        Session["nombre"] = null;
        Response.Redirect(datos.Mensaje);
        Response.Cookies.Clear();
    }
}