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
    public class UReservaplatos
    {
        private Int32 id_reserva;
        private DateTime fecha_despacho;
        [Key]
        [Column("id_reserva")]
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        [Column("fecha_despacho")]
        public DateTime Fecha_despacho1 { get => fecha_despacho; set => fecha_despacho = value; }
    }
}
