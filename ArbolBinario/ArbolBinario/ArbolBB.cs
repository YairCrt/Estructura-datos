using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class ArbolBB
    {
        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;

        public ArbolBB()
        {
            raiz = null;
        }

        internal Nodo Raiz { get; set; }

        //Insertar(metodo recursivo)
        public Nodo Insertar(int pDato, Nodo pNodo)
        {
            Nodo temp = null;

            //Si no hay a quien insertar entonces creamos el nodo
            if(pNodo == null)
            {
                temp = new Nodo();
                temp.Dato = pDato;

                return temp;
            }

            if(pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }
            if(pDato > pNodo.Dato)
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);
            }

            return pNodo;
        }

        //Transversa
        public void Transversa(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            //Se procesa la raiz
            for(int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(pNodo.Dato);

            //Si se tiene izq, se procesa el lado izq
            if(pNodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(pNodo.Izq);
                i--;
            }

            //Si se tiene der, se procesa el lado der
            if(pNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.Der);
                i--;
            }
        }

    }


}
