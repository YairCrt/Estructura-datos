using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalPrePost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Postfix
            Stack miStack = new Stack();
            int n = 0; //recorrer la expresion con for
            int a = 0; // a y b guardan los operandos
            int b = 0;
            int r = 0; //r para el resultado

            //expresion postfix 352*+73*-
            //expresion prefix -+3*52*73
            string expresion = "-+3*52*73"; //expresion de un digito
            char caracter = ' ';

            for(n = expresion.Length-1; n >= 0; n--) //Prefix
            //for(n = 0; n < expresion.Length; n++) //Postfix
            {
                //Obtenemos el caracter
                caracter = expresion[n];

                //Verificamos si es numero
                if(caracter >= '0' && caracter <= '9')
                {
                    //Se coloca en el stack
                    miStack.Push(Convert.ToInt32(caracter.ToString()));
                }
                else //es operador
                {
                    //Hacemos dos pop
                    //postfix b -> a
                    //prefix a -> b
                    a = miStack.Pop();
                    b = miStack.Pop();

                    //Verificamos el tipo de operador y aplicamos la op
                    if(caracter == '+')
                    {
                        r = a + b;
                        miStack.Push(r);
                    }
                    if(caracter == '-')
                    {
                        r = a - b;
                        miStack.Push(r);
                    }
                    if(caracter == '/')
                    {
                        r = a * b;
                        miStack.Push(r);
                    }
                    if(caracter == '*')
                    {
                        r = a * b;
                        miStack.Push(r);
                    }
                }
            }

            miStack.Transversa();

            Console.Read();
        }
    }
}
