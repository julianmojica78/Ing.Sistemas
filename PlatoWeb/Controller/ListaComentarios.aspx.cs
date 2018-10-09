using System;
using System.Web;
using Logica;
using Utilitarios;
using System.Data;
using System.Collections;
using System.Web.UI.WebControls;

public partial class View_ListaComentarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 9;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaComentarios(FORMULARIO, DDL);

        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaComentarios(FORMULARIO, DDL);

        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        lb_listComen.Text = com.A;
        LB_buscar.Text = com.B;
        BT_Buscar.Text = com.C;
        validator_username.Text = com.D;
        RFV_alerta.Text = com.E;

        GV_Listar.Columns[1].HeaderText = com.F;
        GV_Listar.Columns[2].HeaderText = com.G;




        //L_Persistencia dato = new L_Persistencia();
        //GV_Listar.DataSource = dato.obtenerComentario();
        //GV_Listar.DataBind();
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
    }

    protected void TB_Filtrar_TextChanged(object sender, EventArgs e)
    {
        LUser dato = new LUser();
        UUser datos = new UUser();
        String nombre = TB_Filtrar.Text.ToString();
        datos.Nombre = nombre;
        DataTable validez = dato.buscarcomen(datos.Nombre);

            datos.X = int.Parse(validez.Rows[0]["id_comentarios"].ToString());        
            GV_Listar.DataSource = dato.buscarcomen(TB_Filtrar.Text.ToString());
            GV_Listar.DataBind();
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}