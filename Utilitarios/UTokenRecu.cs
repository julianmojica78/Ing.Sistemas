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
    [Table("token_recuperacion", Schema = "usuario")]
    public class UTokenRecu
    {
        private int id;
        private int user_id;
        private String text;
        private DateTime fecha_creado;
        private DateTime fecha_vigencia;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("user_id")]
        public int User_id { get => user_id; set => user_id = value; }
        [Column("token")]
        public string Text { get => text; set => text = value; }
        [Column("fecha_creado")]
        public DateTime Fecha_creado { get => fecha_creado; set => fecha_creado = value; }
        [Column("fecha_vigencia")]
        public DateTime Fecha_vigencia { get => fecha_vigencia; set => fecha_vigencia = value; }
    }
}
