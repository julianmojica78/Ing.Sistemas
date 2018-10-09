using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
    [Serializable]
    [Table("platos", Schema = "usuario")]
    public class Menu
    {
        private int id_plato;
        private String nombre;
        private String descripcion;
        private String precio;
        private String imagen;
        //private String a;
        //private String b;
        //private String c;
        //private String d;
        //private String e;
        //private String f;
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
        //public string A { get => a; set => a = value; }
        //public string B { get => b; set => b = value; }
        //public string C { get => c; set => c = value; }
        //public string D { get => d; set => d = value; }
        //public string E { get => e; set => e = value; }
        //public string F { get => f; set => f = value; }
    }
}