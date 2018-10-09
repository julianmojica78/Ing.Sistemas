using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Data;
using System.Web;
using System.Collections;

public partial class View_ModificarMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Int32 FORMULARIO = 27;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaModificarmenu(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_modimeni.Text = com.A;
        LB_nompla.Text = com.B;
        REV_nombre.Text = com.C;
        LB_desc.Text = com.D;
        REV_desc.Text = com.E;
        LB_preciopla.Text = com.F;
        validator_precio.Text = com.G;
        LB_imagen.Text = com.H;
        //FU_imagen. = com.I;
        B_Modificar.Text = com.J;

        Session["men"] = com.K;
        Session["men1"] = com.L;
        Session["men2"] = com.M;


        UuserCrear datos = new UuserCrear();
        datos.Ispos = IsPostBack;
        LUser user = new LUser();
        LUser ins = new LUser();

        UUser info = new UUser();
        {
            ClientScriptManager cm = this.ClientScript;
        }
    }
    protected void B_Modificar_Click(object sender, EventArgs e)
    {
        UuserCrear data = new UuserCrear();
        data.Ispos = IsPostBack;
        LUser user = new LUser();
        LUser ins = new LUser();

        L_Persistencia logica = new L_Persistencia();
        Utilitarios.Menu menu = new Utilitarios.Menu();
        //user.ispost1(data);
        UUser info = new UUser();

        info.Ruta = (FU_imagen.PostedFile.FileName);
        data.Imagen = cargarImagen();


        //user.ispost1(data);
        String nombre = Session["nombrep"].ToString();
        DataTable validez1 = user.obtenerMesa(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_plato"].ToString());
        menu.Id_plato = User_id;
        menu.Nombre = TB_nompla.Text;
        //data.B = Session["nombre"].ToString();
        menu.Descripcion = TB_desc.Text;
        //data.D = Session["descripcion"].ToString();
        menu.Precio = TB_precio.Text;
        //data.F = Session["precio"].ToString();
        //data.Ispos = prueba(info);
        //ins.aux1(data);
        data = logica.actualizarMenu(menu);
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

            enca.Ubicacion = enca.Ubicacion;

            FU_imagen.PostedFile.SaveAs(enca.Ubicacion);

            String mens = Session["men"].ToString();
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + mens.ToString() + "');window.location=\"ListadePlatos.aspx\"</script>");


        }
        catch
        {

            enca.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;
            //mensaje = user.cargaImage(enca,extension);
            //enca.Ubicacion = mensaje.B;
            nombreArchivo = mensaje.Ubicacion;
            cm.RegisterClientScriptBlock(this.GetType(), "", mensaje.Url);

        }

        return "~\\Imagen" + "\\" + nombreArchivo;
    }
    //public Boolean prueba(Uuser info)
    //{
    //    Luser datos = new Luser();
    //    info = datos.cargaImage(info);
    //    return info.Ispos;
    //}





    protected void TB_codigo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TB_imagen_TextChanged(object sender, EventArgs e)
    {

    }
}
