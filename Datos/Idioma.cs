using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Utilitarios;

namespace Datos
{
    public class Idioma
    {
        public DataTable obtenerIdioma(Int32 formulario, Int32 idioma)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("idioma.f_obtener_idioma_formulario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_formulario_id", SqlDbType.Int).Value = formulario;
                dataAdapter.SelectCommand.Parameters.Add("_idioma_id", SqlDbType.Int).Value = idioma;

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

        public DataTable obtenerFormulario()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("idioma.f_obtener_formulario", conection);
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
        public void agregarIdioma(UIdioma datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("idioma.f_insertar_idioma", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_terminacion", NpgsqlDbType.Text).Value = datos.Terminacion;

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

        public DataTable validarIdioma(UAidioma datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("idioma.f_validar_idioma", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", SqlDbType.VarChar, 100).Value = datos.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_terminacion", SqlDbType.VarChar, 10).Value = datos.Terminacion;

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

        public DataTable validarControl(UControles datos)
        {
            DataTable Usuario = new DataTable();
            SqlConnection conection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("idioma.f_validar_controles", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_idioma", SqlDbType.Int).Value = datos.Idioma_id;
                //dataAdapter.SelectCommand.Parameters.Add("_formulario", NpgsqlDbType.Integer).Value = datos.Formulario;
                dataAdapter.SelectCommand.Parameters.Add("_control", SqlDbType.VarChar, 100).Value = datos.Control;
                //dataAdapter.SelectCommand.Parameters.Add("_texto", NpgsqlDbType.Text).Value = datos.Texto;

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
        public void agregarControl(UIdioma datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("idioma.f_insertar_controles", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_idioma", NpgsqlDbType.Integer).Value = datos.Idioma;
                dataAdapter.SelectCommand.Parameters.Add("_formulario", NpgsqlDbType.Integer).Value = datos.Formulario;
                dataAdapter.SelectCommand.Parameters.Add("_control", NpgsqlDbType.Text).Value = datos.Control;
                dataAdapter.SelectCommand.Parameters.Add("_texto", NpgsqlDbType.Text).Value = datos.Texto;
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

        public DataTable obtenerControlador(Int32 formulario, Int32 idioma)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("idioma.f_obtener_idioma_controles", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_formulario_id", NpgsqlDbType.Integer).Value = formulario;
                dataAdapter.SelectCommand.Parameters.Add("_idioma_id", NpgsqlDbType.Integer).Value = idioma;

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

        public void modificarTexto(UIdioma datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("idioma.f_modificar_idioma", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = datos.Id;
                dataAdapter.SelectCommand.Parameters.Add("_texto", NpgsqlDbType.Text).Value = datos.Texto;
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

        public void eliminarIdioma(UIdioma datos)
        {
            DataTable Registro = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("idioma.f_eliminar_idioma", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = datos.Id;
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

        public void insertIdioma(UAidioma idioma)
        {
            using (var db = new Mapeo("idioma"))
            {
                db.idioma.Add(idioma);
                db.SaveChanges();
            }
        }
        public void insertControl(UControles idioma)
        {
            using (var db = new Mapeo("controles"))
            {
                db.controles.Add(idioma);
                db.SaveChanges();
            }
        }
        public List<UAidioma> listarIdioma()
        {
            using (var db = new Mapeo("idioma"))
            {
                var a = db.idioma.ToList<UAidioma>();
                return a.ToList<UAidioma>();

            }

        }

        public List<UVistames> listarVmes()
        {
            using (var db = new Mapeo("vmesas"))
            {
                var a = db.vmesas.ToList<UVistames>();
                return a.ToList<UVistames>();

            }

        }
        public List<UControles> listarControl(Int32 formulario, Int32 idioma)
        {
            List<UControles> lista;
            using (var db = new Mapeo("controles"))
            {
                var a = from p in db.controles
                        where p.Formulario_id == formulario
                        where p.Idioma_id == idioma
                        select p;
                lista = a.ToList();      
                
            }
            return lista;
        }

        public List<UFormularios> listarFormulario()
        {
            using (var db = new Mapeo("formulario"))
            {
                var a = db.formulario.ToList<UFormularios>();
                return a.ToList<UFormularios>();

            }


        }
        public void modificarIdioma(UControles idioma)
        {
            using (var db = new Mapeo("controles"))
            {
                var entry = db.Entry(idioma);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void eliminarIdiomas(UAidioma idioma)
        {
            using (var db = new Mapeo("idioma"))
            {
                db.idioma.Attach(idioma);
                db.Entry(idioma).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

    }


}
