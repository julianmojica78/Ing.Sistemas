using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;
using Utilitarios;
using System.Data.SqlClient;

namespace Datos
{
    public class DUser
    {
        public DataTable loggin(UUser datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("seguridad.f_loggin", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", SqlDbType.VarChar, 100).Value = datos.User_name;
                dataAdapter.SelectCommand.Parameters.Add("_clave", SqlDbType.VarChar, 100).Value = datos.Clave;
                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable cerrarSession(UUsuario datos)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_cerrar_session", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable guardadoSession(UUser datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("seguridad.f_guardado_session", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", SqlDbType.Int).Value = datos.UserId;
                dataAdapter.SelectCommand.Parameters.Add("_ip", SqlDbType.VarChar, 100).Value = datos.Ip;
                dataAdapter.SelectCommand.Parameters.Add("_mac", SqlDbType.VarChar, 100).Value = datos.Mac;
                dataAdapter.SelectCommand.Parameters.Add("_session", SqlDbType.Text).Value = datos.Session;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public void InsertarUsuario(UUsuario datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = datos.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
                dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Text).Value = datos.Cedula;
                dataAdapter.SelectCommand.Parameters.Add("_puntos", NpgsqlDbType.Integer).Value = datos.Puntos;
                dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = datos.Id_Rol;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_rclave", NpgsqlDbType.Text).Value = datos.Rclave;
                dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;
                dataAdapter.SelectCommand.Parameters.Add("_sesiones", NpgsqlDbType.Integer).Value = datos.Sesiones;
                dataAdapter.SelectCommand.Parameters.Add("_intentos", NpgsqlDbType.Integer).Value = datos.Intentos;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }
        public DataTable validarSesiones(UUser datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("seguridad.f_validar_sesiones", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", SqlDbType.VarChar, 100).Value = datos.User_name;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable validarIntentos(UUser datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("seguridad.f_validar_intentos", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", SqlDbType.VarChar, 100).Value = datos.User_name;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable validarFecha(UUser datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("seguridad.f_validar_fecha", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", SqlDbType.VarChar, 100).Value = datos.User_name;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable validarRegistro(String user_name, String correo)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_validar_registro", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", SqlDbType.VarChar, 50).Value = user_name;
                dataAdapter.SelectCommand.Parameters.Add("_correo", SqlDbType.VarChar, 50).Value = correo;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }


        public void InsertReserva(UReserva datos)
        {

            DataTable Reserva = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_reserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Cant;
                dataAdapter.SelectCommand.Parameters.Add("_dia", NpgsqlDbType.Timestamp).Value = datos.Dia;
                dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = datos.Id_usuario;
                conection.Open();
                dataAdapter.Fill(Reserva);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }

        public DataTable obtenerReserva(Int32 user_id)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = user_id;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable generarTokenReserva(Int32 user_id)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_validar_reserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", SqlDbType.Int).Value = user_id;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable almacenarTokenReserva(String token, Int32 userId)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_almacenar_token_reserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = userId;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable actualizarReserva(UReserva datos)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_reserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_reserva", NpgsqlDbType.Integer).Value = datos.Id_reserva;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.Id_usuario;
                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable obtenerdatos()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_cocinero", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable despacho(Int32 id_pedido, DateTime fecha_despacho)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_despacho", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;
                //dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = id_plato;
                dataAdapter.SelectCommand.Parameters.Add("_fecha_despacho", NpgsqlDbType.Timestamp).Value = fecha_despacho;


                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }

        public DataTable obtenerdatos1()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_cocinero1", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable despacho1(Int32 id_pedido, DateTime fecha_despacho)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_despacho1", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;
                //dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = id_plato;
                dataAdapter.SelectCommand.Parameters.Add("_fecha_despacho", NpgsqlDbType.Timestamp).Value = fecha_despacho;


                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }
        public DataTable informacionPlato(Int32 id_pedido)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_platos", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }
        public DataTable informacionPlato1(Int32 id_pedido)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_platos1", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }

