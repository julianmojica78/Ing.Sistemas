﻿using System;
using System.Data;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_Loggin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 16;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {

            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaLoggin(FORMULARIO, DDL);
        }
        catch
        {

            int DDL = 1;
            com = idioma.idiomaLoggin(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;
        LB_Login.Text = com.A;
        LB_username.Text = com.B;
        validator_username.Text = com.C;
        LB_pass.Text = com.D;
        LB_Recuperar.Text = com.E;
        B_Login.Text = com.F;
        B_Registrarse.Text = com.G;
        Session["men"] = com.H;
        Session["men1"] = com.I;
        Session["men2"] = com.J;
        Session["men3"] = com.K;
    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Generar_Token.aspx");
    }

    protected void B_Registrarse_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UUser datos = new UUser();
        LUser user = new LUser();

        datos.User_name = UserName.Text.ToString();
        datos.Clave = Password.Text.ToString();
        datos.Session = Session.SessionID;
        datos.A = Session["men"].ToString();
        datos.B = Session["men1"].ToString();
        datos.C = Session["men2"].ToString();
        datos.D = Session["men3"].ToString();
        try
        {
            DataTable registro = user.validarFecha(datos);
            if (int.Parse(registro.Rows[0]["id_usuario"].ToString()) > 0)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('" + datos.D.ToString() + "');window.location=\"Loggin.aspx\"</script>");

            }
            else
            {
                datos = user.logear(datos);
                Session["nombre"] = (datos.User_name);
                Session["user_id"] = (datos.UserId);
                Response.Redirect(datos.Url);
            }
        }
        catch
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", datos.Mensaje);
        }
    }
}