using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
    [Serializable]
    [Table("ofertas", Schema = "usuario")]
    public class Ofertas
    {
        private int id_ofertas;
        private String nombre;  
        private String descripcion;
        private String precio;
        private String oferta;
        private String imagen;

        [Key]
        [Column("id_ofertas")]
        public int Id_ofertas { get => id_ofertas; set => id_ofertas = value; }
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