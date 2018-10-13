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

public partial class View_ListaReservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 12;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaListaReservas(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_listReser.Text = com.A;
        LB_buscar.Text = com.B;
        BT_Buscar.Text = com.C;
        validator_username.Text = com.D;
        RFV_alerta.Text = com.E;
        GV_listReservas.Columns[0].HeaderText = com.F;
        GV_listReservas.Columns[1].HeaderText = com.G;
        GV_listReservas.Columns[2].HeaderText = com.H;
        GV_listReservas.Columns[3].HeaderText = com.I;

        LUser dato = new LUser();
        L_Persistencia data = new L_Persistencia();
        GV_listReservas.DataSource = data.ListReserva();
        GV_listReservas.DataBind();
    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        LUser dato = new LUser();
        UUsuario datos = new UUsuario();
        L_Persistencia data = new L_Persistencia();
        ClientScriptManager cm = this.ClientScript;
        DataTable usuario;

        //datos.Nombre = TB_Filtro.Text.ToString();
        ////datos = dato.BuscarEmpleado(datos);
        //usuario = dato.BuscarVentas(datos);

        //GV_listReservas.DataSource = usuario;
        //GV_listReservas.DataBind();
        String nombre = TB_Filtro.Text.ToString();

        try
        {
            DataTable validez = data.ToDataTable(data.buscarReserva(nombre));

            datos.X = int.Parse(validez.Rows[0]["user_id"].ToString());


            GV_listReservas.DataSource = data.buscarReserva(nombre);
            GV_listReservas.DataBind();


        }
        catch
        {

        }

        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }
}