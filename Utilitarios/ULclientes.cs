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
    [Table("vista_listaclientes", Schema = "usuario")]
    public class ULclientes
    {
        private int codigo;
        private String usuario;
        private String nombre;
        private String apellido;
        private String correo;
        private String telefono;
        private int puntos;

        [Key]
        [Column("codigo")]
        public int Codigo { get => codigo; set => codigo = value; }
        [Column("usuario")]
        public string Usuario { get => usuario; set => usuario = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        [Column("correo")]
        public string Correo { get => correo; set => correo = value; }
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Column("puntos")]
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
