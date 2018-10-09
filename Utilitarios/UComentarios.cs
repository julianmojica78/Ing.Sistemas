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
    [Table("comentarios", Schema = "usuario")]
    public class UComentarios
    {
        private String descripcion;
        private Int32 user_id;
        //private String mensaje;

        [Key]
        [Column("detalle")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Column("id_usuario")]
        public int User_id { get => user_id; set => user_id = value; }
        //public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
