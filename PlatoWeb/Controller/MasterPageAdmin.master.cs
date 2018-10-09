using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_MasterPageAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 17;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaMasteradmin(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_menunave.Text = com.A;
        LB_cerrar.Text = com.B;
        LB_users.Text = com.C;
        LB_comen.Text = com.D;
        LB_menu.Text = com.E;
        LB_Mesas.Text = com.F;
        LB_ventas.Text = com.G;
        LB_Reportes.Text = com.H;
        LB_clientes.Text = com.I;
        LB_Emple.Text = com.J;
        LB_Coment.Text = com.K;
        LB_menu1.Text = com.L;
        LB_mesas1.Text = com.M;
        LB_pedidos.Text = com.N;
        LB_Rerservas.Text = com.O;
        LB_repo1.Text = com.P;
        LB_repo2.Text = com.Q;
        LB_repo3.Text = com.R;
        LB_Idioma.Text = com.S;

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
}
