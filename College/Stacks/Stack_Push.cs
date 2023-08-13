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

            Pila1.Push(1);
            Pila1.Push(2);
            Pila1.Push(3);
            Pila1.Push(4);
            Pila1.Push(5);
            Pila2.Push(6);
            Pila2.Push(7);
            Pila2.Push(8);
            Pila2.Push(9);
            Pila2.Push(10);


            Console.WriteLine("\nLa pila #1 es: ");
            while (Pila1.Count > 0)
            {
                int Co = 0;
                Co = (int)Pila1.Pop();
                Console.WriteLine(Co);
                Pila2.Push(Co);
            }
            for (int j = 0; j <Pila2.Count; j++)
            {
                int Val = 0;
                Val = (int)Pila2.Pop();
                Pila1.Push(Val);
            }

            Console.WriteLine("\nLa pila final #1 es: ");
            foreach (int number in Pila1)
            {
                Console.WriteLine("{0} ", number);
            }
            Console.WriteLine("la pila esta vacia");
        }
    }
}
