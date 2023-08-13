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

            Pila1.Push(1);
            Pila1.Push(2);
            Pila1.Push(3);
            Pila1.Push(4);
            Pila1.Push(5);

            Console.WriteLine("------");

            Console.WriteLine("\n La pila nunmero 1 es: ");
            while (Pila1.Count > 0)
            {
                int Co = 0;
                Co = (int)Pila1.Pop();
                Console.WriteLine(Co);
                Pila2.Push(Co);
            }
            for (int j = 0; j < Pila1.Count; j++)
            {
                int Val = 0;
                Val = (int)Pila2.Pop();
                Pila2.Push(Val);
            }

            Console.WriteLine("\nLa pila final numero 1 es: ");
            foreach (int number in Pila2)
            {
                Console.WriteLine("{0} ", number);
            }
            Console.WriteLine();
            Console.WriteLine("la pila esta vacia");
        }
    }
}
