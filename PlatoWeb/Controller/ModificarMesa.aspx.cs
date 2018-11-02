using System;
using System.Web;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;
using System.Data;

public partial class View_ModificarMesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 28;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();


        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaModificarmesa(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaModificarmesa(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_modimesa.Text = com.A;
        LB_codimesa.Text = com.B;
        LB_cantper.Text = com.C;
        LB_ubi.Text = com.D;
        BT_Modificar.Text = com.E;
        Session["men"] = com.F;


        UUser datos = new UUser();
        datos.Ispos = IsPostBack;
        LUser info = new LUser();
        //TB_id_mesa.Text = Session["id_mesa"].ToString();
        //TB_Cantidad.Text = Session["descripcion"].ToString();
        //TB_Ubicacion.Text = Session["ubicacion"].ToString();

        info.ispost(datos);
        { 
            ClientScriptManager cm = this.ClientScript;
            datos.A = TB_id_mesa.Text;
            datos.B = Session["id_mesa"].ToString();
            datos.C = TB_Cantidad.Text;
            datos.D = Session["descripcion"].ToString();
            datos.E = TB_Ubicacion.Text;
            datos.F = Session["ubicacion"].ToString();
        }



        

    }

        protected void BT_Modificar_Click(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();
        ClientScriptManager cm = this.ClientScript;
        L_Persistencia logica = new L_Persistencia();
        Mesas mesas = new Mesas();
        mesas.Id_mesas = int.Parse(Session["id_mesa"].ToString());
        mesas.Cantidad = int.Parse(TB_Cantidad.Text.ToString());
        mesas.Ubicacion = TB_Ubicacion.Text.ToString();
        Int32 nombre = mesas.Id_mesas;
        DataTable regis = user.ToDataTable(user.obtenerMes(nombre));
        String esquema = "usuario";
        String tabla = "mesas";
        String pk = Session["user_id"].ToString();
        String session = Session.SessionID;
        datos = logica.actualizarMesas(mesas);
        user.updateMesas(regis, mesas, esquema, tabla, pk, session);
        //logica.actualizarMesas(mesas);



        //user.mofifimesas(datos);
        String mens = Session["men"].ToString();
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"ListarMesas.aspx\"</script>");

    }
}