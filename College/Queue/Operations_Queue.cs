using System;
using System.Collections;

namespace CSharp_Shell
{
    class program
    {
        static void Main(string[] args)
        {
            // Crear dos colas (ColaC1 y ColaC2) y una pila (Pila)
            Queue ColaC1 = new Queue();
            Queue ColaC2 = new Queue();
            Stack Pila = new Stack();

            // Llenar ColaC1 con elementos del 1 al 5
            ColaC1.Enqueue(1);
            ColaC1.Enqueue(2);
            ColaC1.Enqueue(3);
            ColaC1.Enqueue(4);
            ColaC1.Enqueue(5);

            // Llenar ColaC2 con elementos del 6 al 10
            ColaC2.Enqueue(6);
            ColaC2.Enqueue(7);
            ColaC2.Enqueue(8);
            ColaC2.Enqueue(9);
            ColaC2.Enqueue(10);

            Console.WriteLine();
            Console.WriteLine("\n Cola 1");
            Console.WriteLine();

            // Mostrar ColaC1 y mover elementos a la pila (Pila)
            while (ColaC1.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC1.Dequeue();
                Console.Write(" [" + Co + "]");
                Pila.Push(Co);
            }
            Console.WriteLine();
            Console.WriteLine("\n Cola 2");
            Console.WriteLine();

            // Mostrar ColaC2 y mover elementos a la pila (Pila)
            while (ColaC2.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC2.Dequeue();
                Console.Write(" [" + Co + "]");
                Pila.Push(Co);
            }
            Console.WriteLine();

            Console.WriteLine("\n La pila creada: \n");

            // Mostrar la pila multiplicando cada elemento por 2
            while (Pila.Count > 0)
            {
                int Co = 0;
                Co = (int)Pila.Pop();
                Console.Write(" [" + Co * 2 + "]");
            }
            Console.WriteLine();
        }
    }
}
