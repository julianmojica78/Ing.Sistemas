using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Data;
using System.Collections;
using System.Web;

public partial class View_Idioma : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 43;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        Int32 DDL;
        try
        {
            DDL = int.Parse(Session["ddl"].ToString());
        }
        catch
        {
            DDL = 1;
        }

        DataTable info = idioma.obtenerControl(FORMULARIO, DDL);
        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        compIdioma = idioma.hastableIdioma(info, compIdioma);
        LB_TIdioma.Text = compIdioma["LB_TIdioma"].ToString();
        LB_Idioma.Text = compIdioma["LB_Idioma"].ToString();
        LB_Controles.Text = compIdioma["LB_Controles"].ToString();
        LB_Nombre.Text = compIdioma["LB_Nombre"].ToString();
        LB_Terminacion.Text = compIdioma["LB_Terminacion"].ToString();
        BT_Agregarc.Text = compIdioma["BT_Agregarc"].ToString();
        BT_Agregar.Text = compIdioma["BT_Agregar"].ToString();
        BT_Eliminar.Text = compIdioma["BT_Eliminar"].ToString();
        //LB_Control.Text = compIdioma["LB_Control"].ToString();
        //LB_Texto.Text = compIdioma["LB_Texto"].ToString();
        BT_ModificarC.Text = compIdioma["BT_ModificarC"].ToString();
        LB_Formularios.Text = compIdioma["LB_Formularios"].ToString();
        GV_Idioma.Columns[1].HeaderText = compIdioma["Lb_nombre"].ToString();
        GV_Idioma.Columns[2].HeaderText = compIdioma["LB_Termina"].ToString();
        GV_Idioma.Columns[3].HeaderText = compIdioma["LB_Codigo"].ToString();
        GV_Formulario.Columns[1].HeaderText = compIdioma["LB_Nom"].ToString();
        GV_Formulario.Columns[2].HeaderText = compIdioma["LB_url"].ToString();
        GV_Formulario.Columns[3].HeaderText = compIdioma["LB_Id"].ToString();
        GV_Controles.Columns[1].HeaderText = compIdioma["LB_Control"].ToString();
        GV_Controles.Columns[2].HeaderText = compIdioma["LB_idIdioma"].ToString();
        GV_Controles.Columns[3].HeaderText = compIdioma["LB_idForm"].ToString();
        GV_Controles.Columns[4].HeaderText = compIdioma["LB_text"].ToString();
        GV_Controles.Columns[5].HeaderText = compIdioma["LB_iD"].ToString();
        Session["men"] = compIdioma["JS_agreIdio"].ToString();
        Session["men1"] = compIdioma["JS_eliIdio"].ToString();
        Session["men2"] = compIdioma["JS_eliIdio1"].ToString();
        Session["men3"] = compIdioma["JS_agreIdio1"].ToString();
        Session["men4"] = compIdioma["JS_Modi"].ToString();
    }


    protected void GV_Controles_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        LIdioma user = new LIdioma();

        try
        {
            Session["idioma"] = GV_Idioma.SelectedRow.Cells[0].Text;
            Session["formulario"] = GV_Formulario.SelectedRow.Cells[0].Text;


            Int32 idioma = int.Parse(Session["idioma"].ToString());
            Int32 formulario = int.Parse(Session["formulario"].ToString());
            DataTable datos = user.ToDataTable(user.listarcontroles(formulario,idioma));
        }
        catch
        {
            Session["control"] = GV_Controles.SelectedRow.Cells[1].Text;
            Session["idioma_id"] = GV_Controles.SelectedRow.Cells[2].Text;
            Session["formulario_id"] = GV_Controles.SelectedRow.Cells[3].Text;
            Session["texto"] = GV_Controles.SelectedRow.Cells[4].Text;
            Session["id"] = GV_Controles.SelectedRow.Cells[5].Text;

            LB_Control.Text = Session["control"].ToString();
            TB_Texto.Text = Session["texto"].ToString();

        }




    }

    protected void BT_Agregarc_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgregarControl.aspx");
    }

    protected void BT_ModificarC_Click(object sender, EventArgs e)
    {
        UControles user = new UControles();
        L_Persistencia datos = new L_Persistencia();
        UIdioma mensaje = new UIdioma();

        user.Texto = TB_Texto.Text.ToString();
        user.Id = int.Parse(Session["id"].ToString());
        user.Control = Session["control"].ToString();
        user.Idioma_id = int.Parse(Session["idioma_id"].ToString());
        user.Formulario_id = int.Parse(Session["formulario_id"].ToString());
        mensaje.Mensaje = Session["men4"].ToString();
        mensaje = datos.modificarIdioma(user, mensaje);
        this.RegisterStartupScript("mensaje", mensaje.Mensaje);
    }


    protected void BT_AgregarI_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgregarIdioma.aspx");
    }


    protected void BT_Agregar_Click(object sender, EventArgs e)
    {
        UAidioma user = new UAidioma();
         L_Persistencia datos = new L_Persistencia();
        //LIdioma datos = new LIdioma();
        UIdioma idioma = new UIdioma();

        user.Nombre = TB_Nombre.Text.ToString();
        user.Terminacion = TB_Terminacion.Text.ToString();
        idioma.Mensaje = Session["men"].ToString();
        idioma.A = Session["men3"].ToString();
        //idioma = datos.insertarIdioma(user,idioma);
        idioma = datos.insertarIdioma(user,idioma);

        this.RegisterStartupScript("mensaje", idioma.Mensaje);
    }


    protected void Eliminar_Click(object sender, EventArgs e)
    {

        UIdioma datos = new UIdioma();
        L_Persistencia user = new L_Persistencia();
        UAidioma idioma = new UAidioma();
        //LIdioma user = new LIdioma();
        ClientScriptManager cm = this.ClientScript;
        try
        {
            idioma.Id = int.Parse(Session["idioma"].ToString());
            idioma.Nombre = Session["nombre"].ToString();
            idioma.Terminacion = Session["terminacion"].ToString();
            datos.Mensaje = Session["men1"].ToString();
            datos.B = Session["men2"].ToString();
            datos = user.eliminarIdioma(idioma, datos);
            
            this.RegisterStartupScript("mensaje", datos.Mensaje);

        }
        catch
        {
            Session["ddl"] = 1;
        }

    }

    protected void GV_Idioma_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Session["idioma"] = GV_Idioma.SelectedRow.Cells[3].Text;
        Session["nombre"] = GV_Idioma.SelectedRow.Cells[1].Text;
        Session["terminacion"] = GV_Idioma.SelectedRow.Cells[2].Text;

    }
}