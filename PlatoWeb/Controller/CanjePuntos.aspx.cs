using System;
using System.Data;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Web;
using System.Collections;

public partial class View_CanjePuntos : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 1;
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

        DataTable info = idioma.obtenerControl(FORMULARIO, DDL);
        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        compIdioma = idioma.hastableIdioma(info, compIdioma);
        L_PuntosR.Text = compIdioma["L_PuntosR"].ToString();
        L_cantPuntos.Text = compIdioma["L_cantPuntos"].ToString();
        L_puntosInsu.Text = compIdioma["L_puntosInsu"].ToString();
        L_Historial.Text = compIdioma["L_Historial"].ToString();
        BT_Regresar.Text = compIdioma["BT_Regresar"].ToString();
        GV_Historial.Columns[0].HeaderText = compIdioma["LB_Mesa"].ToString();
        GV_Historial.Columns[1].HeaderText = compIdioma["LB_Dia"].ToString();
        DL_canje.DataBind();
        Session["men"] = compIdioma["JS_canje"].ToString();

        int Id = int.Parse(Session["user_id"].ToString());
        LUser dao = new LUser();
        DataTable tabla = new DataTable();
        L_Persistencia data = new L_Persistencia();
        int id_usuario = int.Parse(Session["user_id"].ToString());
        GV_Historial.DataSource = data.listadeReservas(id_usuario);
        GV_Historial.DataBind();

        DataTable inter = data.ToDataTable(data.listadePuntos(Id));
        //tabla = data.listadePuntos(Id);
        UuserReservas dato = dao.canje(inter);
        LB_puntos.Text = inter.Rows[0]["puntos"].ToString();
        L_puntosInsu.Visible = dato.Est1;
        DL_canje.Visible = dato.Est2;
    }

    protected void BT_MReservas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Resrvas.aspx");
    }

    protected void BT_Canje_Click(object sender, EventArgs e)
    {
        LUser datos = new LUser();
        int Id = int.Parse(Session["user_id"].ToString());
        DataTable data = datos.redimir(Id);
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        Label lblid = (Label)item.FindControl("L_codigo");
        int x = int.Parse(lblid.Text);

        datos.cortesia(x);
        String mens = Session["men"].ToString();
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"Resrvas.aspx\"</script>");

    }

    protected void DL_Platos_SelectedIndexChanged(object sender, DataListItemEventArgs e)
    {

        try
        {
            try
            {
                ((Button)e.Item.FindControl("BT_Canje")).Text = ((Hashtable)Session["mensajes"])["BT_Canje"].ToString();

            }
            catch (Exception ex)
            {

                ((Button)e.Item.FindControl("B_guardar")).Text = ((Hashtable)Session["mensajes"])["B_guardar"].ToString();
            }
        }
        catch (Exception ex)
        {
        }
    }

    protected void DL_Platos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}