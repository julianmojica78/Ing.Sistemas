using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;
using System.Data;

public partial class View_Contactenos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 3;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {

            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaContacto(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaContacto(FORMULARIO, DDL);
        }
        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        L_title.Text = com.A;
        LB_Nombre.Text = com.B;
        LB_Email.Text = com.C;
        LB_Telefono.Text = com.D;
        LB_Detalle.Text = com.E;
        BT_Enviar.Text = com.F;
        Session["men"] = com.G;


    }

    protected void BT_Enviar_Click1(object sender, EventArgs e)
    {
        UUser dato = new UUser();
        LUser contacto = new LUser();
        L_Persistencia logica = new L_Persistencia();
        UContacto menu = new UContacto();
        menu.Nombre = TB_Nombre.Text.ToString();
        menu.Telefono = TB_Telefono.Text.ToString();
        menu.Email = TB_Email.Text.ToString();
        menu.Detalle = TB_Detalle.Text.ToString();
        menu = logica.insertarcontacto(menu);
        ClientScriptManager cm = this.ClientScript;
        //dato = contacto.contactenos(TB_Nombre.Text, TB_Telefono.Text, TB_Email.Text, TB_Detalle.Text);
        String mens = Session["men"].ToString();
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"Inicio.aspx\"</script>");

        DataTable regis = contacto.ToDataTable(contacto.obtenerAcontacto());
        String esquema = "usuario";
        String tabla = "contacto";
        String pk = "1";
        String session = Session.SessionID;
        contacto.insert(regis, esquema, tabla, pk, session);
        //this.Page.Response.Write(mens);
    }

    protected void BT_consumo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsumirContactenos.aspx");
    }
}