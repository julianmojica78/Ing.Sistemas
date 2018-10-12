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
    [Table("token_reserva", Schema = "usuario")]
    public class UTokenRe
    {
        private Int32 id;
        private Int32 reserva_id;
        private String token;
        private DateTime fecha_creado;
        private DateTime fecha_vigencia;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("reserva_id")]
        public int Reserva_id { get => reserva_id; set => reserva_id = value; }
        [Column("token")]
        public string Token { get => token; set => token = value; }
        [Column("fecha_creado")]
        public DateTime Fecha_creado { get => fecha_creado; set => fecha_creado = value; }
        [Column("fecha_vigencia")]
        public DateTime Fecha_vigencia { get => fecha_vigencia; set => fecha_vigencia = value; }
    }
}
