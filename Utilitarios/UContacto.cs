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
    [Table("contacto", Schema = "usuario")]
    public class UContacto
    {
        private int id;
        private String nombre;
        private String email;
        private String detalle;
        private String telefono;

        [Key]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("email")]
        public string Email { get => email; set => email = value; }
        [Column("detalle")]
        public string Detalle { get => detalle; set => detalle = value; }
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Column("id_contactenos")]
        public int Id { get => id; set => id = value; }
    }
}
