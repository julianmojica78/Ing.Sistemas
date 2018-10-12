using Utilitarios;
using Datos;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System;

namespace Logica
{
    public class L_Persistencia
    {
        public UUser insertarmesas(Mesas mesas)
        {
            DAOMesas dao = new DAOMesas();
            dao.insertMesa(mesas);
            UUser user = new UUser();
            return user;
        }
        public UUser actualizarMesas(Mesas mesas)
        {
            DAOMesas dao = new DAOMesas();
            dao.actualizarMesas(mesas);
            UUser user = new UUser();
            return user;
        }
        public UUser BorrarMesa(Mesas mesas)
        {
            DAOMesas dao = new DAOMesas();
            dao.borrarMesa(mesas);
            UUser user = new UUser();
            return user;
        }

        public UIdioma insertarIdioma(UAidioma idiomas ,UIdioma idioma)
        {
            UIdioma user = new UIdioma();
            Idioma data = new Idioma();
            

            System.Data.DataTable validez = data.validarIdioma(idiomas);
            if (int.Parse(validez.Rows[0]["id"].ToString()) > 0)
            {
                data.insertIdioma(idiomas);
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
                user.Mensaje = "<script type='text/javascript'>alert('" + idioma.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('" + idioma.A.ToString() + "');</script>";
            }

            return user;

        }

        public List<UAidioma> obtenerIdioma()
        {
            Idioma dao = new Idioma();
            return dao.listarIdioma();
        }

        public UIdioma modificarIdioma(UControles idioma, UIdioma mensaje)
        {
            Idioma dao = new Idioma();
            UIdioma user = new UIdioma();
            dao.modificarIdioma(idioma);
            user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";


            return user;

        }
        public UIdioma eliminarIdioma(UAidioma datos, UIdioma idioma)
        {
            Idioma data = new Idioma();
            UIdioma dato = new UIdioma();

            if (idioma.Id != 1)
            {
                data.eliminarIdiomas(datos);
                dato.Mensaje = "<script type='text/javascript'>alert('" + idioma.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            }
            else
            {
                dato.Mensaje = "<script type='text/javascript'>alert('" + idioma.B.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            }

            return dato;

        }
        public UuserCrear insertarmenu(Menu menu)
        {
            DUser dao = new DUser();
            dao.insertMenu(menu);
            UuserCrear user = new UuserCrear();
            return user;
        }
        public UuserCrear actualizarMenu(Menu menu)
        {
            DUser dao = new DUser();
            dao.actualizarMenu(menu);
            UuserCrear user = new UuserCrear();
            return user;
        }
        public UuserCrear BorrarMenu(Menu menu)
        {
            DUser dao = new DUser();
            dao.borrarMenu(menu);
            UuserCrear user = new UuserCrear();
            return user;
        }
        public List<Menu> obtenerMenu()
        {
            DUser dao = new DUser();
            return dao.listarMenu();
        }

        public UUsuario insertarcomentario(UComentarios comentario ,UUsuario mensaje)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();

            dao.insertComentario(comentario);
            user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"Inicio.aspx\"</script>";

            return user;
        }

        public List<ULcomentarios> obtenerComentario()
        {
            DUser dao = new DUser();
            return dao.listarComentarios();
        }

        public List<UUse> obtenerReporteEmpleado()
        {
            DUser dao = new DUser();
            return dao.listarEmpleados();
        }

        public List<UInformeRe> obtenerReporteReserva()
        {
            DUser dao = new DUser();
            return dao.listarReservas();
        }

