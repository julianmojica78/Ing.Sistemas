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
    [Table("vista_listaclientes", Schema = "usuario")]
    public class ULclientes
    {
        private int id_usuario;
        private String user_name;
        private String nombre;
        private String apellido;
        private String email;
        private String telefono;
        private int puntos;

        [Key]
        [Column("id_usuario")]
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        [Column("user_name")]
        public string User_name { get => user_name; set => user_name = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        [Column("email")]
        public string Email { get => email; set => email = value; }
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Column("puntos")]
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
