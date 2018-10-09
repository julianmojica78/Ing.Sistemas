using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_Despachos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        Int32 FORMULARIO = 5;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaDespachos(FORMULARIO, DDL);

        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaDespachos(FORMULARIO, DDL);

        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;


        LB_pedidos.Text = com.A;
        LB_Reservas.Text = com.B;

        GV_Pedidos.Columns[0].HeaderText = com.C;
        GV_Pedidos.Columns[1].HeaderText = com.D;
        GV_Pedidos.Columns[2].HeaderText = com.E;

        GV_Despachar.Columns[0].HeaderText = com.D;
        GV_Despachar.Columns[1].HeaderText = com.F;
        GV_Despachar.Columns[2].HeaderText = com.G;
        GV_Despachar.Columns[3].HeaderText = com.H;

        GV_Reservas.Columns[0].HeaderText = com.C;
        GV_Reservas.Columns[1].HeaderText = com.D;
        GV_Reservas.Columns[2].HeaderText = com.E;

        GV_DespachoR.Columns[0].HeaderText = com.D;
        GV_DespachoR.Columns[1].HeaderText = com.F;
        GV_DespachoR.Columns[2].HeaderText = com.G;
        GV_DespachoR.Columns[3].HeaderText = com.H;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
    }

        protected void GV_Pedidos_ShowDeleteButton(object sender, EventArgs e)
    {
        
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UDespachos datos = new UDespachos();
        LUser user = new LUser();

        Session["pedido"] = GV_Despachar.SelectedRow.Cells[0].Text;
        //Session["reserva"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["plato"]= GridView1.SelectedRow.Cells[1].Text;
        Int32 id_pedido = int.Parse(Session["pedido"].ToString());
        //Int32 id_plato = int.Parse(Session["plato"].ToString());
        DateTime fecha_despacho = DateTime.Now;

       datos = user.despachos(id_pedido,fecha_despacho);
        Response.Redirect(datos.Url);


    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UDespachos datos = new UDespachos();
        LUser user = new LUser();

        Session["pedido"] = GV_Despachar.SelectedRow.Cells[0].Text;
        //Session["reserva"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["plato"]= GridView1.SelectedRow.Cells[1].Text;
        Int32 id_pedido = int.Parse(Session["pedido"].ToString());
        //Int32 id_plato = int.Parse(Session["plato"].ToString());
        DateTime fecha_despacho = DateTime.Now;

        datos = user.despachos(id_pedido, fecha_despacho);
        Response.Redirect(datos.Url);


    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UDespachos datos = new UDespachos();
        LUser user = new LUser();

        Session["pedido"] = GV_DespachoR.SelectedRow.Cells[0].Text;
        //Session["reserva"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["plato"]= GridView1.SelectedRow.Cells[1].Text;
        Int32 id_pedido = int.Parse(Session["pedido"].ToString());
        //Int32 id_plato = int.Parse(Session["plato"].ToString());
        DateTime fecha_despacho = DateTime.Now;

        datos = user.despachos1(id_pedido, fecha_despacho);
        Response.Redirect(datos.Url);
    }


}
