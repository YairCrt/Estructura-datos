using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    internal class Nodo
    {
        private string dato;

        private Nodo hijo;
        private Nodo hermano;

        public string Dato { get; set; }
        public Nodo Hijo { get; set; }
        public Nodo Hermano { get; set; }

        public Nodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        } 
    }
}
