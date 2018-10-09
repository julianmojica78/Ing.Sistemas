using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Data;
using System.Web;
using System.Collections;

public partial class View_Pedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

       

        Int32 FORMULARIO = 33;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        //com = idioma.idiomaPedido(FORMULARIO, DDL);

        DataTable info = idioma.obtenerControl(FORMULARIO, DDL);
        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        compIdioma = idioma.hastableIdioma(info, compIdioma);
        LB_pedidoT.Text = compIdioma["LB_pedidoT"].ToString(); 
        LB_seleccion.Text = compIdioma["LB_seleccion"].ToString(); ;
        BT_Mesa.Text = compIdioma["BT_Mesa"].ToString(); ;
        LB_menuT.Text = compIdioma["LB_menuT"].ToString(); ;
        Session["men"] = compIdioma["JS_pedido"].ToString(); ;
        DL_Pedido.DataBind();
    }


    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserPedido dato = new UuserPedido();
        ClientScriptManager cm = this.ClientScript;
        LUser doc = new LUser();

        dato.Id_usuario = int.Parse(Session["user_id"].ToString());
        DataTable validez1 = doc.obtenerpe(dato.Id_usuario);
        dato.Id_pedido = int.Parse(validez1.Rows[0]["id_pedido"].ToString());
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        TextBox guardar = (TextBox)item.FindControl("TB_insertarPedido");
        dato.Cantidad = int.Parse(guardar.Text);
        Label lblid = (Label)item.FindControl("LB_Codigop");
        dato.Id_plato = int.Parse(lblid.Text);

        doc.guardarPedido(dato);
        String mens = Session["men"].ToString();
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('" + mens.ToString() + "');</script>");


    }

    protected void BT_Mesa_Click(object sender, EventArgs e)
    {
        UuserPedido dato = new UuserPedido();
        ClientScriptManager cm = this.ClientScript;
        LUser doc = new LUser();
        dato.Id_mesa = int.Parse(DDL_Ubicacion.SelectedValue.ToString());
        dato.Id_mesero = int.Parse(Session["user_id"].ToString());
        doc.guardarPedido1(dato);
    }



    protected void DataList1_SelectedIndexChanged(object sender, DataListItemEventArgs e)
    {

            try
            {
                try
                {
                
                    ((Label)e.Item.FindControl("LB_ingreCant")).Text = ((Hashtable)Session["mensajes"])["LB_ingreCant"].ToString();
                ((Button)e.Item.FindControl("B_guardar")).Text = ((Hashtable)Session["mensajes"])["B_guardar"].ToString();

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

 
}