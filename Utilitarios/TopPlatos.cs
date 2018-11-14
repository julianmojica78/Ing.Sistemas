using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
    [Serializable]
    [Table("topPlatos", Schema = "usuario")]
    public class TopPlatos
    {
        private int id_plato;
        private String nombre;
        private String descripcion;
        private String precio;
        private String imagen;

        [Key]
        [Column("id_plato")]
        public int Id_plato { get => id_plato; set => id_plato = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Column("precio")]
        public string Precio { get => precio; set => precio = value; }
        [Column("imagen")]
        public string Imagen { get => imagen; set => imagen = value; }
    }
}