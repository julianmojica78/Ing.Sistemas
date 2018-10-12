using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ReporteEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        try
        {
            UReportes reporte = ObtenerInforme();
            CRS_Empleados.ReportDocument.SetDataSource(reporte);
            CRV_Empleados.ReportSource = CRS_Empleados;
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected UReportes ObtenerInforme()
    {
        DataRow fila;  //dr
        DataTable informacion = new DataTable(); //dt

        L_Persistencia report = new L_Persistencia();
        UReportes datos = new UReportes();
        LUser persona = new LUser();

        DataTable inter = report.ToDataTable(report.obtenerReporteEmpleado());

        informacion = datos.Tables["Empleados"];

        DataTable intermedio = report.ToDataTable(report.obtenerReporteEmpleado());
        report.obtenerinformeE(inter, informacion);

        return datos;

    }
}