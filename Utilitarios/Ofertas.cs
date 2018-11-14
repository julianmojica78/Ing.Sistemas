using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
    [Serializable]
    [Table("ofertas", Schema = "usuario")]
    public class Ofertas
    {
        private int id_plato;
        private String nombre;
        private String descripcion;
        private String precio;
        private String oferta;
        private String imagen;

        [Key]
        [Column("id_ofertas")]
        public int Id_plato { get => id_plato; set => id_plato = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Column("precio")]
        public string Precio { get => precio; set => precio = value; }
        [Column("oferta")]
        public string Oferta { get => oferta; set => oferta = value; }
        [Column("imagen")]
        public string Imagen { get => imagen; set => imagen = value; }

    }
}