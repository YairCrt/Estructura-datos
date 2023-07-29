using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();

            fila.Enqueue(5);
            fila.Enqueue(3);
            fila.Enqueue(7);
            fila.Enqueue(1);

            fila.Transversa();

            int valor = fila.Dequeue();
            Console.WriteLine("Valor adquirido {0}", valor);
            fila.Transversa();

            fila.Enqueue(8);
            fila.Transversa();

            Console.WriteLine("Primer elemento de la fila: {0}", fila.Peek());

            Console.Read();
        }
    }
}
