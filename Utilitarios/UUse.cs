using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{

    [Serializable]
    [Table("vista_listaempleados", Schema = "usuario")]

    public class UUse
    {
        private Int32 user_id;
        private String nombre;
        private String apellido;
        private String correo;
        private String telefono;
        private String cedula;
        private String usuario;
        private String clave;
        private String rol;
        [Key]
        [Column("codigo")]
        public int User_id { get => user_id; set => user_id = value; }
        [Column("usuario")]
        public string Usuario { get => usuario; set => usuario = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        [Column("correo")]
        public string Correo { get => correo; set => correo = value; }
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Column("cedula")]
        public string Cedula { get => cedula; set => cedula = value; }
        [Column("clave")]
        public string Clave { get => clave; set => clave = value; }
        [Column("rol")]
        public string Rol { get => rol; set => rol = value; }
    }

}
