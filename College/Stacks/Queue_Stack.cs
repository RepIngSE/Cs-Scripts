using System;
using System.Collections;

namespace Ejercicio13
{
    class program
    {
        static void Main(string[] args)
        {
            Queue Cola1 = new Queue();
            Stack Pila1 = new Stack();

            Console.Write("Digite el tamaño de la cola:  ");
            int TamCola = int.Parse(Console.ReadLine());
            for (int j = 0; j < TamCola; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la cola: ");
                int Valor1 = int.Parse(Console.ReadLine());
                Cola1.Enqueue(Valor1);
            }

            Console.WriteLine("\nLa cola #1 es: ");
            while (Cola1.Count > 0)
            {
                int Co = 0;
                Co = (int) Cola1.Dequeue();
                Console.WriteLine(" {0} ", Co);
                Pila1.Push(Co);
            }

            for (int j = 0; j < TamCola; j++)
            {
                int Val = 0;
                Val = (int)Pila1.Pop();
                Cola1.Enqueue(Val);
            }

            for (int j = 0; j < TamCola; j++)
            {
                float Re = 0;
                Re = (int)Cola1.Dequeue();
                Pila1.Push(Re);
            }
            Console.WriteLine("\nLa pila resultante es: ");
            foreach (float number in Pila1)
            {
                Console.WriteLine(" {0} ", number);
            }
            Console.WriteLine(); 
            Console.WriteLine("La cola no contiene ningún elemento");
        }
    }
}
