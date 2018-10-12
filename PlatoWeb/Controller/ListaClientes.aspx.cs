using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_ListaClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 8;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {

            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaListaclientes(FORMULARIO, DDL);
        }
        catch
        {

            int DDL = 1;
            com = idioma.idiomaListaclientes(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_listClien.Text = com.A;
        LB_Buscar.Text = com.B;
        BT_Buscar.Text = com.C;
        REV_Username.Text = com.D;
        RFV_alerta.Text = com.E;
        GV_listClien.Columns[0].HeaderText = com.F;
        GV_listClien.Columns[1].HeaderText = com.G;
        GV_listClien.Columns[2].HeaderText = com.H;
        GV_listClien.Columns[3].HeaderText = com.I;
        GV_listClien.Columns[4].HeaderText = com.J;
        GV_listClien.Columns[5].HeaderText = com.K;

        LUser dato = new LUser();
        L_Persistencia data = new L_Persistencia();

        GV_listClien.DataSource = data.listadeClientes();
        GV_listClien.DataBind();

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        LUser dato = new LUser();
        UUsuario datos = new UUsuario();
        ClientScriptManager cm = this.ClientScript;
        DataTable usuario;

        datos.Nombre = TB_Filtro.Text.ToString();
        usuario = dato.BuscarCliente(datos);

        GV_listClien.DataSource = usuario;
        GV_listClien.DataBind();

        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");


    }

}