        public List<UInformeVe> obtenerReporteVentas()
        {
            DUser dao = new DUser();
            return dao.listarVentas();
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public DataTable obtenerinformeE(DataTable inter, DataTable informacion)
        {

            DataRow fila;  //dr
            DUser usuario = new DUser();
            
            for (int i = 0; i < inter.Rows.Count; i++)
            {
                fila = informacion.NewRow();

                fila["Nombre"] = inter.Rows[i]["nombre"].ToString();
                fila["Apellido"] = inter.Rows[i]["apellido"].ToString();
                fila["Correo"] = inter.Rows[i]["correo"].ToString();
                fila["Cedula"] = inter.Rows[i]["cedula"].ToString();
                fila["Rol"] = inter.Rows[i]["rol"].ToString();
                //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

                informacion.Rows.Add(fila);
            }

            return informacion;
        }

        public DataTable obtenerinformeR(DataTable inter, DataTable informacion)
        {
            DataRow fila;
            UReportes datos = new UReportes();

            informacion = datos.Tables["Reservas"];
            DUser usuario = new DUser();


            for (int i = 0; i < inter.Rows.Count; i++)
            {
                fila = informacion.NewRow();

                fila["Reserva"] = int.Parse(inter.Rows[i]["id_reserva"].ToString());
                fila["Usuario"] = inter.Rows[i]["user_name"].ToString();
                fila["Dia"] = inter.Rows[i]["dia"].ToString();
                //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

                informacion.Rows.Add(fila);
            }

            return informacion;
        }
        public UReportes obtenerinfomeV(DataTable inter, DataTable informacion)
        {
            DataRow fila;  //dr
            UReportes datos = new UReportes();

            informacion = datos.Tables["Pedido"];
            DUser usuario = new DUser();


            for (int i = 0; i < inter.Rows.Count; i++)
            {
                fila = informacion.NewRow();

                fila["Pedido"] = int.Parse(inter.Rows[i]["id_pedido"].ToString());
                fila["Nombre"] = inter.Rows[i]["nombre"].ToString();
                fila["Cantidad"] = int.Parse(inter.Rows[i]["cantidad"].ToString());
                fila["Fecha ingreso"] = inter.Rows[i]["fecha_ingreso"].ToString();
                fila["Fecha despacho"] = inter.Rows[i]["fecha_despacho"].ToString();
                fila["Precio"] = inter.Rows[i]["precio"].ToString();
                informacion.Rows.Add(fila);
            }

            return datos;
        }
        public UContacto insertarcontacto(UContacto contacto)
        {
            DUser dao = new DUser();
            dao.insertarContacto(contacto);
            UContacto user = new UContacto();
            return user;
        }
        public List<Menu> listadeMenu()
        {
            DUser dao = new DUser();
            return dao.listarPlatos();
        }
        public List<UReservation> listadeReservas(Int32 id)
        {
            DUser dao = new DUser();
            return dao.listadodeReservas(id);
        }
        public List<UUsuario> listadePuntos(Int32 id)
        {
            DUser dao = new DUser();
            return dao.listadodePuntos(id);
        }
        public List<ULclientes> listadeClientes()
        {
            DUser dao = new DUser();
            return dao.listadodeClientes();
        }
        public List<UuserPedido> obtenPedido(int user_id)
        {
            DUser dao = new DUser();
            return dao.ObtenerPedidos(user_id);
        }
        public UPedido insertarPedido(UPedido pedido)
        {
            DUser dao = new DUser();
            dao.insertPedido(pedido);
            UPedido user = new UPedido();
            return user;
        }
        public UuserPedido guardarUbicacion(UuserPedido pedido)
        {
            DUser dao = new DUser();
            dao.insertUbicacion(pedido);
            UuserPedido user = new UuserPedido();
            return user;
        }
        public List<UOtenerRe> obtenRe()
        {
            DUser dao = new DUser();
            return dao.ObtenerRes();
        }
        public UPreserva insertarPlatoR(UPreserva pedido)
        {
            DUser dao = new DUser();
            dao.insertPedidoRe(pedido);
            UPreserva user = new UPreserva();
            return user;
        }
        public List<ULReserva> ListReserva()
        {
            DUser dao = new DUser();
            return dao.listarResr();
        }
    }
}
