using System;
using System.Collections;
using Logica;

using Utilitarios;

public partial class View_Recuperar_contraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        Int32 FORMULARIO = 32;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaRecuperar_contraseña(FORMULARIO, DDL);

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_recucontra.Text = com.A;
        LB_newpas.Text = com.B;
        LB_Rnewpas.Text = com.C;
        CV_veri.Text = com.D;
        Guardar_new_pass.Text = com.E;
        Session["men"] = com.F;



        LUser recu = new LUser();
        Response.Cache.SetNoStore();
        int x = Request.QueryString.Count;
        string y = Request.QueryString[0];
        Session["user_id"] = recu.Recuperar(x, y);

    }

    protected void Guardar_new_pass_Click(object sender, EventArgs e)
    {
        LUser user = new LUser();
        UUserToken datos = new UUserToken();
        int x = int.Parse(Session["user_id"].ToString());
        string y = TB_newPass.Text;
        datos.Session = Session["men"].ToString();
        user.guardarcontra(x, y);


    }
}