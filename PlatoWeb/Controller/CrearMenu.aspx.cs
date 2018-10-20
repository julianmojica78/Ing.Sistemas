using System;
using System.Web;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Linq;
using System.Collections;

public partial class View_CrearMenu : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        Int32 FORMULARIO = 4;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
       
        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaCreamenu(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaCreamenu(FORMULARIO, DDL);
        }
        

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        L_insertmenu.Text = com.A;
        LB_nompla.Text = com.B;
        LB_desc.Text = com.C;
        LB_precio.Text = com.D;
        LB_seleccionar.Text = com.E;
        B_guardar.Text = com.F;
        Session["men"] = com.G;
    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserCrear datos = new UuserCrear();
        LMenu ins = new LMenu();
        UUser info = new UUser();
        L_Persistencia logica = new L_Persistencia();
        Menu menu = new Menu();

        menu.Nombre = TB_nompla.Text.ToString();
        menu.Descripcion = TB_desc.Text.ToString();
        menu.Precio = TB_precio.Text.ToString();
        info.Ruta = (FU_imagen.PostedFile.FileName);
        menu.Imagen = cargarImagen();

        datos = logica.insertarmenu(menu);
        //ins.insertmenu(datos);

    }

    protected String cargarImagen()
    {
        UUser enca = new UUser();
        LMenu user = new LMenu();
        ClientScriptManager cm = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileName(FU_imagen.PostedFile.FileName);
        enca.A = System.IO.Path.GetExtension(FU_imagen.PostedFile.FileName);



        UUser mensaje = new UUser();
        try
        {

            enca.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;
            mensaje = user.CargaImagen(enca);
            //cm.RegisterClientScriptBlock(this.GetType(), "", mensaje.Url);

            enca.Ubicacion = mensaje.Ubicacion;

            FU_imagen.PostedFile.SaveAs(enca.Ubicacion);
            String mens = Session["men"].ToString();
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"ListadePlatos.aspx\"</script>");


        }
        catch
        {
            enca.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;
            //mensaje = user.cargaImage();
            //enca.Ubicacion = mensaje.B;
            nombreArchivo = mensaje.Ubicacion;
            cm.RegisterClientScriptBlock(this.GetType(), "", mensaje.Url);

        }

        return "~\\Imagen" + "\\" + nombreArchivo;
    }
}