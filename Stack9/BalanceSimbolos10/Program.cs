using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSimbolos10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expresion = "";
            char s = ' ';
            Stack pila = new Stack();

            //Expresion a evaluar
            Console.Write("Ingrese la expresion a evaluar: ");
            expresion = Console.ReadLine();

            foreach (char c in expresion)
            {
                //Verificamos que sea simbolo de apertura
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }

                //Verificamos que sea simbolo de cierre
                if (c == ')' || c == '}' || c == ']')
                { 
                    if (pila.StackVacio())
                    {
                        Console.WriteLine("EXCESO DE SIMBOLOS DE CIERRE");
                    }
                    else
                    {
                        //Obtenemos el caracter correspondiente
                        s = pila.Pop();

                        //Verificamos que se tenga coincidencia
                        if (s == '(' && c != ')')
                        {
                            Console.WriteLine("Se esperaba )");
                        }
                        if (s == '{' && c != '}')
                        {
                            Console.WriteLine("Se esperaba }");
                        }
                        if(s == '[' && c != ']')
                        {
                            Console.WriteLine("Se esperaba ]");
                        }
                    }
                }
            }

            if(pila.StackVacio() == false)
            {
                Console.WriteLine("EXCESO DE SIMBOLOS DE APERTURA");
            }

            Console.ReadLine();
        }
    }
}
