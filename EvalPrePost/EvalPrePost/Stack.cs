using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalPrePost
{
    internal class Stack
    {
        //Ancla o encabezado del stack
        private Nodo ancla;

        //Variable de referencia nos ayuda a trabajar con el stack
        private Nodo trabajo;

        public Stack()
        {
            //Instanciamos el ancla 
            ancla = new Nodo();

            //Como es un stack vacio su siguiente es null
            ancla.Siguiente = null;
        }

        //Metodo para saber si esta vacio el stack
        public bool StackVacio()
        {
            if (ancla.Siguiente == null)
            {
                return true;
            }
            else
                return false;
        }

        //Push
        public void Push(int pDato)
        {
            //Nodo temporal
            Nodo temp = new Nodo();
            temp.Dato = pDato;

            //Conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            //Conectamos el ancla a temporal
            ancla.Siguiente = temp;
        }

        //Pop
        public int Pop()
        {
            int valor = 0;

            //Sólo si hay elementos en el stack
            if (ancla.Siguiente != null)
            {
                //Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                //Lo sacamos del stack
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        //Peek
        public int Peek()
        {
            int valor = 0;

            //Solo si hay elementos en el stack
            if (ancla.Siguiente != null)
            {
                //Obtenemos el dato
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }

        //Transversa
        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
        }
    }
}
