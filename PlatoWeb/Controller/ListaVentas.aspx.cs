using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Data;
using System.Collections;

public partial class View_ListaVentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 15;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaListaventas(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_listventas.Text = com.A;
        LB_buscar.Text = com.B;
        BT_Buscar.Text = com.C;
        validator_username.Text = com.D;
        RFV_alerta.Text = com.E;
        GV_listVentas.Columns[0].HeaderText = com.F;
        GV_listVentas.Columns[1].HeaderText = com.G;
        GV_listVentas.Columns[2].HeaderText = com.H;
        GV_listVentas.Columns[3].HeaderText = com.I;
        GV_listVentas.DataBind();


        L_Persistencia dato = new L_Persistencia();
        GV_listVentas.DataSource = dato.obtenerPedido();
        GV_listVentas.DataBind();

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {

        L_Persistencia dato = new L_Persistencia();
        UUser datos = new UUser();
        ClientScriptManager cm = this.ClientScript;

        String nombre = TB_Filtro.Text.ToString();

        try
        {
            DataTable validez = dato.ToDataTable(dato.buscarVentas(nombre));

            datos.X = int.Parse(validez.Rows[0]["id_pedido"].ToString());

            GV_listVentas.DataSource = dato.buscarVentas(nombre);
            GV_listVentas.DataBind();

        }
        catch
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Dato no Existe');window.location=\"ListaVentas.aspx\"</script>");


        }
}

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}