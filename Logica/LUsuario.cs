using System;
using System.Collections.Generic;
using Datos;
using Utilitarios;

namespace Logica
{
    public class LUsuario
    {
        public UUsuario insertarUsuario(UEmpleados usuario)
        {
            DUser dao = new DUser();
            UUsuario user = new UUsuario();
            dao.insertUsuario(usuario);
            user.Mensaje = "<script type='text/javascript'>alert('" + user.B.ToString() + "');window.location=\"ListaEmpleados.aspx\"</script>";


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
