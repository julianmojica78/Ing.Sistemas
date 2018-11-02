using System;
using System.Data;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Collections;
using ASPSnippets.GoogleAPI;
using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Facebook;

public partial class View_Loggin : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 16;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        LUser user = new LUser();
        UUser emp = new UUser();
        UUsuario dato = new UUsuario();
        LUsuario luser = new LUsuario();
       

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


        GoogleConnect.ClientId = "326076519225-vg67uko89vu71hcetltti24jsvbenk33.apps.googleusercontent.com";
        GoogleConnect.ClientSecret = "MMHhqYJwIWXP4Bz_eAthOto9";
        GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

        if (!string.IsNullOrEmpty(Request.QueryString["code"]))
        {
            try
            {
                string code = Request.QueryString["code"];
                string json = GoogleConnect.Fetch("me", code);
                GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);
                Session["xD"] = profile.Id;
                Session["usuario"] = profile.DisplayName;
                Session["correo"] = profile.Emails.Find(email => email.Type == "account").Value;
                Session["band"] = true;

                //Image1.ImageUrl = profile.Im/ImageButton1.Visible = false;

                try
                {
                    String correo = Session["correo"].ToString();
                    DataTable data = user.verificarRegistro(correo);
                    emp.User_id = int.Parse(data.Rows[0]["user_id"].ToString());
                    emp.User_Name1 = data.Rows[0]["user_name"].ToString();
                    emp.Clave = data.Rows[0]["clave"].ToString();

                    user.logear(emp);


                }
                catch
                {
                    Response.Redirect("Registro.aspx");
                }
            }
            catch
            {

            }

        }
        FaceBookConnect.API_Key = "196078794611552";
        FaceBookConnect.API_Secret = "fb201e558813c89209c150c723cb9b99";
        if (!IsPostBack)
        {

            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Acceso no permitido.')", true);
                return;
            }

            string cod = Request.QueryString["code"];
            if (!string.IsNullOrEmpty(cod))
            {
                ViewState["code"] = cod;

                try
                {
                    string data = FaceBookConnect.Fetch(cod, "me?fields=id,name,email");
                    FacebookService facebookuser = new JavaScriptSerializer().Deserialize<FacebookService>(data);
                    facebookuser.PictureUrl = string.Format("http://graph.facebook.com/{0}/picture", facebookuser.Id);
                    //pnlFaceBookUser.Visible = true;
                    //LB_.Text = facebookuser.Id;
                    Session["user_name"] = facebookuser.Name;
                    Session["correo"] = facebookuser.Email;
                    Session["band"] = true;
                    //profileImage.ImageUrl = facebookuser.PictureUrl;
                    B_Login.Enabled = false;


                    UUser usua = new UUser();
                    LUser datas = new LUser();

                    string a = Session.SessionID;
                    try
                    {
                        String correo = Session["correo"].ToString();
                        DataTable dat = user.verificarRegistro(correo);
                        emp.User_id = int.Parse(dat.Rows[0]["user_id"].ToString());
                        emp.User_Name1 = dat.Rows[0]["user_name1"].ToString();
                        emp.Clave = dat.Rows[0]["clave"].ToString();

                        user.logear(emp);

                    }
                    catch
                    {
                        Response.Redirect("Registro.aspx");
                    }
                }
                catch
                {

                }
            }



        }
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
                Session["name"]= (datos.User_name);
                Session["user_id"] = (datos.UserId);
                Response.Redirect(datos.Url);
            }
        }
        catch
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", datos.Mensaje);
        }
    }

    public class GoogleProfile
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public Image Image { get; set; }
        public List<Email> Emails { get; set; }
        public string Gender { get; set; }
        public string ObjectType { get; set; }
    }

    public class Email
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
    }


    protected void B_Ingresar_Gmail_Click(object sender, EventArgs e)
    {
        GoogleConnect.Authorize("profile", "email");
    }

    protected void B_Facebook_Click(object sender, EventArgs e)
    {
        FaceBookConnect.Authorize("user_photos,email", Request.Url.AbsoluteUri.Split('?')[0]);
    }
}