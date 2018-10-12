﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilitarios
{
    [Serializable]
    [Table("mesas", Schema = "usuario")]
    public class Mesas
    {
        private int id_mesas;
        private String ubicacion;
        private int cantidad;

        [Key]
        [Column("id_mesa")]
        public int Id_mesas { get => id_mesas; set => id_mesas = value; }
        [Column("ubicacion")]
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        [Column("cantidad")]
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}