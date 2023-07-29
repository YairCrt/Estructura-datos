using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue11
{
    internal class Nodo
    {
        private int dato;

        private Nodo siguiente = null;

        public int Dato { get; set; }
        internal Nodo Siguiente { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
