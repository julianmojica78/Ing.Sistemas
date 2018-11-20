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
    [Table("verificar", Schema = "usuario")]
    public class UVerificar
    {
        private Int32 id;
        private String dia;
        private Int32 id_mesa;
        private Int32 estado;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("dia")]
        public string Dia { get => dia; set => dia = value; }
        [Column("id_mesa")]
        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        [Column("estado")]
        public int Estado { get => estado; set => estado = value; }
    }
}
