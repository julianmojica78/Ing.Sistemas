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
    [Table("pedidoplato", Schema = "usuario")]
    public class UPedidoplato
    {
        private Int32 id_pedido;
        private DateTime fecha_despacho;

        [Key]
        [Column("id_pedido")]
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        [Column("fecha_despacho")]
        public DateTime Fecha_despacho { get => fecha_despacho; set => fecha_despacho = value; }

     
    }
}
