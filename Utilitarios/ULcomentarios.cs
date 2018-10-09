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
    [Table("vista_comentarios", Schema = "usuario")]
    public class ULcomentarios
    {
        private String user_name;
        private Int32 id_comentarios;
        private String detalle;

        [Key]
        [Column("user_name")]
        public string User_name { get => user_name; set => user_name = value; }
        [Column("id_comentarios")]
        public int Id_comentarios { get => id_comentarios; set => id_comentarios = value; }
        [Column("detalle")]
        public string Detalle { get => detalle; set => detalle = value; }
    }
}
