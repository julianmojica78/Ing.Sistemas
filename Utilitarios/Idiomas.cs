﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    [Serializable]
    [Table("idioma", Schema = "idioma")]
    public class Idiomas
    {
        private String nombre;
        private String terminacion;

        [Key]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("terminacion")]
        public string Terminacion { get => terminacion; set => terminacion = value; }
    }
}
