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

            if (datos.Id != 1)
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
            user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"InicioCliente.aspx\"</script>";

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
                //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

                informacion.Rows.Add(fila);
            }

            return datos;
        }

        public List<UPedido> obtenerPedido()
        {
            DUser dao = new DUser();
            return dao.listarPedidos();
        }

        public List<Menu> buscarPlatos(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarPlatos(nombre);
        }

        public List<UUse> buscarEmpleado(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarEmpleado(nombre);
        }
        public List<ULclientes> buscarCliente(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarCliente(nombre);
        }
        public List<ULcomentarios> buscarComen(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarComent(nombre);
        }
        public List<ULReserva> buscarReserva(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarReservas(nombre);
        }
        public List<Mesas> buscarMesa(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarMesa(nombre);
        }

        public List<UPedido> buscarVentas(String nombre)
        {
            DUser dao = new DUser();
            return dao.buscarVentas(nombre);
        }

        public List<Mesas> obtenerMesas()
        {
            DAOMesas dao = new DAOMesas();
            return dao.obtenerMesar();
        }
        public List<UCocinero> listarCocinero()
        {
            DUser dao = new DUser();
            List<UCocinero> lista = new List<UCocinero>();
            lista = dao.listarCocinero();
            return lista;
        }
        public List<UCocinero1> listarCocinero1()
        {
            DUser dao = new DUser();
            return dao.listarCocinero1();
        }

        public DataTable listarPla(Int32 id_pedido)
        {
            DUser dao = new DUser();
            return ToDataTable(dao.listarPlatos(id_pedido));
        }

        public List<UPlatos> listarPlatos(Int32 id_pedido)
        {
            DUser dao = new DUser();
            return dao.listarPlatos(id_pedido);
        }
        public List<UPlatos1> listarPlatos1(Int32 id_pedido)
        {
            DUser dao = new DUser();
            return dao.listarPlatos1(id_pedido);
        }

        public UDespachos actualizardespacho(UPedidoplato reserva)
        {
            DUser dao = new DUser();
            UPedidoplato datos = new UPedidoplato();
            System.Data.DataTable validez1 = ToDataTable(dao.obtenerPedido(reserva));
            datos.Id = int.Parse(validez1.Rows[0]["id"].ToString());
            datos.Id_pedido = int.Parse(validez1.Rows[0]["id_pedido"].ToString());
            datos.Id_plato = int.Parse(validez1.Rows[0]["id_plato"].ToString());
            datos.Cantidad = int.Parse(validez1.Rows[0]["cantidad"].ToString());
            datos.Fecha_ingreso = DateTime.Parse(validez1.Rows[0]["fecha_ingreso"].ToString());
            datos.Fecha_despacho = DateTime.Now;

            dao.actualizarDespachos(datos);
            UDespachos desp = new UDespachos();

            desp.Url = "Despachos.aspx";
            return desp;
        }

        public UDespachos actualizardespacho1(UPreserva reserva)
        {
            DUser dao = new DUser();
            dao.actualizarDespachos1(reserva);
            UDespachos desp = new UDespachos();

            desp.Url = "Despachos.aspx";

            return desp;
        }

        public UReserva pago(UReservation datos , UReserva mensaje)
        {
            DUser user = new DUser();
            UReserva data = new UReserva();
            UTokenRe token = new UTokenRe();
            UReservation reserva = new UReservation();
            UEmpleados usuario = new UEmpleados();


            System.Data.DataTable validez1 = ToDataTable(user.obtenerReser(datos));
            data.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
            data.Id_usuario = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
            System.Data.DataTable validez2 = ToDataTable(user.obtenTokenre(data));
            token.Id = int.Parse(validez2.Rows[0]["id"].ToString());
            token.Reserva_id = int.Parse(validez2.Rows[0]["reserva_id"].ToString());
            token.Token = validez2.Rows[0]["token"].ToString();
            token.Fecha_creado = DateTime.Parse(validez2.Rows[0]["fecha_creado"].ToString());
            token.Fecha_vigencia = DateTime.Parse(validez2.Rows[0]["fecha_vigencia"].ToString());
            reserva.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
            reserva.Id_usuario = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
            reserva.Id_mesa = int.Parse(validez1.Rows[0]["id_mesa"].ToString());
            reserva.Dia = validez1.Rows[0]["dia"].ToString();
            reserva.Estado = 1;
            reserva.Puntos = 10;
            user.eliminarToken(token);
            user.actualizarReserva(reserva);
            System.Data.DataTable validez = ToDataTable(user.obtenDatospago(data));
            usuario.User_id = int.Parse(validez.Rows[0]["user_id"].ToString());
            usuario.Nombre = validez.Rows[0]["nombre"].ToString();
            usuario.Apellido = validez.Rows[0]["apellido"].ToString();
            usuario.Email = validez.Rows[0]["email"].ToString();
            usuario.Telefono = validez.Rows[0]["telefono"].ToString();
            usuario.Cedula = validez.Rows[0]["cedula"].ToString();
            Int32 puntos = int.Parse(validez.Rows[0]["puntos"].ToString());
            usuario.Puntos = puntos + 10;
            usuario.Id_Rol = int.Parse(validez.Rows[0]["id_rol"].ToString());
            usuario.User_Name1 = validez.Rows[0]["User_Name1"].ToString();
            usuario.Clave = validez.Rows[0]["clave"].ToString();
            usuario.Session = validez.Rows[0]["session"].ToString();
            usuario.Rclave = validez.Rows[0]["rclave"].ToString();
            usuario.Intentos = int.Parse(validez.Rows[0]["Intentos"].ToString());
            usuario.Sesiones = int.Parse(validez.Rows[0]["sesiones"].ToString());
            user.actualizarPago(usuario); 





            data.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"Inicio.aspx\"</script>";

            return data;
        }

        //public UUsuario insertUsuario(UEmpleados datos, UUsuario mensaje)
        //{
        //    DUser dao = new DUser();
        //    UUsuario user = new UUsuario();

        //    dao.insertComentario(comentario);
        //    user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"Inicio.aspx\"</script>";

        //    return user;
        //}

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
            return dao.listarPlat();
        }
        public List<UReservation> listadeReservas(Int32 id)
        {
            DUser dao = new DUser();
            return dao.listadodeReservas(id);
        }
        public List<UEmpleados> listadePuntos(Int32 id)
        {
            DUser dao = new DUser();
            return dao.listadodePuntos(id);
        }
        public List<ULclientes> listadeClientes()
        {
            DUser dao = new DUser();
            return dao.listarclientes();
        }
        public List<Uubicacion> obtenPedido(UuserPedido user_id)
        {
            DUser dao = new DUser();
            return dao.ObtenerPedidos(user_id);
        }
        public UPedido insertarPedido(UPedidoplato pedido)
        {
            DUser dao = new DUser();
            dao.insertPedido(pedido);
            UPedido user = new UPedido();
            return user;
        }
        public UuserPedido guardarUbicacion(Uubicacion pedido)
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

        public UUsuario Cerrar(UUsuario datos)
        {
            DUser data = new DUser();
            UUsuario user = new UUsuario();
            UAutenticatio auten = new UAutenticatio();
            UEmpleados usuario = new UEmpleados();

            System.Data.DataTable validez1 = ToDataTable(data.obtenerautentication(datos));
            auten.Id = int.Parse(validez1.Rows[0]["id"].ToString());
            auten.User_id = int.Parse(validez1.Rows[0]["user_id"].ToString());
            auten.Ip = validez1.Rows[0]["ip"].ToString();
            auten.Mac = validez1.Rows[0]["mac"].ToString();
            auten.Fecha_inicio = DateTime.Parse(validez1.Rows[0]["fecha_inicio"].ToString());
            auten.Session = validez1.Rows[0]["session"].ToString();
            auten.Fecha_fin = DateTime.Now;
            data.actualizarAutentication(auten);
            System.Data.DataTable validez = ToDataTable(data.obtenusuario(datos));
            usuario.User_id = int.Parse(validez.Rows[0]["user_id"].ToString());
            usuario.Nombre = validez.Rows[0]["nombre"].ToString();
            usuario.Apellido = validez.Rows[0]["apellido"].ToString();
            usuario.Email = validez.Rows[0]["email"].ToString();
            usuario.Telefono = validez.Rows[0]["telefono"].ToString();
            usuario.Cedula = validez.Rows[0]["cedula"].ToString();
            usuario.Puntos = int.Parse(validez.Rows[0]["puntos"].ToString());
            usuario.Id_Rol = int.Parse(validez.Rows[0]["id_rol"].ToString());
            usuario.User_Name1 = validez.Rows[0]["User_Name1"].ToString();
            usuario.Clave = validez.Rows[0]["clave"].ToString();
            usuario.Session = validez.Rows[0]["session"].ToString();
            usuario.Rclave = validez.Rows[0]["rclave"].ToString();
            usuario.Intentos = int.Parse(validez.Rows[0]["Intentos"].ToString());
            Int32 sesiones = int.Parse(validez.Rows[0]["sesiones"].ToString());
            usuario.Sesiones = sesiones - 1;
            data.actualizarSesiones(usuario);  
            user.Mensaje = "Loggin.aspx";   


            return user;
        }



    }
}
