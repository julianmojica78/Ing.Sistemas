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
    [Table("vista_mes", Schema = "usuario")]
    public class UVistames
    {
        private Int32 cantidad;

        [Key]
        [Column("cantidad")]
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
