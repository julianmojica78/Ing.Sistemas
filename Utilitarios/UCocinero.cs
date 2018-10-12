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
    [Table("vista_cocinero", Schema = "usuario")]
    public class UCocinero
    {
        private Int32 id_pedido;
        private Int32 id_mesa;

        [Key]
        [Column("id_pedido")]
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        [Column("id_mesa")]
        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
    }
}
