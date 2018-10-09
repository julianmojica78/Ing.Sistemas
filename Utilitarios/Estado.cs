using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class Estado
    {
        private Boolean esstado;
        private Boolean estado1;
        private String idioma;

        public bool Esstado { get => esstado; set => esstado = value; }
        public bool Estado1 { get => estado1; set => estado1 = value; }
        public string Idioma { get => idioma; set => idioma = value; }
    }
}
