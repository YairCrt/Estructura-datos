using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada3
{
    internal class ListaLigada
    {
        //Ancla o encabezado de la lista(Inicio de la lista ligada)
        private Nodo ancla;

        //variable de referencia nos ayuda a trabajar con la lista
        private Nodo trabajo;

        //nos ayuda con ciertas operaciones de la lista
        private Nodo trabajo2;

        public ListaLigada()
        {
            //Instanciamos el ancla
            ancla = new Nodo();
            //Como es una lista vacia su siguente es null
            ancla.Siguiente = null;
        }

        //Recorrer toda la lista
        public void Transversa()
        {
            //Trabajo al incio
            trabajo = ancla;

            //Recorremos hasta encontrar el final
            while(trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //Obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.Write("{0}, ", d);
            }

            Console.WriteLine();
        }

        //Adiciona un nuevo elemento (siempre va al final)
        public void Adicionar(int pDato)
        {
            trabajo = ancla;

            //Recorrer hasta encontrar el final
            while(trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }
            //Creamos el nuevo nodo
            Nodo temp = new Nodo();

            //Insertamos el dato que queremos agregar a la lista
            temp.Dato = pDato;

            //Finalizamos con null para indicar el final de la lista
            temp.Siguiente = null;

            //ligamos el ultimo nodo encontrado con el recien agregado
            trabajo.Siguiente = temp;
        }

        //Vaciar la lista
        public void Vaciar()
        {
            ancla.Siguiente = null;
            //El recolector de basura se encarga de liberar la memoria
        }

        //Lista vacia
        public bool EstaVacio()
        {
            if(ancla.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Regresa el nodo con la primera ocurrencia del dato
        public Nodo Buscar(int pDato)
        {
            if (EstaVacio() == true)
                return null;

            trabajo2 = ancla;

            //Se recorre para encontrar el dato
            while(trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                //Al encontrar el dato lo regresamos
                if (trabajo2.Dato == pDato)
                    return trabajo2;
            }

            //Si no se encuentra, se regresa null
            return null;
        }

        //Busca el indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int pDato)
        {
            int n = - 1;

            trabajo = ancla;

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if(trabajo.Dato == pDato)
                {
                    return n;
                }
            }
            return -1;
        }

        //Encuentra al nodo anterior
        //Si esta en el primer node se regresa el ancla
        //Si el dato no existe se regresa el ultimo nodo
        public Nodo BuscarAnterior(int pDato)
        {
            trabajo2 = ancla;

            while(trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
            {
                trabajo2 = trabajo2.Siguiente;
            }
            return trabajo2;
        }

        //Borra la primera ocurrencia del dato
        public void Borrar(int pDato)
        {
            //Verificamos que se tengan datos
            if (EstaVacio() == true)
                return;

            //Buscamos los nodos con los que trabajaremos
            Nodo anterior = BuscarAnterior(pDato);
            Nodo encontrado = Buscar(pDato);

            //Si no hay nodo a borrar, salimos
            if (encontrado == null)
                return;
            
            //Brincamos el nodo para conectar el valor anterior con el valor siguiente del nodo que se borrara
            anterior.Siguiente = encontrado.Siguiente;

            //Quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        //Inserta el dato pValor despues de la primera ocurrencia del dato pasado pDonde
        public void Insertar(int pDonde, int pValor)
        {
            //Encontramos la posicion donde vamos a insertar
            trabajo = Buscar(pDonde);

            //Verificamos que exista donde vamos a insertar
            if (trabajo == null)
                return;

            //Creamos el nodo temporal a insertar
            Nodo temp = new Nodo();
            temp.Dato = pValor;

            //Conectamos el temporal a la lista
            temp.Siguiente = trabajo.Siguiente;

            //Conectamos trabajo a temporal
            trabajo.Siguiente = temp;
        }
        //Insertar al Inicio
        public void InsertarInicio(int pValor)
        { 
            Nodo temp = new Nodo();
            temp.Dato = pValor;

            temp.Siguiente = ancla.Siguiente;
            ancla.Siguiente = temp;

        }
    }
}
