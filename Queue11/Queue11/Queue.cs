using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue11
{
    internal class Queue
    {
        Nodo ancla;

        Nodo trabajo;

        public Queue()
        {
            ancla = new Nodo();

            //Al ser una cola vacio su siguiente es null
            ancla.Siguiente = null;
        }

        //Recorriendo todo el queue
        public void Transversa()
        {
            trabajo = ancla;

            //Se recorre hasta encontrar el final
            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.Write("<-{0} ", d);
            }
            Console.WriteLine();

        }

        public void Enqueue(int pDato)
        {
            trabajo = ancla;

            //Se recorre hasta encontrar el final
            while(trabajo.Siguiente != null) 
            {
                //Avanza trabajo
                trabajo = trabajo.Siguiente;
            }

            //Se crea el nuevo nodo
            Nodo temp = new Nodo();

            //Inserta el dato
            temp.Dato = pDato;

            temp.Siguiente = null;

            //se liga el utlimo nodo encontrado con el recien creado 
            trabajo.Siguiente = temp;
        }

        public int Dequeue()
        {
            int valor = 0;

            //Solo si hay elementos en el queue
            if(ancla.Siguiente != null)
            {
                //Se obtiene el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                //Se saca del queue
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        public int Peek()
        {
            int valor = 0;

            if( ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }

    }
}
