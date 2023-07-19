using System;

namespace Recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            Console.Write("Ingrese un numero para realizar su serie de Fibonacci: ");
            int num = Convert.ToInt32(Console.ReadLine());

            f = Fibonacci(num);

            Console.Write("Fibonacci de {0}: {1}", num, f);

            Console.Read();
        }

        public static int Fibonacci(int num)
        {
            int r = 0;
            //Caso inductivo
            if(num > 1)
            {
                r = Fibonacci(num - 1) + Fibonacci(num - 2);
            }
            //Caso base
            if(num <= 1)
            {
                r = 1;
            }
            return r;
        }
    }

}
