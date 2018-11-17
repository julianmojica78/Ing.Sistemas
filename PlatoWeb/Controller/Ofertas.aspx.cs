using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using Logica;
using Utilitarios;

public partial class View_Ofertas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {

        UuserCrear datos = new UuserCrear();
        LMenu ins = new LMenu();
        UUser info = new UUser();
        L_Persistencia logica = new L_Persistencia();
        Ofertas menu = new Ofertas();
        LUser user = new LUser();

        menu.Nombre = TB_nompla.Text.ToString();
        menu.Descripcion = TB_desc.Text.ToString();
        menu.Precio = TB_precio.Text.ToString();
        menu.Oferta = TB_precioOferta.Text.ToString();
        info.Ruta = (FU_imagen.PostedFile.FileName);
        menu.Imagen = cargarImagen();

        datos = logica.insertaroferta(menu);

        DataTable regis = user.ToDataTable(user.obtenerOfertas());
        String esquema = "usuario";
        String tabla = "ofertas";
        String pk = Session["user_id"].ToString();
        String session = Session.SessionID;
        user.insert(regis, esquema, tabla, pk, session);
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
            mensaje = user.CargaImg(enca);
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