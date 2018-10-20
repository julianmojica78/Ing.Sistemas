using System;
using System.Web;
using Utilitarios;
using Logica;
using System.Collections;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Data;

public partial class View_ListarMesas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 13;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
   
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaListarmesas(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaListarmesas(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_listmesas.Text = com.A;
        BT_Nuevo.Text = com.B;
        BT_Modificar.Text = com.C;
        BT_Eliminar.Text = com.D;
        LB_buscar.Text = com.E;
        BT_Buscar.Text = com.F;
        GV_Mesas.Columns[1].HeaderText = com.G;

        GV_Mesas.Columns[2].HeaderText = com.H;

        GV_Mesas.Columns[3].HeaderText = com.I;

        //L_Precio2.Text = com.I;

        //L_Plato3.Text = com.J;
        //L_Detalle3.Text = com.K;
        //L_Precio3.Text = com.L;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarMesa.aspx");
    }

    protected void BT_Eliminar_Click1(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();
        Mesas mesas = new Mesas();
        L_Persistencia logica = new L_Persistencia();
        ClientScriptManager cm = this.ClientScript;

        mesas.Id_mesas = int.Parse(Session["id_mesa"].ToString());
        logica.BorrarMesa(mesas);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Eliminada Correctamente');window.location=\"ListarMesas.aspx\"</script>");

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        LUser dato = new LUser();
        Mesas datos = new Mesas();
        L_Persistencia data = new L_Persistencia();
        UUser user = new UUser();
        DataTable usuario;
        //String nombre = TB_Filtrar.Text.ToString();
        //datos.Nombre = nombre;
        //DataTable validez = dato.buscarcomen(datos.Nombre);

        //datos.X = int.Parse(validez.Rows[0]["id_comentarios"].ToString());
        //GV_Listar.DataSource = dato.buscarcomen(TB_Filtrar.Text.ToString());
        //GV_Listar.DataBind();
        String nombre = TB_Filtro.Text.ToString();

        try
        {
            DataTable validez = data.ToDataTable(data.buscarMesa(nombre));

            user.X= int.Parse(validez.Rows[0]["user_id"].ToString());


            GV_Mesas.DataSource = data.buscarMesa(nombre);
            GV_Mesas.DataBind();


        }
        catch
        {

        }
    }

    protected void GV_Empleados_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id_mesa"] = GV_Mesas.SelectedRow.Cells[1].Text;
        Session["descripcion"] = GV_Mesas.SelectedRow.Cells[2].Text;
        Session["ubicacion"] = GV_Mesas.SelectedRow.Cells[3].Text;
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevaMesa.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
}