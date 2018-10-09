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
    [Table("usuario", Schema = "usuario")]
    public class UEmpleados
    {
        private Int32 user_id;
        private String nombre;
        private String apellido;
        private String email;
        private String telefono;
        private String cedula;
        private int? puntos;
        private Int32 id_Rol;
        private String User_Name;
        private String clave;
        private String rclave;
        private String session;
        private Int32 sesiones;
        private Int32 intentos;

        [Key]
        [Column("id_usuario")]
        public int User_id { get => user_id; set => user_id = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        [Column("email")]
        public string Email { get => email; set => email = value; }
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Column("cedula")]
        public string Cedula { get => cedula; set => cedula = value; }
        [Column("puntos")]
        public int? Puntos { get => puntos; set => puntos = value; }
        [Column("id_rol")]
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        [Column("user_name")]
        public string User_Name1 { get => User_Name; set => User_Name = value; }
        [Column("clave")]
        public string Clave { get => clave; set => clave = value; }
        [Column("rclave")]
        public string Rclave { get => rclave; set => rclave = value; }
        [Column("session")]
        public string Session { get => session; set => session = value; }
        [Column("sesiones")]
        public int Sesiones { get => sesiones; set => sesiones = value; }
        [Column("intentos_erroneos")]
        public int Intentos { get => intentos; set => intentos = value; }
    }
}
