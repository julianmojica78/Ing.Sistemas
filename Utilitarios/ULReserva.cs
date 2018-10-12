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
    [Table("vista_reservaplato", Schema = "usuario")]
    public class ULReserva
    {
        private int id_reserva;
        private String nombre;
        private int cantidad;
        private String fecha_ingreso;
        private String fecha_despacho;

        [Key]
        [Column("id_reserva")]
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("cantidad")]
        public int Cantidad { get => cantidad; set => cantidad = value; }
        [Column("fecha_ingreso")]
        public string Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        [Column("fecha_despacho")]
        public string Fecha_despacho { get => fecha_despacho; set => fecha_despacho = value; }
    }
}
