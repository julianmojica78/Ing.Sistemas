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
    [Table("reservaplatos", Schema = "usuario")]
    public class UPreserva
    {
        private int id_reserva;
        private int id_plato;
        private int cantidad;
        private String fecha_ingreso;
        private String fecha_despacho;
        private int id;

        [Key]
        [Column("id_reserva")]
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        [Column("id_plato")]
        public int Id_plato { get => id_plato; set => id_plato = value; }
        [Column("id_cantidad")]
        public int Cantidad { get => cantidad; set => cantidad = value; }
        [Column("fecha_ingreso")]
        public string Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        [Column("fecha_despacho")]
        public string Fecha_despacho { get => fecha_despacho; set => fecha_despacho = value; }
        [Column("id")]
        public int Id { get => id; set => id = value; }
    }
}
