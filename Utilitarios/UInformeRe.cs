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
    [Table("vista_reservas", Schema = "usuario")]
    public class UInformeRe
    {
        private Int32 id_reserva;
        private String user_name;
        private DateTime dia;

        [Key]
        [Column("id_reserva")]
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        [Column("user_name")]
        public string User_name { get => user_name; set => user_name = value; }
        [Column("dia")]
        public DateTime Dia { get => dia; set => dia = value; }

    
    }
}
