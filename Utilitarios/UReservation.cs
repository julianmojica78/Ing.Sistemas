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
    [Table("reservas", Schema = "usuario")]
    public class UReservation
    {

        private Int32 id_reserva;
        private Int32 id_mesa;
        private String dia;
        private Int32 id_usuario;
        private Int32? puntos;
        private Int32? estado;

        [Key]
        [Column("id_reserva")]
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        [Column("id_mesa")]
        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        [Column("dia")]
        public string Dia { get => dia; set => dia = value; }
        [Column("id_usuario")]
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        [Column("puntos")]
        public int? Puntos { get => puntos; set => puntos = value; }
        [Column("estado")]
        public int? Estado { get => estado; set => estado = value; }
    }
}
