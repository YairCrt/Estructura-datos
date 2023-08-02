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
            if (pNodo == null)
            {
                temp = new Nodo();
                temp.Dato = pDato;

                return temp;
            }

            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }
            if (pDato > pNodo.Dato)
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
            for (int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(pNodo.Dato);

            //Si se tiene izq, se procesa el lado izq
            if (pNodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(pNodo.Izq);
                i--;
            }

            //Si se tiene der, se procesa el lado der
            if (pNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.Der);
                i--;
            }
        }

        //Encontrar el valor minimo del arbol
        public int EncuentraMinimo(Nodo pNodo)
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return minimo;
        }

        //Encontrar el valor maximo del arbol
        public int EncuentraMaximo(Nodo pNodo)
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }

            return maximo;
        }

        //Encontrar el Nodo minimo(Referencia al nodo)
        public Nodo EncuentraNodoMin(Nodo pNodo)
        {
            if (pNodo == null)
                return null;

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }
            return trabajo;
        }

        //Encontrar el Nodo maximo(Referencia al nodo)
        public Nodo EncuentraNodoMax(Nodo pNodo)
        {
            if (pNodo == null)
                return null;

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }
            return trabajo;
        }

        //Transversa Ordenada (InOrder)
        public void TransversaOrdenada(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            //Si tiene izq, se procesa izq
            if (pNodo.Izq != null)
            {
                i++;
                TransversaOrdenada(pNodo.Izq);
                i--;
            }
            Console.Write("{0} ", pNodo.Dato);

            //Si tiene der, se procesa der
            if (pNodo.Der != null)
            {
                i++;
                TransversaOrdenada(pNodo.Der);
                i--;
            }

        }

        //Encontrar el padre de algun Nodo en particular
        public Nodo BuscarPadre(int pDato, Nodo pNodo)
        {
            Nodo temp = null;//Nodo de resultado

            if (pNodo == null)
                return null; //Significa que no existe el nodo y regresa null

            //Se verifica si es el padre
            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo;

            if (pNodo.Der != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;

            //SI tiene izq, se procesa
            if (pNodo.Izq != null && pDato < pNodo.Dato)
            {
                //Recursividad
                temp = BuscarPadre(pDato, pNodo.Izq);
            }
            //Si tiene der, se procesa
            if (pNodo.Der != null && pDato > pNodo.Der.Dato)
            {
                //Recursividad
                temp = BuscarPadre(pDato, pNodo.Der);
            }

            return temp;
        }

        //Metodo para borrar un nodo
        public Nodo Borrar(Nodo pNodo, int pDato)
        {
            Nodo temp = null;
            if(pNodo == null) 
                return pNodo;
            else if(pDato < pNodo.Dato)
            {
                pNodo.Izq = Borrar(pNodo.Izq, pDato);
            }
            else if(pDato > pNodo.Dato)
            {
                pNodo.Der = Borrar(pNodo.Der, pDato);
            }
            else
            {
                //Caso sin hijos
                if(pNodo.Izq == null && pNodo.Der == null)
                {
                    pNodo = null;
                    return pNodo;
                }
                //Caso un hijo, hacer el caso espejo
                else if(pNodo.Izq == null)
                {
                    temp = BuscarPadre(pDato, pNodo);
                    temp.Der = pNodo.Der;
                    return temp;
                }
                //Caso dos hijos
                else
                {
                    trabajo = EncuentraNodoMin(pNodo.Der);
                    pNodo.Dato = trabajo.Dato;
                    pNodo.Der = Borrar(pNodo.Der, trabajo.Dato);

                    return pNodo;
                }

            }
            return pNodo;
        }

    }


}
