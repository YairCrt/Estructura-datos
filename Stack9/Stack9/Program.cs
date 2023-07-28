using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            pila.Push(5);
            pila.Push(3);
            pila.Push(10);

            pila.Transversa();

            Console.WriteLine(pila.Pop());
            pila.Transversa();

            Console.Read();
        }
    }
}
