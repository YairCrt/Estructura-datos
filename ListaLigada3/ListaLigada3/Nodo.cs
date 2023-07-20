using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada3
{
    internal class Nodo
    {
        //dato o datos que guarda el nodo
        private int dato;

        //variable de referencia es usada para apuntar al nodo siguente
        private Nodo siguiente = null;

        //propiedades
        public int Dato { get => dato; set => dato = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value;}

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
