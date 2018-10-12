using System;
using System.Collections.Generic;
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
                user.Mensaje = "<script type='text/javascript'>alert('" + mensaje.Extension.ToString() + "');window.location=\"Registro.aspx\"</script>";
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

        public UUsuario modificarUsuario(UEmpleados usuario)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();
            dao.modificarUsuario(usuario);
            user.Mensaje = "<script type='text/javascript'>alert('" + user.A.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";


            return user;

        }
        public UUsuario eliminarUsuario(UEmpleados usuario)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();
            dao.eliminarUsuario(usuario);
            user.Mensaje = "<script type='text/javascript'>alert('" + user.Mensaje.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";


            return user;

        }

    }
}