        public DataTable obtenerEmpleado()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_listar_empleado", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable obtenerId(String nombre)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_obtener_Id", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", SqlDbType.VarChar, 100).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public void insertarEmpleado(UUsuario datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_empleado", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = datos.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
                dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Text).Value = datos.Cedula;
                dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = datos.Id_Rol;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_rclave", NpgsqlDbType.Text).Value = datos.Rclave;
                dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }
        public void modificarEmpleado(UUsuario datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_empleado", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = datos.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
                dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Text).Value = datos.Cedula;
                dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = datos.Id_Rol;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_rclave", NpgsqlDbType.Text).Value = datos.Rclave;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }

        public void eliminarEmpleado(UUsuario datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }
        public DataTable validarBusare(String Nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarve", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }


        public DataTable buscarEmpleados(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_empleado", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }
        public DataTable obteneruser()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_listar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable buscarUsuario(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_clientes", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }
        public DataTable obtenerplatopedido()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_pedidoplato", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable validarBusarpp(String Nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarpp", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable buscarPedidoplato(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_pedidoplato", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }

        public DataTable obtenerReservaplato()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reservaplato", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable validarBusarrp(String Nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarrp", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable buscarreservapla(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_reservaplato", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }
        public DataTable obtenerComentarios()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_comentarios", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable validarBuscarco(String Nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarcom", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public void insertarComentarios(UComentarios datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_comentario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_detalle", NpgsqlDbType.Text).Value = datos.Descripcion;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }

        //public DataTable obtenerEmpleado()
        //{
        //    DataTable Usuario = new DataTable();
        //    NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        //    try
        //    {
        //        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_listar_empleado", conection);
        //        dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

        //        conection.Open();
        //        dataAdapter.Fill(Usuario);
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }
        //    finally
        //    {
        //        if (conection != null)
        //        {
        //            conection.Close();
        //        }
        //    }
        //    return Usuario;
        //}

        public DataTable obtenerRes()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_res", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable obtenerVenta()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_venta", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable insertarContacto(String nombre, String telefono, String email, String detalle)
        {
            DataTable contacto = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarcontacto", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = telefono;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = email;
                dataAdapter.SelectCommand.Parameters.Add("_detalle", NpgsqlDbType.Text).Value = detalle;

                conection.Open();
                dataAdapter.Fill(contacto);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return contacto;
        }
        public DataTable generarToken(String user_name)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_validar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", SqlDbType.VarChar, 100).Value = user_name;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable almacenarToken(String token, Int32 userId)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_almacenar_token", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = userId;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable obtenerUsusarioToken(String token)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_obtener_usuario_token", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_token", SqlDbType.VarChar, 200).Value = token;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable actualziarContrasena(UUserToken datos)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_contrasena", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = datos.Clave;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable obtenerPlato()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_plato", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable obtenerMisReservas(Int32 id_usuario)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_misreserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = id_usuario;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable obtenerPuntos(Int32 Id)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_puntos", conection);
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = Id;

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable redimir(Int32 Id)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_redimir", conection);
                dataAdapter.SelectCommand.Parameters.Add("_user_id", SqlDbType.Int).Value = Id;

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable Insertarcortesia(Int32 Id)
        {

            DataTable Pedido1 = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarpedidocortesia", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                //dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = datos.Id_pedido1;
                dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = Id;
                conection.Open();
                dataAdapter.Fill(Pedido1);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Pedido1;
        }
        public DataTable obtenerPedido(Int32 user_id)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_pedido", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = user_id;
                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable insertarPedido(UuserPedido pedido)
        {

            DataTable Pedido1 = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarpedido", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = pedido.Id_pedido;
                dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = pedido.Id_plato;
                dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = pedido.Cantidad;
                conection.Open();
                dataAdapter.Fill(Pedido1);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Pedido1;
        }
        public DataTable InsertPedido(UuserPedido pedido)
        {

            DataTable Pedido1 = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarpedido1", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                //dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = datos.Id_pedido1;
                dataAdapter.SelectCommand.Parameters.Add("_id_mesa", NpgsqlDbType.Integer).Value = pedido.Id_mesa;
                dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = pedido.Id_mesero;
                conection.Open();
                dataAdapter.Fill(Pedido1);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Pedido1;
        }
        public DataTable obtenerIdm(String nombre)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_obtener_Idm", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", SqlDbType.VarChar, 100).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable EliminarPlato(UuserCrear datos)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminarmenu", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = datos.Id_plato;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable validarBuscarm(String Nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarm", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable buscarPlato(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_platos", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable insertarMenu(UuserCrear datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarmenu", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nomplato;
                dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Text).Value = datos.Descripcion;
                dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Text).Value = datos.Precio;
                dataAdapter.SelectCommand.Parameters.Add("_imagen", NpgsqlDbType.Text).Value = datos.Imagen;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Registro;
        }
        public DataTable obtenerMesas()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_mesas", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable insertarMesa(UUser datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_mesas", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Id_Rol;
                dataAdapter.SelectCommand.Parameters.Add("_ubicacion", NpgsqlDbType.Text).Value = datos.Apellido;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Registro;
        }
        public DataTable modificarMesas(UUser datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_mesas", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_mesa", NpgsqlDbType.Integer).Value = datos.User_id;
                dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Nombre;

                dataAdapter.SelectCommand.Parameters.Add("_ubicacion", NpgsqlDbType.Text).Value = datos.Apellido;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Registro;
        }
        //public DataTable obtenerComentarios()
        //{
        //    DataTable Usuario = new DataTable();
        //    NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        //    try
        //    {
        //        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_comentarios", conection);
        //        dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

        //        conection.Open();
        //        dataAdapter.Fill(Usuario);
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }
        //    finally
        //    {
        //        if (conection != null)
        //        {
        //            conection.Close();
        //        }
        //    }
        //    return Usuario;
        //}
        //public DataTable validarBuscarco(String Nombre)
        //{
        //    DataTable Usuario = new DataTable();
        //    NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        //    try
        //    {
        //        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarcom", conection);
        //        dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

        //        conection.Open();
        //        dataAdapter.Fill(Usuario);
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }
        //    finally
        //    {
        //        if (conection != null)
        //        {
        //            conection.Close();
        //        }
        //    }
        //    return Usuario;
        //}
        //public DataTable buscarUsuario(String nombre)
        //{
        //    DataTable Usuario = new DataTable();
        //    NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        //    try
        //    {
        //        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_clientes", conection);
        //        dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

        //        conection.Open();
        //        dataAdapter.Fill(Usuario);
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }
        //    finally
        //    {
        //        if (conection != null)
        //        {
        //            conection.Close();
        //        }
        //    }
        //    return Usuario;
        //}
        public DataTable eliminarMesa(UUser datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_mesa", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
                //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
                conection.Open();
                dataAdapter.Fill(Registro);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Registro;
        }
        public DataTable modificarMenu(UuserCrear datos)
        {
            DataTable platos = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_modificarMenu", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = datos.Id_plato;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.A;
                dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Text).Value = datos.C;
                dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Text).Value = datos.E;
                dataAdapter.SelectCommand.Parameters.Add("_imagen", NpgsqlDbType.Text).Value = datos.Imagen;


                conection.Open();
                dataAdapter.Fill(platos);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return platos;
        }

        public DataTable obtenerUbicacion()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_ubicacion", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable Insertarpreserva(UuserReservas plato)
        {

            DataTable Plato = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarplatoreserva", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_reserva", NpgsqlDbType.Integer).Value = plato.Id_reserva;
                dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = plato.Id_plato;
                dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = plato.Cant;
                conection.Open();
                dataAdapter.Fill(Plato);


            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Plato;
        }

        public DataTable obtenerIdre(String nombre)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usuario.f_obtener_idre", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", SqlDbType.VarChar, 100).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }


        public DataTable buscarMesas(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_mesas", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;

        }

        public DataTable obtenerMesa()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_mesa", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable obtenerRe()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_re", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public void insertUsuario(UEmpleados usuario)
        {
            using (var db = new Mapeo("user"))
            {
                db.user.Add(usuario);
                db.SaveChanges();
            }
        }
        public List<UUse> listarEmpleados()
        {
            using (var db = new Mapeo("usuario"))
            {
                var a = db.usuario.ToList<UUse>();
                return a.ToList<UUse>();

            }

        }
        public void modificarUsuario(UEmpleados usuario)
        {
            using (var db = new Mapeo("user"))
            {
                var entry = db.Entry(usuario);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void eliminarUsuario(UEmpleados usuario)
        {
            using (var db = new Mapeo("user"))
            {
                db.user.Attach(usuario);
                db.Entry(usuario).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void insertMenu(Menu menu)
        {
            using (var db = new Mapeo("menu"))
            {
                db.menu.Add(menu);
                db.SaveChanges();
            }
        }
        public void actualizarMenu(Menu menu)
        {
            using (var db = new Mapeo("menu"))
            {
                db.menu.Attach(menu);
                var entry = db.Entry(menu);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void borrarMenu(Menu menu)
        {
            using (var db = new Mapeo("menu"))
            {
                db.menu.Attach(menu);
                db.Entry(menu).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public List<Menu> listarMenu()
        {
            using (var db = new Mapeo("menu"))
            {
                var a = db.menu.ToList<Menu>();
                return a.ToList<Menu>();

            }


        }

        public void insertComentario(UComentarios comentario)
        {
            using (var db = new Mapeo("comentarios"))
            {
                db.comentarios.Add(comentario);
                db.SaveChanges();
            }
        }
        public List<ULcomentarios> listarComentarios()
        {
            using (var db = new Mapeo("comentario"))
            {
                var a = db.comentario.ToList<ULcomentarios>();
                return a.ToList<ULcomentarios>();

            }


        }
        public DataTable informeEmpleado()
        {
            using (var db = new Mapeo("user"))
            {
                var a = db.usuario.ToList<UUse>();
                a.ToList<UUse>();
                DataTable informacion = new DataTable();

                informacion.Rows.Add(a.ToList());
                return informacion;
            }
        }

        public List<UInformeRe> listarReservas()
        {
            using (var db = new Mapeo("informeRe"))
            {
                var a = db.informeRe.ToList<UInformeRe>();
                return a.ToList<UInformeRe>();

            }

        }
        public List<UInformeVe> listarVentas()
        {
            using (var db = new Mapeo("informeVe"))
            {
                var a = db.informeVe.ToList<UInformeVe>();
                return a.ToList<UInformeVe>();

            }

        }
        public void insertarReserva(UReservation reserva)
        {
            using (var db = new Mapeo("reserva"))
            {
                db.reserva.Add(reserva);
                db.SaveChanges();
            }
        }

        public List<UPedido> listarPedidos()
        {
            using (var db = new Mapeo("pedido"))
            {
                var a = db.pedid.ToList<UPedido>();
                return a.ToList<UPedido>();

            }

        }

        public List<Menu> buscarPlatos(String nombre)
        {
            using (var db = new Mapeo("menu"))
            {
                var a = db.menu.ToList<Menu>().Where(x => x.Nombre.Contains(nombre));
                return a.ToList<Menu>();

            }

        }

        public List<UUse> buscarEmpleado(String nombre)
        {
            using (var db = new Mapeo("usuario"))
            {
                var a = db.usuario.ToList<UUse>().Where(x => x.Nombre.Contains(nombre));
                return a.ToList<UUse>();

            }

        }
        public List<ULclientes> buscarCliente(String nombre)
        {
            using (var db = new Mapeo("clientes"))
            {
                var a = db.clientes.ToList<ULclientes>().Where(x => x.Nombre.Contains(nombre));
                return a.ToList<ULclientes>();

            }

        }
        public List<ULcomentarios> buscarComent(String nombre)
        {
            using (var db = new Mapeo("comentario"))
            {
                var a = db.comentario.ToList<ULcomentarios>().Where(x => x.User_name.Contains(nombre));
                return a.ToList<ULcomentarios>();

            }

        }
        public List<ULReserva> buscarReservas(String nombre)
        {
            using (var db = new Mapeo("listReser"))
            {
                var a = db.listReser.ToList<ULReserva>().Where(x => x.Nombre.Contains(nombre));
                return a.ToList<ULReserva>();

            }

        }
        public List<Mesas> buscarMesa(String nombre)
        {
            using (var db = new Mapeo("mesa"))
            {
                var a = db.mesa.ToList<Mesas>().Where(x => x.Ubicacion.Contains(nombre));
                return a.ToList<Mesas>();

            }

        }
        public List<UPedido> buscarVentas(String nombre)
        {
            using (var db = new Mapeo("pedido"))
            {
                var a = db.pedid.ToList<UPedido>().Where(x => x.Nombre.Contains(nombre));
                return a.ToList<UPedido>();

            }

        }

        public List<UReservation> obtenerReser(UReservation dato)
        {
            using (var db = new Mapeo("reserva"))
            {
                var a = db.reserva.OrderByDescending(x => x.Id_reserva).ToList<UReservation>().Where(x => x.Id_usuario == dato.Id_usuario);
                return a.ToList<UReservation>();

            }

        }

        public void insertTokenre(UTokenRe toke)
        {
            using (var db = new Mapeo("tokenre"))
            {
                db.tokenre.Add(toke);
                db.SaveChanges();
            }
        }

        public List<UTokenRe> obtenTokenre(UReserva toke)
        {
            using (var db = new Mapeo("tokenre"))
            {
                var a = db.tokenre.OrderByDescending(x => x.Id).ToList<UTokenRe>().Where(x=> x.Reserva_id == toke.Id_reserva);
                return a.ToList<UTokenRe>();

            }

        }
        public void eliminarToken(UTokenRe toke)
        {
            using (var db = new Mapeo("tonkenre"))
            {
                db.tokenre.Attach(toke);
                db.Entry(toke).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void actualizarReserva(UReservation menu)
        {
            using (var db = new Mapeo("menu"))
            {
                db.reserva.Attach(menu);
                var entry = db.Entry(menu);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<UEmpleados> obtenDatospago(UReserva data)
        {
            using (var db = new Mapeo("user"))
            {
                var a = db.user.ToList<UEmpleados>().Where(x => x.User_id == data.Id_usuario);
                return a.ToList<UEmpleados>();

            }

        }

        public void actualizarPago(UEmpleados menu)
        {
            using (var db = new Mapeo("user"))
            {
                db.user.Attach(menu);
                var entry = db.Entry(menu);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<UCocinero> listarCocinero()
        {
            using (var db = new Mapeo("cocinero"))
            {
                var a = db.cocinero.ToList<UCocinero>();
                return a.ToList<UCocinero>();

            }
        }
        public List<UCocinero1> listarCocinero1()
        {
            
            using (var db = new Mapeo("cocinero1"))
            {
                var a = db.cocinero1.ToList<UCocinero1>();
                return a.ToList<UCocinero1>();

            }
        }

        public List<UPlatos> listarPlatos(Int32 id_pedido)
        {
            List<UPlatos> lista;
            using (var db = new Mapeo("platos"))
            {
                var a = from p in db.platos
                        where p.Id_pedido == id_pedido
                        select p;
                lista = a.ToList();

            }
            return lista;
        }

        public List<UPlatos1> listarPlatos1(Int32 id_pedido)
        {
            List<UPlatos1> lista;
            using (var db = new Mapeo("platos1"))
            {
                var a = from p in db.platos1
                        where p.Id_pedido == id_pedido
                        select p;
                lista = a.ToList();

            }
            return lista;
        }

        public List<UPedidoplato> obtenerPedido(UPedidoplato pedido)
        {

            using (var db = new Mapeo("pedidos"))
            {
                var a = db.pedidos.ToList<UPedidoplato>().Where(x => x.Id_pedido == pedido.Id_pedido);
                return a.ToList<UPedidoplato>();

            }
        }
        public void actualizarDespachos(UPedidoplato platos)
        {
            using (var db = new Mapeo("pedidos"))
            {
                db.pedidos.Attach(platos);
                var entry = db.Entry(platos);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void actualizarDespachos1(UPreserva reserva)
        {
            using (var db = new Mapeo("plator"))
            {
                db.platoR.Attach(reserva);
                var entry = db.Entry(reserva);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // public List<UInformeRe> listarReservas()
        //{
        //    using (var db = new Mapeo("informeRe"))
        //    {
        //        var a = db.informeRe.ToList<UInformeRe>();
        //        return a.ToList<UInformeRe>();

        //    }
        //}
        public List<Menu> listarPlat()
        {
            using (var db = new Mapeo("menu"))
            {
                var a = db.menu.ToList<Menu>();
                return a.ToList<Menu>();

            }
        }
        public List<UReservation> listadodeReservas(int id)
        {
            using (var db = new Mapeo("reserva"))
            {
                var a = db.reserva.ToList<UReservation>();
                return a.ToList<UReservation>();
            }
        }
        public List<UEmpleados> listadodePuntos(int id)
        {
            using (var db = new Mapeo("reserva"))
            {
                var a = db.user.ToList<UEmpleados>();
                return a.ToList<UEmpleados>();

            }
        }
        //public List<ULclientes> listadodeClientes()
        //{
        //    using (var db = new Mapeo("clientes"))
        //    {
        //        var a = db.clientes.ToList<ULclientes>();
        //        return a.ToList<ULclientes>();
        //    }
        //}

        public List<ULclientes> listarclientes()
        {
            using (var db = new Mapeo("clientes"))
            {
                var a = db.clientes.ToList<ULclientes>();
                return a.ToList<ULclientes>();
            }
        }
        public List<Uubicacion> ObtenerPedidos(UuserPedido user_id)
        {
            using (var db = new Mapeo("pedido"))
            {
                var a = db.pedido.OrderByDescending(x => x.Id_pedido).ToList<Uubicacion>().Where(x => x.Id_usuario == user_id.Id_usuario) ;
                return a.ToList<Uubicacion>();
            }
        }
        public List<UOtenerRe> ObtenerRes()
        {
            using (var db = new Mapeo("obtener"))
            {
                var a = db.obtener.ToList<UOtenerRe>();
                return a.ToList<UOtenerRe>();
            }
        }
        //public List<UInformeVe> listarVentas()
        //{
        //    using (var db = new Mapeo("informeVe"))
        //    {
        //        var a = db.informeVe.ToList<UInformeVe>();
        //        return a.ToList<UInformeVe>();

        //    }
        //}
        public List<ULReserva> listarResr()
        {
            using (var db = new Mapeo("istReser"))
            {
                var a = db.listReser.ToList<ULReserva>();
                return a.ToList<ULReserva>();

            }
        }

        //public void insertarReserva(UReservation reserva)
        //{
        //    using (var db = new Mapeo("reserva"))
        //    {
        //        db.reserva.Add(reserva);
        //        db.SaveChanges();
        //    }
        //}
        public void insertarContacto(UContacto contacto)
        {
            using (var db = new Mapeo("contactenos"))
            {
                db.contactenos.Add(contacto);
                db.SaveChanges();
            }
        }
        public void insertarToken(UTokenRecu token)
        {
            using (var db = new Mapeo("recuperarToken"))
            {
                db.recuperarToken.Add(token);
                db.SaveChanges();
            }
        }
        public void insertPedido(UPedidoplato pedido)
        {
            using (var db = new Mapeo("pedidos"))
            {
                db.pedidos.Add(pedido);
                db.SaveChanges();
            }
        }
        public void insertPedidoRe(UPreserva pedido)
        {
            using (var db = new Mapeo("platoR"))
            {
                db.platoR.Add(pedido);
                db.SaveChanges();
            }
        }
        public void insertUbicacion(Uubicacion pedido)
        {
            using (var db = new Mapeo("pedido"))
            {
                db.pedido.Add(pedido);
                db.SaveChanges();
            }
        }
        public List<UAutenticatio> obtenerautentication(UUsuario datos)
        {
            using (var db = new Mapeo("autentication"))
            {
                var a = db.autentication.ToList<UAutenticatio>().Where(x => x.Session == datos.Session);
                return a.ToList<UAutenticatio>();

            }
        }
        public void actualizarAutentication(UAutenticatio auten)
        {
            using (var db = new Mapeo("autentication"))
            {
                db.autentication.Attach(auten);
                var entry = db.Entry(auten);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<UEmpleados> obtenusuario(UUsuario data)
        {
            using (var db = new Mapeo("user"))
            {
                var a = db.user.ToList<UEmpleados>().Where(x => x.User_Name1 == data.User_Name1);
                return a.ToList<UEmpleados>();

            }

        }

        public void actualizarSesiones(UEmpleados auten)
        {
            using (var db = new Mapeo("user"))
            {
                db.user.Attach(auten);
                var entry = db.Entry(auten);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<UEmpleados> verificarRegistro(String correo)
        {
            using (var db = new Mapeo("user"))
            {
                var a = db.user.ToList<UEmpleados>().Where(x => x.Email == correo);
                return a.ToList<UEmpleados>();

            }

        }
    }
}