using System;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_Generar_Token : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 6;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        try
        {

            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaGenerartoken(FORMULARIO, DDL);
        }
        catch
        {

            int DDL = 1;
            com = idioma.idiomaGenerartoken(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_recuperar.Text = com.A;
        LB_nombre.Text = com.B;
        L_Mensaje.Text = com.C;
        Session["men"] = com.D;
        Session["men1"] = com.E;
        Session["men2"] = com.F;
    }

    protected void Aceptar_Click(object sender, EventArgs e)
    {
        LUser Lau = new LUser();
        UUserToken user = new UUserToken();

        user = Lau.GenerarToken(TB_generar_token.Text);
        L_Mensaje.Text = (user.Mensaje);
        user.Session = Session["men"].ToString();
        user.Session = Session["men1"].ToString();
        user.Session = Session["men2"].ToString();
        this.RegisterStartupScript("mensaje", user.Url);


    }
}