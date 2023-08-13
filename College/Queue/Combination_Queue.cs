using System;
using System.Collections;

namespace Ejercicio10
{
    class Colas_3
    {
        static void Main(string[] args)
        {
            // Crear tres colas C1, C2 y C3
            Queue C1 = new Queue();
            Queue C2 = new Queue();
            Queue C3 = new Queue();

            // Solicitar al usuario que ingrese el tamaño de las colas
            Console.Write("Digite el tamaño de las colas: ");
            int m = int.Parse(Console.ReadLine());

            // Llenar la cola No°1 con elementos ingresados por el usuario
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la cola No°1: ");
                int Valor1 = int.Parse(Console.ReadLine());
                C1.Enqueue(Valor1);
            }
            Console.WriteLine();

            // Llenar la cola No°2 con elementos ingresados por el usuario
            for (int e = 0; e < m; e++)
            {
                Console.Write($"Digite el elemento {e + 1} de la cola No° 2: ");
                int Valor2 = int.Parse(Console.ReadLine());
                C2.Enqueue(Valor2);
            }

            // Mostrar la cola No°1 y mover elementos a la cola resultante (C3)
            Console.WriteLine("\nLa cola No° 1 es: ");
            while (C1.Count > 0)
            {
                int Co = 0;
                Co = (int)C1.Dequeue();
                Console.WriteLine(Co);
                C3.Enqueue(Co);
            }

            // Mostrar la cola No°2 y mover elementos a la cola resultante (C3)
            Console.WriteLine("\nLa cola No° 2 es: ");
            while (C2.Count > 0)
            {
                int Co = 0;
                Co = (int)C2.Dequeue();
                Console.WriteLine(Co);
                C3.Enqueue(Co);
            }

            // Mostrar la cola resultante (C3) utilizando un bucle foreach
            Console.WriteLine("\nLa cola resultante es: ");
            foreach (int number in C3)
            {
                Console.WriteLine(" {0} ", number);
            }
        }
    }
}
