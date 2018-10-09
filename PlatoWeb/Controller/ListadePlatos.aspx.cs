using System;
using System.Web.UI;
using System.Data;
using Utilitarios;
using Logica;
using System.Web;
using System.Collections;
using System.Web.UI.WebControls;
public partial class View_ListadePlatos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 10;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaListaplatos(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_listPlato.Text = com.A;
        BT_Nuevo.Text = com.B;
        B_modificar.Text = com.C;
        BT_Eliminar.Text = com.D;
        LB_buscar.Text = com.E;
        BT_Buscar.Text = com.F;
        RFV_alerta.Text = com.G;
        validator_username.Text = com.H;
        GV_Platos.Columns[0].HeaderText = com.I;
        GV_Platos.Columns[2].HeaderText = com.J;
        GV_Platos.Columns[3].HeaderText = com.K;
        GV_Platos.Columns[4].HeaderText = com.L;
        GV_Platos.Columns[5].HeaderText = com.M;
        Session["men"] = com.N;






      L_Persistencia dato = new L_Persistencia ();
        GV_Platos.DataSource = dato.obtenerMenu();
        GV_Platos.DataBind();
    }

    //protected void GridView1_SelectedIndexChanged1(object sender, GridViewRowEventArgs e)
    //{
    //    Session["id_plato"] = GV_Platos.SelectedRow.Cells[1].Text;
    //    Session["nombre"] = GV_Platos.SelectedRow.Cells[2].Text;
    //    Session["descripcion"] = GV_Platos.SelectedRow.Cells[3].Text;
    //    Session["precio"] = GV_Platos.SelectedRow.Cells[4].Text;
    //    Session["imagen"] = GV_Platos.SelectedRow.Cells[5].Text;


    //    try
    //    {
    //        try
    //        {
    //            ((Label)e.Row.FindControl("GV_Platos")).Text = ((Hashtable)Session["mensajes"])["GV_Platos"].ToString();
    //        }
    //        catch (Exception exe)
    //        {

    //            ((Button)e.Row.FindControl("B_Seleccionar")).Text = ((Hashtable)Session["mensajes"])["B_Seleccionar"].ToString();
    //        }
    //    }
    //    catch (Exception exx)
    //    {
    //    }
    //}

    protected void B_modificar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarMenu.aspx");
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrearMenu.aspx");
    }

    protected void BT_Eliminar_Click(object sender, EventArgs e)
    {
        UuserCrear datos = new UuserCrear();
        LUser dato = new LUser();
        ClientScriptManager cm = this.ClientScript;
        L_Persistencia logica = new L_Persistencia();
        Utilitarios.Menu menu = new Utilitarios.Menu();
        String nombre = Session["nombrep"].ToString();
        DataTable validez1 = dato.obtenerMesa(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_plato"].ToString());
        menu.Id_plato = User_id;
        //dato.eliminarPlato(datos);
        datos = logica.BorrarMenu(menu);
        String mens = Session["men"].ToString();
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"ListadePlatos.aspx\"</script>");

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        LUser dato = new LUser();
        UUser datos = new UUser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
        // datos.Nombre = nombre;
        DataTable validez = dato.validarbuscarM(nombre);

        datos.X = int.Parse(validez.Rows[0]["id_plato"].ToString());
        GV_Platos.DataSource = dato.buscarPla((TB_Filtro.Text.ToString()));
        GV_Platos.DataBind();

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
    }

    protected void GridView1_SelectedIndexChanged1(object sender, GridViewRowEventArgs e)
    {
        //String mensaje = Session["men"].ToString();
        //((Button)e.Row.FindControl("B_Seleccionar")).Text = ((Hashtable)Session["mensajes"])[mensaje].ToString();
    }

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        Session["id_plato"] = GV_Platos.SelectedRow.Cells[1].Text;
        Session["nombrep"] = GV_Platos.SelectedRow.Cells[2].Text;
        Session["descripcion"] = GV_Platos.SelectedRow.Cells[3].Text;
        Session["precio"] = GV_Platos.SelectedRow.Cells[4].Text;
        Session["imagen"] = GV_Platos.SelectedRow.Cells[5].Text;
    }

    protected void GV_Platos_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id_plato"] = GV_Platos.SelectedRow.Cells[1].Text;
        Session["nombrep"] = GV_Platos.SelectedRow.Cells[2].Text;
        Session["descripcion"] = GV_Platos.SelectedRow.Cells[3].Text;
        Session["precio"] = GV_Platos.SelectedRow.Cells[4].Text;
        Session["imagen"] = GV_Platos.SelectedRow.Cells[5].Text;
    }
}