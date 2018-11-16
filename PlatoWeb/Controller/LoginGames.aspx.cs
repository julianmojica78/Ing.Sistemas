using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using Newtonsoft.Json;

public partial class View_LoginGames : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        LUser user = new LUser();
        UUser emp = new UUser();
        UUsuario dato = new UUsuario();
        LUsuario luser = new LUsuario();
        try
        {
           SRGamesCol.Facebook_servideSoapClient etiqueta = new SRGamesCol.Facebook_servideSoapClient();

            SRGamesCol.ServiceToken seguridad = new SRGamesCol.ServiceToken()
            {
                sToken = "platoweb0pAy3jMuqHXIBV0H2y5v"

            };

            string sToken = etiqueta.AutenticacionCliente(seguridad);

            if (sToken.Equals("-1"))
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('Token invalido');</Script>");
                throw new Exception("token invalido");
            }
            seguridad.AutenticacionToken = sToken;

            DataSet login = etiqueta.loggin(seguridad, UserName.Text.ToString(), Password.Text.ToString());
            GridView1.DataSource = login;
            GridView1.DataBind();
            DataTable p = login.Tables[0];
            String da = JsonConvert.SerializeObject(login);
            emp = JsonConvert.DeserializeObject<UUser>(da);
            emp.Nombre = p.Rows[0]["nombre"].ToString();
            emp.Email = p.Rows[0]["correo"].ToString();
            emp.Clave = Password.Text.ToString();
            emp.User_name = UserName.Text.ToString();


            try
            {
                UUser usua = new UUser();
                LUser datas = new LUser();
                DataTable dat = user.verificarRes(emp.User_name);
                if (int.Parse(dat.Rows.Count.ToString()) > 0)
                {
                    emp.User_id = int.Parse(dat.Rows[0]["user_id"].ToString());
                    emp.User_name = dat.Rows[0]["user_name1"].ToString();
                    emp.Clave = dat.Rows[0]["clave"].ToString();
                    emp.Session = Session.SessionID;
                    emp.A = Session["men"].ToString();
                    emp.B = Session["men1"].ToString();
                    emp.C = Session["men2"].ToString();
                    emp.D = Session["men3"].ToString();

                    usua = user.logear(emp);
                    Session["nombre"] = (usua.User_name);
                    Session["name"] = (usua.User_name);
                    Session["user_id"] = (usua.UserId);
                    Response.Redirect(usua.Url);
                }
                else
                {
                    UEmpleados empl = new UEmpleados();
                    empl.Email = emp.Email;
                    empl.Nombre = emp.Nombre;
                    empl.Puntos = 0;
                    empl.Id_Rol = 4;
                    empl.User_Name1 = emp.User_name;
                    empl.Clave = emp.Clave;
                    empl.Rclave = emp.Clave;
                    empl.Sesiones = 0;
                    empl.Intentos = 0;
                    empl.Session = "a";
                    dato = datas.insertUsuario(empl);

                    DataTable datos = user.verificarRes(emp.User_name);
                    emp.User_id = int.Parse(datos.Rows[0]["user_id"].ToString());
                    emp.User_name = datos.Rows[0]["user_name1"].ToString();
                    emp.Clave = datos.Rows[0]["clave"].ToString();
                    emp.Session = Session.SessionID;
                    emp.A = Session["men"].ToString();
                    emp.B = Session["men1"].ToString();
                    emp.C = Session["men2"].ToString();
                    emp.D = Session["men3"].ToString();

                    usua = user.logear(emp);
                    Session["nombre"] = (usua.User_name);
                    Session["name"] = (usua.User_name);
                    Session["user_id"] = (usua.UserId);
                    Response.Redirect(usua.Url);

                }
            }
            catch
            {

            }

        }
        catch (Exception ex)
        {

            Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
        }
    }
}