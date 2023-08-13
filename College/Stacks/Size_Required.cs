using System;
using System.Collections;

namespace Ejercicio9
{
    class Pilas
    {
        static void Main(string[] args)
        {
            Stack Pila1 = new Stack();
            Stack Pila2 = new Stack();
            Stack Pila3 = new Stack();

            Console.Write("Digite el tamaño de la pila:  ");
            int TamPila = int.Parse(Console.ReadLine());
            for (int j = 0; j < TamPila; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la pila #1: ");
                int Valor1 = int.Parse(Console.ReadLine());
                Pila1.Push(Valor1);
            }

            Console.WriteLine("\nLa pila #1 es: ");
            while (Pila1.Count > 0)
            {
                int Co = 0;
                Co = (int)Pila1.Pop();
                Console.WriteLine(Co);
                Pila3.Push(Co);
            }

            for (int j = 0; j < TamPila; j++)
            {
                int Val = 0;
                Val = (int)Pila3.Pop();
                Pila2.Push(Val);
            }
           
            Console.WriteLine("\nLa pila final #1 es: ");
            foreach (int number in Pila2)
            {
                Console.WriteLine("{0} ", number);
            }
        }
    }
}
