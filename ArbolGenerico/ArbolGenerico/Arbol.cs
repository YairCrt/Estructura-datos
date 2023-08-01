using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    internal class Arbol
    {
        private Nodo raiz;
        private Nodo trabajo;
        private int i = 0;

        public Arbol()
        {
            raiz = new Nodo();
        }

        public Nodo Insertar(string pDato, Nodo nodo)
        {
            //Si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if(nodo == null)
            {
                raiz = new Nodo();
                raiz.Dato = pDato;

                //No hay hijo
                raiz.Hijo = null;

                //No hay hermano
                raiz.Hermano = null;

                return raiz;

            }
            //Verificamos si no tiene hijo
            //Insertamos el dato como hijo
            if(nodo.Hijo == null)
            {
                Nodo temp = new Nodo();

                temp.Dato = pDato;

                //Conectamos el nuevo nodo como hijo
                nodo.Hijo = temp;

                return temp;
            }
            else //Ya tiene Hijo, se inserta  como Hermano
            {
                trabajo = nodo.Hijo;

                //Avanzamos hasta el ultimo hermano
                while(trabajo.Hermano!= null) 
                {
                    trabajo = trabajo.Hermano;
                }

                //Creamos nodo temporal
                Nodo temp = new Nodo();

                temp.Dato = pDato;

                //Unimos el temp al ultimo hermano
                trabajo.Hermano = temp;

                return temp;
            }
        }

        //Transversa PreOrder
        public void TransversaPreO(Nodo pNodo)
        {
            //Caso base, cuando no hay nodos
            if(pNodo == null)
            {
                return;
            }
            //Se procesa primero la raiz
            //for con fines esteticos para espaciar la raiz y sus subarboles
            for(int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(pNodo.Dato);

            // Caso inductivo. Se procesa al hijo
            //Funcion recursiva
            if(pNodo.Hijo != null)
            {
                i++;
                TransversaPreO(pNodo.Hijo);
                i--;
            }

            //Si tiene hermanos se procesan
            if(pNodo.Hermano != null)
            {
                TransversaPreO(pNodo.Hermano);
            }

        }

    }
}
