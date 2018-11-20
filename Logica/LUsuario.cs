using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using Datos;
using Utilitarios;

namespace Logica
{
    public class LUsuario
    {
        public UUsuario insertarUsuario(UEmpleados usuario, UUsuario mensaje)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();

            System.Data.DataTable validez = dao.validarRegistro(usuario.User_Name1, usuario.Email);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                dao.insertUsuario(usuario);
                user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('Correo o Usuario ya existe');window.location=\"Registro.aspx\"</script>";
            }

            return user;

        }

        public UUsuario insertUsuario(UEmpleados usuario, UUsuario mensaje)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();

            System.Data.DataTable validez = dao.validarRegistro(usuario.User_Name1, usuario.Email);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                dao.insertUsuario(usuario);
                user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"Loggin.aspx\"</script>";

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Extension.ToString() + "');window.location=\"Registro.aspx\"</script>";
            }

            return user;

        }

        public List<UUse> obtenerEmpleados()
        {
            DUser dao = new DUser();
            return dao.listarEmpleados();
        }

        public UUsuario modificarUsuario(UEmpleados usuario , UUsuario mensaje)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();
            dao.modificarUsuario(usuario);
            user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";


            return user;

        }
        public UUsuario eliminarUsuario(UEmpleados usuario,UUsuario mensaje)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();
            dao.eliminarUsuario(usuario);
            user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";


            return user;

        }

        public List<UEmpleados> obtenerAu()
        {
            DUser dao = new DUser();
            return dao.listarau();
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
    }
}
