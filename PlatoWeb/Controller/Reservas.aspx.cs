using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Collections;

public partial class View_Reservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 FORMULARIO = 39;
        LIdioma idioma = new LIdioma();
        UIdioma com = new UIdioma();
        int DDL = int.Parse(Session["ddl"].ToString());
        com = idioma.idiomaReserva(FORMULARIO, DDL);
        Hashtable compIdioma = new Hashtable();
        GV_Reserva.Columns[1].HeaderText = com.A;
        GV_Reserva.Columns[2].HeaderText = com.B;
        GV_Reserva.Columns[3].HeaderText = com.D;
        BT_Platos.Text = com.C;
        LB_reserT.Text = com.E;  
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["usuario"] = GV_Reserva.SelectedRow.Cells[1].Text;
        Session["mesa"] = GV_Reserva.SelectedRow.Cells[2].Text;
        Session["dia"] = GV_Reserva.SelectedRow.Cells[3].Text;

        String nombre = Session["usuario"].ToString();
        String mesa = Session["mesa"].ToString();
    }

    protected void BT_Platos_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuReserva.aspx");
    }
}