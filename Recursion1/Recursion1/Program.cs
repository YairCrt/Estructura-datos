using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de recursividad. Factorial de un número
            int f = 0;
            Console.Write("Digite el numero a buscar el factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            f = Factorial(num);
            Console.Write("Factorial de {0}: {1}", num, f);

            Console.Read();
        }

        //Creamos la función Factorial
        public static int Factorial(int num)
        {
            int r = 0;
            //Caso inductivo
            if (num >= 1)
            {
                //r invoca nuevamente a la funcion factorial 
                r = num * Factorial(num - 1);
            }
            if (num == 0)
            {
                r = 1;
            }

            return r;
        }
    }
}