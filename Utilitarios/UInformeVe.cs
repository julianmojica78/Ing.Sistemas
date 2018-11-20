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
    [Table("venta", Schema = "usuario")]
    public class UInformeVe
    {
        private Int32 id_pedido;
        private String nombre;
        private Int32 cantidad;
        private DateTime fecha_ingreso;
        private DateTime fecha_despacho;
        private String precio;


        [Key]
        [Column("id_pedido")]
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("cantidad")]
        public int Cantidad { get => cantidad; set => cantidad = value; }
        [Column("fecha_ingreso")]
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        [Column("fecha_despacho")]
        public DateTime Fecha_despacho { get => fecha_despacho; set => fecha_despacho = value; }
        [Column("precio")]
        public string Precio { get => precio; set => precio = value; }
    }
}
