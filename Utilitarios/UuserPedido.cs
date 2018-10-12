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
    [Table("pedido", Schema = "usuario")]
    public class UuserPedido
    {
        private Int32 id_pedido;
        private Int32 id_plato;
        private Int32 cantidad;
        private Int32 id_mesero;
        private Int32 id_mesa;
        private Int32 id_usuario;
        private Int32 id_pedido1;

        [Key]
        [Column("id_pedido")]
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public int Id_plato { get => id_plato; set => id_plato = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_mesero { get => id_mesero; set => id_mesero = value; }
        [Column("id_mesa")]
        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        [Column("id_usuario")]
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_pedido1 { get => id_pedido1; set => id_pedido1 = value; }
    }
}

