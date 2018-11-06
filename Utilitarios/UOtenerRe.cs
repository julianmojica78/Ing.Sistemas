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
    [Table("vista_re", Schema = "usuario")]
    public class UOtenerRe
    {
        private String user_name;
        private String ubicacion;
        private DateTime dia;

        [Key]
        [Column("user_name")]
        public string User_name { get => user_name; set => user_name = value; }
        [Column("ubicacion")]
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        [Column("dia")]
        public DateTime Dia { get => dia; set => dia = value; }
    }
}
