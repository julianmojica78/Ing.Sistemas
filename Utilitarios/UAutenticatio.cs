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
    [Table("autentication", Schema = "seguridad")]
    public class UAutenticatio
    {
        private Int32 id;
        private Int32 user_id;
        private String ip;
        private String mac;
        private DateTime fecha_inicio;
        private String session;
        private DateTime? fecha_fin;


        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("user_id")]
        public int User_id { get => user_id; set => user_id = value; }
        [Column("ip")]
        public string Ip { get => ip; set => ip = value; }
        [Column("mac")]
        public string Mac { get => mac; set => mac = value; }
        [Column("fecha_inicio")]
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        [Column("session")]
        public string Session { get => session; set => session = value; }
        [Column("fecha_fin")]
        public DateTime? Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
    }
}
