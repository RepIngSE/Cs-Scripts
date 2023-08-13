using System;
using System.Collections;

namespace Ejercicio11
{
    class PilaCola
    {
        static void Main(string[] args)
        {
            Stack<float> Pila1 = new Stack<float>();
            Queue<float> Cola1 = new Queue<float>();
            Console.Write("Digite el tamaño de la pila:  ");
            int TamPila = int.Parse(Console.ReadLine());
            for (int j = 0; j < TamPila; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la pila: ");
                float Valor1 = float.Parse(Console.ReadLine());
                Pila1.Push(Valor1);
            }

            Console.WriteLine("\nLa pila es: ");
            while (Pila1.Count > 0)
            {
                float Co = 0;
                Co = (float)Pila1.Pop();
                Console.WriteLine(" {0} ", Co);
                Cola1.Enqueue(Co);
            }

            for (int j = 0; j < TamPila; j++)
            {
                float Val = 0;
                Val = (float)Cola1.Dequeue();
                Cola1.Enqueue(Val);
            }

            Console.WriteLine("\nLa cola resultante es: ");
            foreach (float number in Cola1)
            {
                Console.WriteLine(" {0} ", number);
            }
        }
    }
}
