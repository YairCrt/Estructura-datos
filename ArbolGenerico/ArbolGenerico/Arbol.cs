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
        //Transversa PostOrder
        public void TransversaPostO(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            //Se procesa al Hijo
            if (pNodo.Hijo != null)
            {
                i++;
                TransversaPostO(pNodo.Hijo);
                i--;
            }

            //Si tiene hermanos se procesan
            if(pNodo.Hermano != null)
            {
                TransversaPostO(pNodo.Hermano);
            }

            //Luego se procesa el nodo Raiz
            for(int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(pNodo.Dato);
        }

        //Buscar
        public Nodo Buscar(string pDato, Nodo pNodo)
        {
            Nodo encontrado = null;

            if (pNodo == null)
                return encontrado;
            
            //CompareTo sirve para comparar cadenas,devuelve 0 cuando ambas cadenas sean iguales
            if(pNodo.Dato.CompareTo(pDato) == 0)
            {
                encontrado = pNodo;
                return encontrado;
            }

            //Luego se procesa al hijo para seguir buscando el nodo
            if(pNodo.Hijo != null)
            {
                //Recursividad
                encontrado = Buscar(pDato, pNodo.Hijo);
                if(encontrado != null)
                {
                    return encontrado;
                }
            }

            //Si hay hermanos se busca el nodo
            if(pNodo.Hermano != null)
            {
                //Recursividad
                encontrado = Buscar(pDato, pNodo.Hermano);
                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;
        }

    }
}
