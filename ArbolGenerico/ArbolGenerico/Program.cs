using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            //Primer nodo para que "a" sea la raiz
            Nodo raiz = arbol.Insertar("a", null);
            
            //Le insertamos los nodos siguientes a la raiz
            arbol.Insertar("b", raiz);
            arbol.Insertar("c", raiz);

            //arbol.TransversaPreO(raiz);

            Nodo n = arbol.Insertar("d", raiz);
            arbol.Insertar("h", n);

            n = arbol.Insertar("e", raiz);
            arbol.Insertar("i", n);
            n = arbol.Insertar("j", n);
            arbol.Insertar("p", n);
            arbol.Insertar("q", n);

            n = arbol.Insertar("f", raiz);
            arbol.Insertar("k", n);
            arbol.Insertar("l", n);
            arbol.Insertar("m", n);

            n = arbol.Insertar("g", raiz);
            arbol.Insertar("n", n);

            arbol.TransversaPreO(raiz);
            Console.WriteLine("----------------");
            //arbol.TransversaPostO(raiz);
            //Console.WriteLine("----------------");

            Nodo encontrado = arbol.Buscar("z", raiz);
            if (encontrado != null)
                Console.WriteLine(encontrado.Dato);
            else 
                Console.WriteLine("No encontrado");

            Console.WriteLine("----------------");

            string donde = "";
            string que = "";

            Console.WriteLine("En donde deseas insertar: ");
            donde = Console.ReadLine();
            Console.WriteLine("Que deseas insertar: ");
            que = Console.ReadLine();

            encontrado = arbol.Buscar(donde, raiz);
            arbol.Insertar(que, encontrado);
            arbol.TransversaPreO(raiz);

            Console.Read();
        }
    }
}
