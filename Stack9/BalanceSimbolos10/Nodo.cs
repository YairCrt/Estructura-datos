using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSimbolos10
{
    internal class Nodo
    {
        //Dato(s) que guarda el nodo
        private char dato;

        //Variable de referencia es usada para apuntar al nodo siguiente
        private Nodo siguiente = null;

        //Propiedades
        public char Dato { get; set; }
        internal Nodo Siguiente { get; set; }

        //Impresion
        public override string ToString()
        {
            return string.Format("[{0}]", dato); 
        }
    }
}
