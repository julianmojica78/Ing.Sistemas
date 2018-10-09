using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_Resrvas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Int32 FORMULARIO = 40;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {

            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaResrvas(FORMULARIO, DDL);
        }
        catch
        {

            int DDL = 1;
            com = idioma.idiomaResrvas(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        L_Reservas.Text = com.A;
        L_Fecha.Text = com.B;
        L_Hora.Text = com.C;
        L_Cantidad.Text = com.D;
        B_Reservar.Text = com.E;
        BT_MReservas.Text = com.F;
        REV_Fecha.Text = com.G;
        RV_Hora.Text = com.H;
        RV_Cantidad.Text = com.I;
        Session["men"] = com.J;
        Session["men1"] = com.K;
        Session["men2"] = com.L;
        Session["men3"] = com.M;

        Estado est = new Estado();
        UUser datos = new UUser();
        LUser user = new LUser();

        try
        {
            datos.User_name = Session["nombre"].ToString();
            est = user.estado(datos);
            BT_MReservas.Visible = est.Esstado;

        }
        catch
        {
            est = user.estado(datos);
            BT_MReservas.Visible = est.Esstado;

        }
        //if (Session["nombre"] == null)
        //{
        //    BT_MReservas.Visible = false;
        //}
        //else
        //{
        //    BT_MReservas.Visible = true;
        //}
    }

    protected void DDL_Cantp_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void obtenerUser()
    {
    }
   

    protected void Button8_Click(object sender, EventArgs e)
    {
        UReserva datos = new UReserva();
        UReservation dato = new UReservation();
        LUser user = new LUser();


        
        dato.Dia = TB_Fecha.Text.ToString() + ' ' + int.Parse(DDL_Hora.SelectedItem.ToString()) + ":00";
        dato.Id_mesa = int.Parse(DDL_Cantp.SelectedValue.ToString());
        datos.A = Session["men"].ToString();
        datos.B = Session["men1"].ToString();
        datos.C = Session["men2"].ToString();
        datos.D = Session["men3"].ToString();
        try
        {
            dato.Id_usuario = int.Parse(Session["user_id"].ToString());
            datos.Nombre = Session["nombre"].ToString();

            datos = user.Reserva(datos, dato);
            this.RegisterStartupScript("mensaje", datos.Mensaje);
        }
        catch
        {
            datos = user.Reserva(datos,dato);
            this.RegisterStartupScript("mensaje", datos.Mensaje);
        }


    }     


    protected void BT_MReservas_Click(object sender, EventArgs e)
    {
        Response.Redirect("CanjePuntos.aspx");
 
            }
}
