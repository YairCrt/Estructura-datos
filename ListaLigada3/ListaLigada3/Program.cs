using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaLigada miLista = new ListaLigada();

            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);

            miLista.Transversa();
            //Console.WriteLine(miLista.EstaVacio());

            //miLista.Vaciar();

            //miLista.Transversa();
            //Console.WriteLine(miLista.EstaVacio());
            //Nodo encontrado = miLista.Buscar(75);
            //Console.WriteLine(encontrado);

            //Console.WriteLine(miLista.BuscarIndice(52));
            //Console.WriteLine(miLista.BuscarAnterior(7));

            //miLista.Borrar(522);
            //miLista.Insertar(7,20);
            //miLista.InsertarInicio(20);
            miLista.Transversa();

            Console.Read();
        }
    }
}
