using System.Text;
using Datos;
using Utilitarios;
using System.Data;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Logica
{
    public class LUser
    {
        public UUser logear(UUser datos)
        {
            DUser data = new DUser();
            DataTable registros1 = data.validarSesiones(datos);
            UUser user = new UUser();
            DataTable registros2 = data.validarIntentos(datos);

            if (int.Parse(registros1.Rows[0]["id_usuario"].ToString()) > 0)
            {
                DataTable registros = data.loggin(datos);
                if (int.Parse(registros.Rows[0]["user_id"].ToString()) > 0)
                {
                    user.RolId = int.Parse(registros.Rows[0]["user_rol"].ToString());
                    switch (int.Parse(registros.Rows[0]["user_rol"].ToString()))
                    {
                        case 1:


                            user.User_name = registros.Rows[0]["nombre"].ToString();
                            user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());



                            UUser datosUsuario = new UUser();
                            Mac datosConexion = new Mac();

                            /* ipAddress = HttpConteinxt.Current.Request.UserHostAddress;
                             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                            datosUsuario.UserId = user.UserId;
                            datosUsuario.Ip = datosConexion.ip();
                            datosUsuario.Mac = datosConexion.mac();
                            datosUsuario.Session = datos.Session;

                            data.guardadoSession(datosUsuario);
                            user.Url = "ListadePlatos.aspx";
                            break;

                        case 2:

                            user.User_name = registros.Rows[0]["nombre"].ToString();
                            user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());

                            UUser datosUsuario1 = new UUser();
                            Mac datosConexion1 = new Mac();

                            /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                            datosUsuario1.UserId = user.UserId;
                            datosUsuario1.Ip = datosConexion1.ip();
                            datosUsuario1.Mac = datosConexion1.mac();
                            datosUsuario1.Session = datos.Session;

                            data.guardadoSession(datosUsuario1);

                            user.Url = "Despachos.aspx";
                            break;

                        case 3:

                            user.User_name = registros.Rows[0]["nombre"].ToString();
                            user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());

                            UUser datosUsuario2 = new UUser();
                            Mac datosConexion2 = new Mac();

                            /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                            datosUsuario2.UserId = user.UserId;
                            datosUsuario2.Ip = datosConexion2.ip();
                            datosUsuario2.Mac = datosConexion2.mac();
                            datosUsuario2.Session = datos.Session;

                            data.guardadoSession(datosUsuario2);

                            user.Url = "Pedido.aspx";
                            break;


                        case 4:

                            user.User_name = registros.Rows[0]["nombre"].ToString();
                            user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());


                            UUser datosUsuario3 = new UUser();
                            Mac datosConexion3 = new Mac();


                            /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                            datosUsuario3.UserId = user.UserId;
                            datosUsuario3.Ip = datosConexion3.ip();
                            datosUsuario3.Mac = datosConexion3.mac();
                            datosUsuario3.Session = datos.Session;

                            data.guardadoSession(datosUsuario3);

                            user.Url = "InicioCliente.aspx";
                            break;

                    }
                }

                else if (int.Parse(registros2.Rows[0]["id_usuario"].ToString()) == 0)
                {
                    user.Mensaje = "<script type='text/javascript'>alert('" + datos.A.ToString() + "');window.location=\"Loggin.aspx\"</script>";

                }
                else
                {

                    user.Mensaje = "<script type='text/javascript'>alert('" + datos.B.ToString() + "');window.location=\"Loggin.aspx\"</script>";

                }
                return user;
            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('" + datos.C.ToString() + "');window.location=\"Loggin.aspx\"</script>";

            }
            return user;
        }
        public DataTable validarFecha(UUser datos)
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.validarFecha(datos);

            return dat;

        }
        public UUsuario Cerrar(UUsuario datos)
        {
            DUser data = new DUser();
            UUsuario user = new UUsuario();


            data.cerrarSession(datos);
            user.Mensaje = "Loggin.aspx";

            return user;
        }

        public UUsuario Registro(UUsuario datos)
        {
            DUser data = new DUser();
            UUsuario user = new UUsuario();


            System.Data.DataTable validez = data.validarRegistro(datos.User_Name1, datos.Email);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                data.InsertarUsuario(datos);
                                
                user.Mensaje = "<script type='text/javascript'>alert('" + datos.A.ToString() + "');window.location=\"Loggin.aspx\"</script>";
                ////cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
                //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario Creado Correctamente');window.location=\"Loggin.aspx\"</script>");

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('" + datos.Extension.ToString() + "');window.location=\"Registro.aspx\"</script>";
            }

            return user;
        }

        private string encriptar(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        public UReserva Reserva(UReserva datos, UReservation dato)
        {
            DUser data = new DUser();
            UReserva user = new UReserva();
            L_Persistencia conver = new L_Persistencia();

            if (datos.Nombre != null)
            {
                data.insertarReserva(dato);
                System.Data.DataTable validez1 = conver.ToDataTable(data.obtenerReser(dato));
                user.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());

                System.Data.DataTable validez = data.generarTokenReserva(user.Id_reserva);
                if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
                {
                    UUserToken token = new UUserToken();
                    token.Id = int.Parse(validez.Rows[0]["id_reserva"].ToString());
                    token.Id_usuario = int.Parse(validez.Rows[0]["id_usuario"].ToString());
                    token.Id_Mesa = int.Parse(validez.Rows[0]["id_mesa"].ToString());
                    token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());
                    token.Correo = validez.Rows[0]["email"].ToString();
                    token.Fecha = DateTime.Now.ToFileTimeUtc();

                    UTokenRe toke = new UTokenRe();
                    String userToken = encriptar(JsonConvert.SerializeObject(token));
                    toke.Token = userToken;
                    toke.Reserva_id = token.Id;
                    toke.Fecha_creado = DateTime.Now;
                    toke.Fecha_vigencia = DateTime.Now.AddHours(12);

                    data.insertTokenre(toke);

                    CorreoR correo = new CorreoR();

                    String mensaje = "su link de acceso es: " + "http://52.14.131.2/View/pago.aspx?" + userToken;
                    correo.enviarCorreo(token.Correo, userToken, mensaje);

                    //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Para Confirmar su reseva por favor pague el valor de la reserva');</script>");
                    user.Mensaje = "<script type='text/javascript'>alert('" + datos.A.ToString() + "');window.location=\"Resrvas.aspx\"</script>";

                }
                else if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) == -2)
                {
                    user.Mensaje = "<script type='text/javascript'>alert('" + datos.C.ToString() + "');</script>";

                }
                else
                {
                    user.Mensaje = "<script type='text/javascript'>alert('" + datos.D.ToString() + "');</script>";

                }

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('" + datos.B.ToString() + "');window.location=\"Loggin.aspx\"</script>";

                //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');window.location=\"Loggin.aspx\"</script>");

                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');</script>");
                ////Response.Redirect("Loggin.aspx");

            }

            return user;

        }

        public UReserva pago(UReserva datos)
        {
            DUser user = new DUser();
            UReserva data = new UReserva();


            System.Data.DataTable validez1 = user.obtenerReserva(datos.Id_usuario);
            data.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
            data.Id_usuario = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
            user.actualizarReserva(datos);

            data.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');window.location=\"Inicio.aspx\"</script>";

            return data;
        }

        public DataTable depacho()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerdatos();

            return dat;

        }
        public DataTable depacho1()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerdatos1();

            return dat;

        }
        public DataTable infoplato(Int32 id_pedido)
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.informacionPlato(id_pedido);

            return dat;

        }
        public DataTable infoplato1(Int32 id_pedido)
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.informacionPlato1(id_pedido);

            return dat;

        }

        public UDespachos despachos(Int32 id_pedido, DateTime fecha_despacho)
        {
            DUser llamar = new DUser();
            UDespachos desp = new UDespachos();

            llamar.despacho(id_pedido, fecha_despacho);

            desp.Url = "Despachos.aspx";

            return desp;

        }

        public UDespachos despachos1(Int32 id_pedido, DateTime fecha_despacho)
        {
            DUser llamar = new DUser();
            UDespachos desp = new UDespachos();

            llamar.despacho1(id_pedido, fecha_despacho);

            desp.Url = "Despachos.aspx";

            return desp;

        }

        public Estado estado(UUser datos)
        {
            Estado desp = new Estado();

            if (datos.User_name == null)
            {
                desp.Esstado = false;
            }
            else
            {
                desp.Esstado = true;
                desp.Estado1 = false;
            }

            return desp;

        }

        public DataTable ListaEmpleado()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerEmpleado();

            return dat;

        }

        public UUsuario rol(Int32 rol)
        {
            UUsuario user = new UUsuario();
            if (rol == 2)
            {
                user.Url = "2";
            }
            else
            {
                user.Url = "3";
            }
            return user;

        }
        //public UUser rol(string rol)
        //{
        //    UUser user = new UUser();
        //    if (rol == "Cocinero")
        //    {
        //        user.Url = "2";
        //    }
        //    else
        //    {
        //        user.Url = "3";
        //    }
        //    return user;

        //}
        public UUsuario ObtenerId(string nombre)
        {
            DUser user = new DUser();
            UUsuario id = new UUsuario();
            System.Data.DataTable validez1 = user.obtenerId(nombre);
            id.User_id = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
            id.Nombre = validez1.Rows[0]["nombre"].ToString();
            id.Apellido = validez1.Rows[0]["apellido"].ToString();
            id.Email = validez1.Rows[0]["email"].ToString();
            id.Telefono = validez1.Rows[0]["telefono"].ToString();
            id.Cedula = validez1.Rows[0]["cedula"].ToString();
            id.Id_Rol = int.Parse(validez1.Rows[0]["id_rol"].ToString());
            id.User_Name1 = validez1.Rows[0]["user_name"].ToString();
            id.Clave = validez1.Rows[0]["clave"].ToString();
            id.Rclave = validez1.Rows[0]["rclave"].ToString();
            return id;

        }
        public UUsuario ObtenerIds(string nombre)
        {
            DUser user = new DUser();
            UUsuario id = new UUsuario();
            System.Data.DataTable validez1 = user.obtenerId(nombre);

            id.User_id = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
            id.Nombre = validez1.Rows[0]["nombre"].ToString();
            id.Apellido = validez1.Rows[0]["apellido"].ToString();
            id.Email = validez1.Rows[0]["email"].ToString();
            id.Telefono = validez1.Rows[0]["telefono"].ToString();
            id.Cedula = validez1.Rows[0]["cedula"].ToString();
            id.Id_Rol = int.Parse(validez1.Rows[0]["id_rol"].ToString());
            id.User_Name1 = validez1.Rows[0]["user_name"].ToString();
            id.Clave = validez1.Rows[0]["clave"].ToString();
            id.Rclave = validez1.Rows[0]["rclave"].ToString();

            return id;

        }

        public UUsuario RegistrarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            UUsuario usuario = new UUsuario();

            System.Data.DataTable validez = user.validarRegistro(datos.User_Name1, datos.Email);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                user.insertarEmpleado(datos);
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
                usuario.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";

            }
            else
            {
                usuario.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');</script>";
            }

            return usuario;

        }
        public UUsuario ModificarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            UUsuario usuario = new UUsuario();

            user.modificarEmpleado(datos);
            usuario.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";

            return usuario;

        }
        public UUsuario EliminarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            UUsuario usuario = new UUsuario();

            user.eliminarEmpleado(datos);
            usuario.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";

            return usuario;

        }
        public DataTable BuscarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusare(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                usuario = user.buscarEmpleados(nombre);

            }
            return usuario;
        }
        public DataTable ListaClientes()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obteneruser();

            return dat;

        }
        public DataTable BuscarCliente(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusare(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                usuario = user.buscarUsuario(nombre);

            }
            return usuario;
        }
        public DataTable ListaVentas()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerplatopedido();

            return dat;

        }
        public DataTable BuscarVentas(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusarpp(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_pedido"].ToString()) > 0)
            {
                usuario = user.buscarPedidoplato(nombre);

            }
            return usuario;
        }
        public DataTable ListaReservas()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerReservaplato();

            return dat;

        }
        public DataTable BuscarReserva(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusarrp(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_reserva"].ToString()) > 0)
            {
                usuario = user.validarBusarrp(nombre);

            }
            return usuario;
        }

        public DataTable ListaComentarios()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerComentarios();

            return dat;

        }

        public DataTable BuscarComentarios(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBuscarco(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_comentarios"].ToString()) > 0)
            {
                usuario = user.buscarUsuario(nombre);

            }
            return usuario;
        }

        //public UUsuario InsertarComentario(UComentarios datos)
        //{

        //    UComentarios comentario = new UComentarios();
        //    DUser data = new DUser();
        //    UUsuario mensaje = new UUsuario();

        //    data.insertarComentarios(datos);

        //    mensaje.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"Inicio.aspx\"</script>";

        //    return mensaje;
        //}

        public UReportes obtenerinfomer()
        {
            DataRow fila;  //dr
            DataTable informacion = new DataTable(); //dt
            UReportes datos = new UReportes();

            informacion = datos.Tables["Reservas"];
            DUser usuario = new DUser();

            DataTable intermedio = usuario.obtenerRes();

            for (int i = 0; i < intermedio.Rows.Count; i++)
            {
                fila = informacion.NewRow();

                fila["Reserva"] = int.Parse(intermedio.Rows[i]["id_reserva"].ToString());
                fila["Usuario"] = intermedio.Rows[i]["user_name"].ToString();
                fila["Dia"] = intermedio.Rows[i]["dia"].ToString();
                //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

                informacion.Rows.Add(fila);
            }

            return datos;
        }

        public UReportes obtenerinfomeV()
        {
            DataRow fila;  //dr
            DataTable informacion = new DataTable(); //dt
            UReportes datos = new UReportes();

            informacion = datos.Tables["Pedido"];
            DUser usuario = new DUser();

            DataTable intermedio = usuario.obtenerVenta();

            for (int i = 0; i < intermedio.Rows.Count; i++)
            {
                fila = informacion.NewRow();

                fila["Pedido"] = int.Parse(intermedio.Rows[i]["id_pedido"].ToString());
                fila["Nombre"] = intermedio.Rows[i]["nombre"].ToString();
                fila["Cantidad"] = int.Parse(intermedio.Rows[i]["cantidad"].ToString());
                fila["Fecha ingreso"] = intermedio.Rows[i]["fecha_ingreso"].ToString();
                fila["Fecha despacho"] = intermedio.Rows[i]["fecha_despacho"].ToString();
                fila["Precio"] = intermedio.Rows[i]["precio"].ToString();
                //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

                informacion.Rows.Add(fila);
            }

            return datos;
        }

        //public UReportes obtenerinformeE()
        //{

        //    DataRow fila;  //dr
        //    DataTable informacion = new DataTable(); //dt
        //    UReportes datos = new UReportes();

        //    informacion = datos.Tables["Empleados"];
        //    DUser usuario = new DUser();

        //    DataTable intermedio = usuario.obtenerEmpleado();

        //    for (int i = 0; i < intermedio.Rows.Count; i++)
        //    {
        //        fila = informacion.NewRow();

        //        fila["Nombre"] = intermedio.Rows[i]["nombre"].ToString();
        //        fila["Apellido"] = intermedio.Rows[i]["apellido"].ToString();
        //        fila["Correo"] = intermedio.Rows[i]["correo"].ToString();
        //        fila["Cedula"] = intermedio.Rows[i]["cedula"].ToString();
        //        fila["Rol"] = intermedio.Rows[i]["rol"].ToString();
        //        //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

        //        informacion.Rows.Add(fila);
        //    }

        //    return datos;
        //}

        public UUser validarlogin(UUser datos)
        {
            UUser data = new UUser();

            if (datos.User_name == null)
            {
                data.Url = "Loggin.aspx";
            }
            return data;

        }
        public UUser contactenos(String nombre, String telefono, String email, String detalle)
        {
            DUser data = new DUser();
            DataTable datos = data.insertarContacto(nombre, telefono, email, detalle);
            UUser user = new UUser();

            return user;
        }
        public UUserToken GenerarToken(String user_name)
        {
            DUser data = new DUser();
            DataTable validez = data.generarToken(user_name);
            UUserToken token = new UUserToken();
            UTokenRecu tokenR = new UTokenRecu();

            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {

                token.Id = int.Parse(validez.Rows[0]["id_usuario"].ToString());
                token.Nombre = validez.Rows[0]["nombre"].ToString();
                token.Apellido = validez.Rows[0]["apellido"].ToString();
                token.Correo = validez.Rows[0]["email"].ToString();
                token.Telefono = validez.Rows[0]["telefono"].ToString();
                token.Cedula = validez.Rows[0]["cedula"].ToString();
                token.Puntos = validez.Rows[0]["puntos"].ToString();
                token.Id_rol = validez.Rows[0]["id_rol"].ToString();
                token.User_name = validez.Rows[0]["user_name"].ToString();
                token.Clave = validez.Rows[0]["clave"].ToString();
                token.Session = validez.Rows[0]["session"].ToString();
                token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());

                token.Fecha = DateTime.Now.ToFileTimeUtc();

                String userToken = encriptar(JsonConvert.SerializeObject(token));
                tokenR.Text = userToken;
                tokenR.User_id = token.Id;
                tokenR.Fecha_creado = DateTime.Now;
                tokenR.Fecha_vigencia = DateTime.Now.AddMinutes(30);
                data.insertarToken(tokenR);

                Correo correo = new Correo();


                String mensaje = "su link de acceso es: " + "http://18.216.35.197/View/Recuperar_Contraseña.aspx?" + userToken;
                correo.enviarCorreo(token.Correo, userToken, mensaje);

                token.Url = "<script type='text/javascript'>alert('" + token.Session.ToString() + "');window.location=\"Loggin.aspx\"</script>";

            }
            else if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) == -2)
            {
                token.Mensaje = "Ya existe un token, por favor verifique su correo.";
            }
            else
            {
                token.Mensaje = "El usurio digitado no existe";
            }
            return token;
        }
        //private string encriptar(string input)
        //{
        //    SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        //    byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        //    byte[] hashedBytes = provider.ComputeHash(inputBytes);

        //    StringBuilder output = new StringBuilder();

        //    for (int i = 0; i < hashedBytes.Length; i++)
        //        output.Append(hashedBytes[i].ToString("x2").ToLower());

        //    return output.ToString();
        //}
        public int Recuperar(int x, string y)
        {
            DUser user = new DUser();
            UUserToken token = new UUserToken();
            int sesion = 0;
            if (x > 0)
            {

                DataTable info = user.obtenerUsusarioToken(y);

                if (int.Parse(info.Rows[0][0].ToString()) == -1)
                    token.Url = "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>";
                else if (int.Parse(info.Rows[0][0].ToString()) == -1)
                    token.Url = "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>";
                else
                    sesion = int.Parse(info.Rows[0][0].ToString());
            }
            else
                token.Url = "Inicio.aspx";

            return sesion;
        }
        public void guardarcontra(int x, string y)
        {
            UUserToken datos = new UUserToken();
            DUser user = new DUser();

            datos.User_id = x;
            datos.Clave = y;
            user.actualziarContrasena(datos);
            datos.Url = "<script type='text/javascript'>alert('" + datos.Session.ToString() + "');window.location=\"Loggin.aspx\"</script>";

        }

        public DataTable listarmenu()
        {
            DUser data = new DUser();
            DataTable datos = data.obtenerPlato();


            return datos;
        }
        public DataTable Listadomesas()
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerMesas();

            return data;
        }
        public UuserReservas canje(DataTable tabla)
        {
            DUser data = new DUser();
            UuserReservas dato = new UuserReservas();

            int sum = 0;
            int p = 0;

            foreach (DataRow fila in tabla.Rows)
            {
                string punto = tabla.Rows[0]["puntos"].ToString();
                p = int.Parse(punto);
                sum = p;
            }
            dato.Cant = sum;

            if (sum < 100)
            {
                dato.Est1 = true;
                dato.Est2 = false;
            }
            else
            {
                dato.Est1 = false;
                dato.Est2 = true;
            }
            return dato;
        }
        public DataTable obtenerReservas(int id_usuario)
        {
            DUser dao = new DUser();
            DataTable reser = dao.obtenerMisReservas(id_usuario);
            return reser;
        }
        public DataTable obtenerPuntos(int id)
        {
            DUser dao = new DUser();
            DataTable reser = dao.obtenerPuntos(id);
            return reser;
        }
        public DataTable redimir(int id)
        {
            DUser dato = new DUser();
            DataTable redimi = dato.redimir(id);
            return redimi;
        }
        public void cortesia(int id)
        {
            DUser dato = new DUser();
            dato.Insertarcortesia(id);

        }
        public void obtenerPlato()
        {
            DUser dato = new DUser();
            dato.obtenerPlato();
        }
        public DataTable guardarPedido(UuserPedido pedido)
        {
            DUser dato = new DUser();
            DataTable data = dato.insertarPedido(pedido);
            return data;
        }
        public DataTable obtenerpe(int user_id)
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerPedido(user_id);
            return data;
        }
        public DataTable guardarPedido1(UuserPedido pedido)
        {
            DUser dato = new DUser();
            DataTable data = dato.InsertPedido(pedido);
            return data;
        }
        public void listaplatos(bool x)
        {
            DUser dato = new DUser();
            UUser data = new UUser();
            if (x)
            {
                data.Url = "Loggin.aspx";
            }
            DataTable tabla = dato.obtenerPlato();
        }
        public DataTable obtenerMesa(string nombre)
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerIdm(nombre);
            return data;
        }
        public void eliminarPlato(UuserCrear datos)
        {
            DUser dato = new DUser();
            DataTable data = dato.EliminarPlato(datos);
        }
        public DataTable validarbuscarM(string nombre)
        {
            DUser dato = new DUser();
            DataTable data = dato.validarBuscarm(nombre);
            UUser datos = new UUser();

            return data;
        }
        public DataTable buscarPla(string nombre)
        {
            DUser dato = new DUser();
            DataTable tabla = new DataTable();
            UUser datos = new UUser();

            if (datos.X > 0)
            {
                dato.buscarPlato(nombre);
            }
            else
            {
                datos.Url = "<script type='text/javascript'>alert('Plato no Existe');window.location=\"ListadePlatos.aspx\"</script>";
            }
            return tabla;
        }
        public void insertmenu(UuserCrear datos)
        {
            DUser dato = new DUser();
            //DataTable data = dato.insertarMenu(datos);
            String xD = "~\\Imagen\\";
            if (datos.Imagen != xD)
            {
                dato.insertarMenu(datos);
            }
        }


        public UUser cargaImagen(UUser enca)
        {
            DUser dato = new DUser();
            UUser mensaje = new UUser();
            String saveLocation = "";
            mensaje.Ispos = true;
            if (!(string.Compare(enca.A, ".JPG", true) == 0 || string.Compare(enca.A, ".jpeg", true) == 0 || string.Compare(enca.A, ".gif", true) == 0 || string.Compare(enca.A, ".jpe", true) == 0))
            {
                mensaje.Url = "<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>";
                mensaje.Ubicacion = null;

                return mensaje;
            }
            // else
            //{
            //  mensaje.Ubicacion = enca.Ubicacion;
            //}
            saveLocation = enca.Ubicacion;
            if (System.IO.File.Exists(saveLocation))
            {
                mensaje.Url = "<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>";
                mensaje.Ubicacion = null;
                //return null;
            }
            else
            {
                mensaje.Ubicacion = enca.Ubicacion;
            }
            return mensaje;
        }

        public UUser CargaIma(UUser enca)
        {
            DUser dato = new DUser();
            UUser mensaje = new UUser();
            String saveLocation = "";
            mensaje.Ispos = true;
            if (!(string.Compare(enca.A, ".JPG", true) == 0 || string.Compare(enca.A, ".jpeg", true) == 0 || string.Compare(enca.A, ".gif", true) == 0 || string.Compare(enca.A, ".jpe", true) == 0))
            {
                mensaje.Url = "<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>";
                mensaje.Ubicacion = null;

                return mensaje;
            }
            // else
            //{
            //  mensaje.Ubicacion = enca.Ubicacion;
            //}
            saveLocation = enca.Ubicacion;
            if (System.IO.File.Exists(saveLocation))
            {
                mensaje.Url = "<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>";
                mensaje.Ubicacion = null;
                //return null;
            }
            else
            {
                mensaje.Ubicacion = enca.Ubicacion;
            }
            return mensaje;
        }
        public void aux(UuserCrear info)
        {
            DUser dato = new DUser();
            if (info.Ispos)
            {
                insertmenu(info);
            }
            else
            {
                info.A = "<script type='text/javascript'>alert('ERROR..');</script>";

            }
        }
        public DataTable insertmesa(UUser datos)
        {
            DUser data = new DUser();
            DataTable dato = data.insertarMesa(datos);
            return dato;
        }
        public DataTable mofifimesas(UUser datos)
        {
            DUser data = new DUser();
            DataTable dato = data.modificarMesas(datos);
            return dato;
        }
        public void ispost(UUser info)
        {
            if (info.Ispos)
            {
                DUser data = new DUser();
                UUser datos = new UUser();
                info.A = info.B;
                info.C = info.D;
                info.E = info.F;
            }
        }
        public void ispost1(UuserCrear info)
        {
            if (info.Ispos)
            {
                DUser data = new DUser();
                UUser datos = new UUser();
                info.A = info.B;
                info.C = info.D;
                info.E = info.F;
            }
        }
        public DataTable listadoComentario()
        {
            DUser data = new DUser();
            UUser datos = new UUser();
            DataTable tabla = data.obtenerComentarios();
            return tabla;
        }
        public DataTable buscarcomen(string Nombre)
        {
            DUser data = new DUser();
            UUser datos = new UUser();
            DataTable tabla = data.validarBuscarco(Nombre);
            return tabla;
        }
        public DataTable buscarUser(string nombre)
        {
            DUser data = new DUser();
            UUser datos = new UUser();
            DataTable tabla = new DataTable();

            if (datos.X > 0)
            {
                data.buscarUsuario(nombre);
            }
            else
            {
                datos.Url = "<script type='text/javascript'>alert('Plato no Existe');window.location=\"ListaComentarios.aspx\"</script>";
            }
            return tabla;
        }
        public DataTable eliminarmesa(UUser datos)
        {
            DUser dato = new DUser();
            DataTable data = dato.eliminarMesa(datos);
            return data;
        }
        public void modifimenu(UuserCrear datos)
        {
            DUser dato = new DUser();
            if (datos.Imagen != null)
            {
                dato.modificarMenu(datos);
            }
        }
        public void aux1(UuserCrear info)
        {
            DUser dato = new DUser();
            if (info.Ispos)
            {
                modifimenu(info);
            }
            else
            {
                info.A = "<script type='text/javascript'>alert('ERROR..');</script>";

            }
        }

        public DataTable obtenerubi()
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerUbicacion();
            return data;
        }
        public DataTable platopedi()
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerPlato();
            return data;
        }
        public DataTable menuReser()
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerPlato();
            return data;
        }
        public DataTable obteberidres(string nombre)
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerIdre(nombre);
            return data;
        }
        public DataTable insertarplares(UuserReservas plato)
        {
            DUser dato = new DUser();
            DataTable data = dato.Insertarpreserva(plato);
            return data;
        }

        public DataTable obterplatocaje()
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerPlato();
            return data;
        }

        public DataTable buscarmesa(string nombre)
        {
            DUser dato = new DUser();
            DataTable data = dato.buscarMesas(nombre);
            return data;
        }

        public DataTable Cantidad()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerMesa();

            return dat;

        }

        public DataTable ObtenerRe()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerRe();

            return dat;

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

        public DataTable verificarRegistro(String correo)
        {
            DUser dato = new DUser();
            DataTable data =ToDataTable(dato.verificarRegistro(correo));
            return data;
        }
        public DataTable validarRegistro(String user_name, String correo)
        {
            DUser dato = new DUser();
            DataTable data = dato.validarRegistro(user_name,correo);
            return data;
        }

        public List<UContacto> obtenerAcontacto()
        {
            DUser dao = new DUser();
            return dao.listaracontacto();
        }

        public List<UReservation> obtenerAres()
        {
            DUser dao = new DUser();
            return dao.listarares();
        }

        public List<UEmpleados> obtenerModiA(String nombre)
        {
            DUser dao = new DUser();
            UUsuario datos = new UUsuario();
            datos.User_Name1 = nombre;

            return dao.obtenusuario(datos);
        }

        public List<Menu> obtenerAMenu()
        {
            DUser dao = new DUser();
            return dao.listaramenu();
        }

        public List<Menu> obtenerMen(String text)
        {
            DUser dao = new DUser();
            Menu datos = new Menu();
            datos.Nombre = text;

            return dao.obtenmen(datos);
        }

        public List<Mesas> obtenerAMesa()
        {
            DUser dao = new DUser();
            return dao.listaramesa();
        }
        public List<Mesas> obtenerMes(Int32 text)
        {
            DUser dao = new DUser();
            Mesas datos = new Mesas();
            datos.Id_mesas = text;

            return dao.obtenmesa(datos);
        }
        public List<UAidioma> obtenerAdiomas()
        {
            DUser dao = new DUser();
            return dao.listaraidiomas();
        }
        public List<UAidioma> obtenerIdiomac(String text)
        {
            DUser dao = new DUser();
            UAidioma datos = new UAidioma();
            datos.Nombre = text;

            return dao.obtenidiom(datos);
        }
        public List<UControles> obtenerModiControles(String text)
        {
            DUser dao = new DUser();
            UControles datos = new UControles();
            datos.Texto = text;

            return dao.obtencontroles(datos);
        }
        public List<UControles> obtenerAdioma()
        {
            DUser dao = new DUser();
            return dao.listaraidioma();
        }

        public void insert(DataTable regis, String esquema, String tabla, String pk, String session)
        {
            DAuditoria datos = new DAuditoria();
            UAuditoria data = new UAuditoria();
            Object obj = new Object();
            obj = regis;

            data.Pk = pk;
            data.Session = session;


            datos.insert(obj, data, esquema, tabla);

        }

        public void update(DataTable regis, UEmpleados dato, String esquema, String tabla, String pk, String session)
        {
            DAuditoria datos = new DAuditoria();
            UAuditoria data = new UAuditoria();
            UEmpleados emp = new UEmpleados();

            emp.Nombre = regis.Rows[0]["nombre"].ToString();
            emp.Apellido = regis.Rows[0]["apellido"].ToString();
            emp.Email = regis.Rows[0]["email"].ToString();
            emp.Telefono = regis.Rows[0]["telefono"].ToString();
            emp.Cedula = regis.Rows[0]["cedula"].ToString();
            emp.Id_Rol = int.Parse(regis.Rows[0]["id_rol"].ToString());
            emp.User_Name1 = regis.Rows[0]["user_name1"].ToString();
            emp.Clave = regis.Rows[0]["clave"].ToString();
            emp.Rclave = regis.Rows[0]["rclave"].ToString();
            emp.User_id = int.Parse(regis.Rows[0]["user_id"].ToString());
            emp.Session = regis.Rows[0]["session"].ToString();


            Object newObj = new Object();
            Object oldObj = new Object();
            newObj = dato;
            oldObj = emp;


            data.Pk = pk;
            data.Session = session;
            //data.Session = regis.Rows[0]["Session"].ToString();


            datos.update(newObj, oldObj, data, esquema, tabla);

        }

        public void updateMenu(DataTable regis, Menu dato, String esquema, String tabla, String pk, String session)
        {
            DAuditoria datos = new DAuditoria();
            UAuditoria data = new UAuditoria();
            Menu emp = new Menu();

            DataTable dat = regis;

            emp.Nombre = dat.Rows[0]["nombre"].ToString();
            emp.Id_plato = int.Parse(dat.Rows[0]["id_plato"].ToString());
            emp.Descripcion = dat.Rows[0]["descripcion"].ToString();
            emp.Precio = dat.Rows[0]["precio"].ToString();
            emp.Imagen = dat.Rows[0]["imagen"].ToString();
            //emp.Id_Rol = int.Parse(regis.Rows[0]["id_rol"].ToString());
            //emp.User_Name1 = regis.Rows[0]["user_name1"].ToString();
            //emp.Clave = regis.Rows[0]["clave"].ToString();
            //emp.Rclave = regis.Rows[0]["rclave"].ToString();
            //emp.User_id = int.Parse(regis.Rows[0]["user_id"].ToString());
            //emp.Session = regis.Rows[0]["session"].ToString();


            Object newObj = new Object();
            Object oldObj = new Object();
            newObj = dato;
            oldObj = emp;


            data.Pk = pk;
            data.Session = session;
            //data.Session = regis.Rows[0]["Session"].ToString();


            datos.update(newObj, oldObj, data, esquema, tabla);

        }

        public void updateMesas(DataTable regis, Mesas dato, String esquema, String tabla, String pk, String session)
        {
            DAuditoria datos = new DAuditoria();
            UAuditoria data = new UAuditoria();
            Mesas emp = new Mesas();

            emp.Ubicacion = regis.Rows[0]["ubicacion"].ToString();
            emp.Id_mesas = int.Parse(regis.Rows[0]["Id_mesas"].ToString());
            emp.Cantidad = int.Parse(regis.Rows[0]["cantidad"].ToString());
            //emp.User_Name1 = regis.Rows[0]["user_name1"].ToString();
            //emp.Clave = regis.Rows[0]["clave"].ToString();
            //emp.Rclave = regis.Rows[0]["rclave"].ToString();
            //emp.User_id = int.Parse(regis.Rows[0]["user_id"].ToString());
            //emp.Session = regis.Rows[0]["session"].ToString();


            Object newObj = new Object();
            Object oldObj = new Object();
            newObj = dato;
            oldObj = emp;


            data.Pk = pk;
            data.Session = session;
            //data.Session = regis.Rows[0]["Session"].ToString();


            datos.update(newObj, oldObj, data, esquema, tabla);

        }
        public void updateIdioma(DataTable regis, UControles dato, String esquema, String tabla, String pk, String session)
        {
            DAuditoria datos = new DAuditoria();
            UAuditoria data = new UAuditoria();
            UControles emp = new UControles();

            emp.Texto = regis.Rows[0]["Texto"].ToString();
            emp.Id = int.Parse(regis.Rows[0]["id"].ToString());
            emp.Formulario_id = int.Parse(regis.Rows[0]["formulario_id"].ToString());
            emp.Idioma_id = int.Parse(regis.Rows[0]["idioma_id"].ToString());
            emp.Control = regis.Rows[0]["control"].ToString();
            //emp.Id_Rol = int.Parse(regis.Rows[0]["id_rol"].ToString());
            //emp.User_Name1 = regis.Rows[0]["user_name1"].ToString();
            //emp.Clave = regis.Rows[0]["clave"].ToString();
            //emp.Rclave = regis.Rows[0]["rclave"].ToString();
            //emp.User_id = int.Parse(regis.Rows[0]["user_id"].ToString());
            //emp.Session = regis.Rows[0]["session"].ToString();


            Object newObj = new Object();
            Object oldObj = new Object();
            newObj = dato;
            oldObj = emp;


            data.Pk = pk;
            data.Session = session;
            //data.Session = regis.Rows[0]["Session"].ToString();


            datos.update(newObj, oldObj, data, esquema, tabla);

        }
        public void delete(DataTable regis, String esquema, String tabla, String pk, String session)
        {
            DAuditoria datos = new DAuditoria();
            UAuditoria data = new UAuditoria();
            Object obj = new Object();
            obj = regis;

            data.Pk = pk;
            data.Session = session;
            //data.Session = regis.Rows[0]["Session"].ToString();


            datos.delete(obj, data, esquema, tabla);

        }

        public UUsuario insertUsuario(UEmpleados usuario)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();

            System.Data.DataTable validez = dao.validarRegistro(usuario.User_Name1, usuario.Email);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                dao.insertUsuario(usuario);
       
            }
           return user;
        }

    }
}
