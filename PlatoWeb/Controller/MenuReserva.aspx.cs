using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_MenuReserva : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 24;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        

        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaMenureserva(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaMenureserva(FORMULARIO, DDL);
        }

       // Hashtable compIdioma = new Hashtable();
        //Session["mensajes"] = compIdioma;
       // DL_menuReser.Columns[0].HeaderText = com.B;
        Session["men"] = com.F;
        DL_menuReser.DataBind();


    }

    protected void DataList1_SelectedIndexChanged(object sender, DataListCommandEventArgs e)
    {
        UuserReservas pla = new UuserReservas();
        LUser inse = new LUser();

        //DataTable registro = inse.Insertarpreserva();


        int res = Convert.ToInt32(DL_menuReser.DataKeys[e.Item.ItemIndex].ToString());

    }

    protected void B_volver_Click(object sender, EventArgs e)
    {

        Response.Redirect("Resrvas.aspx");
    }

    protected void DataList1_SelectedIndexChanged1(object sender, DataListItemEventArgs e)
    {
        try
        {
            try
            {
                //((Label)e.Item.FindControl("LB_des")).Text = ((Hashtable)Session["mensajes"])["Descripcion"].ToString();
                //((Label)e.Item.FindControl("LB_prec")).Text = ((Hashtable)Session["mensajes"])["Precio"].ToString();
                ((Label)e.Item.FindControl("LB_ingreCanti")).Text = ((Hashtable)Session["mensajes"])["LB_ingreCanti"].ToString();
                ((Button)e.Item.FindControl("B_guardar")).Text = ((Hashtable)Session["mensajes"])["B_guardar"].ToString();

            }
            catch (Exception ex)
            {

                ((Button)e.Item.FindControl("B_guardare")).Text = ((Hashtable)Session["mensajes"])["B_guardare"].ToString();
            }
        }
        catch (Exception ex)
        {
        }
    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserReservas dato = new UuserReservas();
        UPreserva datos = new UPreserva();
        LUser doc = new LUser();
        L_Persistencia dac = new L_Persistencia();
        ClientScriptManager cm = this.ClientScript;
        string nombre = Session["usuario"].ToString();
        System.Data.DataTable validez1 = doc.obteberidres(nombre); //duda aca con doc
        Int32 id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        TextBox guardar = (TextBox)item.FindControl("TB_insertarPedido");
        datos.Cantidad = int.Parse(guardar.Text);
        Label lblid = (Label)item.FindControl("LB_idPlatos");
        datos.Id_plato = int.Parse(lblid.Text);
        datos.Id_reserva = id_reserva;

        dac.insertarPlatoR(datos);
        // doc.insertarplares(dato);
        String mens = Session["men"].ToString();
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('" + mens.ToString() + "');</script>");

    }

    protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}