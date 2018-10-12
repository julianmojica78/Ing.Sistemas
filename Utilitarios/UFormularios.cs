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
    [Table("formulario", Schema = "idioma")]
    public class UFormularios
    {
        private String nombre;
        private String url;
        private Int32 id;

        [Key]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("url")]
        public string Url { get => url; set => url = value; }
        [Column("id")]
        public int Id { get => id; set => id = value; }
    }
}
