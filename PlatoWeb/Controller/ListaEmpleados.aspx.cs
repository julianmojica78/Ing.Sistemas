using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_ListaEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        Int32 FORMULARIO = 11;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
       

        try
        {
            int DDL = int.Parse(Session["ddl"].ToString());
            com = idioma.idiomaListaempleados(FORMULARIO, DDL);
        }
        catch
        {
            int DDL = 1;
            com = idioma.idiomaListaempleados(FORMULARIO, DDL);
        }

        Hashtable compIdioma = new Hashtable();
        Session["mensajes"] = compIdioma;

        //for (int i = 0; i < info.Rows.Count; i++)
        //{
        //    compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
        //}
        LB_listEmple.Text = com.A;
        BT_Nuevo.Text = com.B;
        BT_Modificar.Text = com.C;
        BT_Eliminar.Text = com.D;
        LB_buscar.Text = com.E;
        BT_Buscar.Text = com.F;
        validator_username.Text = com.G;
        RFV_alerta.Text = com.H;
        GV_Empleados.Columns[2].HeaderText = com.I;
        GV_Empleados.Columns[3].HeaderText = com.J;
        GV_Empleados.Columns[4].HeaderText = com.K;
        GV_Empleados.Columns[5].HeaderText = com.L;
        GV_Empleados.Columns[6].HeaderText = com.M;
        GV_Empleados.Columns[7].HeaderText = com.N;
        GV_Empleados.Columns[8].HeaderText = com.O;
        GV_Empleados.Columns[9].HeaderText = com.P;
        Session["eliminar"] = com.Q;
        Session["men1"] = com.R;
        Session["men2"] = com.S;
        Session["buscaremp"] = com.S;



        LUsuario dato = new LUsuario();
        GV_Empleados.DataSource = dato.obtenerEmpleados();
        GV_Empleados.DataBind();
        //}
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroEmpleados.aspx");
    }

    protected void GV_Empleados_SelectedIndexChanged(object sender, EventArgs e)
    {
        UUsuario user = new UUsuario();
        Session["nombre"] = GV_Empleados.SelectedRow.Cells[7].Text;


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarEmpleado.aspx");
    }



    protected void BT_Eliminar_Click1(object sender, EventArgs e)
    {
        UUsuario data = new UUsuario();
        UEmpleados datos = new UEmpleados();
        LUser user = new LUser();
        LUsuario eliminar = new LUsuario();
        ClientScriptManager cm = this.ClientScript;
        string nombre = Session["nombre"].ToString();
        data = user.ObtenerIds(nombre);
        datos.Nombre = data.Nombre;
        datos.Apellido = data.Apellido;
        datos.Email = data.Email;
        datos.Telefono = data.Telefono;
        datos.Cedula = data.Cedula;
        datos.User_Name1 = data.User_Name1;
        datos.Clave = data.Clave;
        datos.User_id = (data.User_id);
        data.Mensaje = Session["eliminar"].ToString();
        data.A = Session["men1"].ToString();
        data.B = Session["men2"].ToString();
        DataTable regis = user.ToDataTable(user.obtenerModiA(nombre));
        String esquema = "usuario";
        String tabla = "usuario";
        String pk = Session["user_id"].ToString();
        String session = Session.SessionID;
        user.delete(regis, esquema, tabla, pk, session);
        data = eliminar.eliminarUsuario(datos,data);
        this.RegisterStartupScript("mensaje", data.Mensaje);


    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
        //DAOUsuario dato = new DAOUsuario();
        //DataTable datos = dato.buscarEmpleados(TB_Filtro.Text.ToString());


        //GV_Resultado.DataSource = datos;
        //GV_Resultado.DataBind();

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {

        L_Persistencia dato = new L_Persistencia();
        UUser datos = new UUser();
        ClientScriptManager cm = this.ClientScript;

        String nombre = TB_Filtro.Text.ToString();

        try
        {
            DataTable validez = dato.ToDataTable(dato.buscarEmpleado(nombre));

            datos.X = int.Parse(validez.Rows[0]["user_id"].ToString());

            GV_Empleados.DataSource = dato.buscarEmpleado(nombre);
            GV_Empleados.DataBind();

        }
        catch
        {
            //usuario = dato.BuscarEmpleado(datos);
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('" + Session["buscaremp"].ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>");


        }

    }

    protected void GV_Resultado_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BT_consumo_Click(object sender, EventArgs e)
    {
        Response.Redirect("TopAspirantes.aspx");
    }
}