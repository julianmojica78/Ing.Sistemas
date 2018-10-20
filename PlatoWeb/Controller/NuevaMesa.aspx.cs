using System;
using System.Web;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_NuevaMesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 34;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
       

        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaNuevamesa(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaNuevamesa(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_nuevamesa.Text = com.A;
        LB_cantper.Text = com.B;
        RFV_numeros.Text = com.C;
        LB_ubi.Text = com.D;
        RFV_ubi.Text = com.E;
        BT_Nuevo.Text = com.F;
        Session["men"] = com.G;
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();
        ClientScriptManager cm = this.ClientScript;
        L_Persistencia logica = new L_Persistencia();
        Mesas mesas = new Mesas();
        mesas.Cantidad = int.Parse(TB_Cantidad.Text.ToString());
        mesas.Ubicacion = TB_Ubicacion.Text.ToString();
        datos = logica.insertarmesas(mesas);
        //logica.insertarmesas(mesas);

        //user.insertmesa(datos);
        String mens = Session["men"].ToString();
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"ListarMesas.aspx\"</script>");

    }
}