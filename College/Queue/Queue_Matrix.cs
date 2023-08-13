using System;
using System.Collections;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear tres colas (ColaC1, ColaC2 y ColaC3)
            Queue ColaC1 = new Queue();
            Queue ColaC2 = new Queue();
            Queue ColaC3 = new Queue();

            // Llenar ColaC1 con elementos del 1 al 10
            int[] matriz1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in matriz1)
            {
                ColaC1.Enqueue(num);
            }

            // Llenar ColaC2 con elementos del 11 al 20
            int[] matriz2 = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (int num in matriz2)
            {
                ColaC2.Enqueue(num);
            }

            // Llenar ColaC3 con elementos del 21 al 30
            int[] matriz3 = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            foreach (int num in matriz3)
            {
                ColaC3.Enqueue(num);
            }

            Console.WriteLine();
            Console.WriteLine("\n Cola 1:");
            Console.WriteLine();

            // Mostrar ColaC1
            while (ColaC1.Count > 0)
            {
                int Co = (int)ColaC1.Dequeue();
                Console.Write(" [" + Co + "]");
            }
            Console.WriteLine();
            Console.WriteLine("\n Cola 2:");
            Console.WriteLine();

            // Mostrar ColaC2
            while (ColaC2.Count > 0)
            {
                int Co = (int)ColaC2.Dequeue();
                Console.Write(" [" + Co + "]");
            }
            Console.WriteLine();
            Console.WriteLine("\n Cola 3:");
            Console.WriteLine();

            // Mostrar ColaC3
            while (ColaC3.Count > 0)
            {
                int Co = (int)ColaC3.Dequeue();
                Console.Write(" [" + Co + "]");
            }
            Console.WriteLine();

            Console.WriteLine("\n Los números de la matriz son: \n");

            // Mostrar el cuadrado de cada elemento en las matrices
            for (int j = 0; j < matriz1.Length; j++)
            {
                Console.Write($"[{matriz1[j] * matriz1[j]}]");
            }
            Console.WriteLine();
            for (int j = 0; j < matriz2.Length; j++)
            {
                Console.Write($"[{matriz2[j] * matriz2[j]}]");
            }
            Console.WriteLine();
            for (int j = 0; j < matriz3.Length; j++)
            {
                Console.Write($"[{matriz3[j] * matriz3[j]}]");
            }
            Console.WriteLine();
        }
    }
}
