using System;
using System.Collections;

namespace Ejercicio13
{
    class ColaPilaSinInvertir
    {
        static void Main(string[] args)
        {
            // Crear una cola (C) y una pila (P) de números de punto flotante (float)
            Queue<float> C = new Queue<float>();
            Stack<float> P = new Stack<float>();

            // Solicitar al usuario que ingrese el tamaño de la cola
            Console.Write("Digite el tamaño de la cola: ");
            int TamCola = int.Parse(Console.ReadLine());

            // Llenar la cola con elementos ingresados por el usuario
            for (int j = 0; j < TamCola; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la cola: ");
                float Valor1 = float.Parse(Console.ReadLine());
                C.Enqueue(Valor1);
            }

            // Mostrar la cola No° 1 y mover elementos a la pila (P)
            Console.WriteLine("\nLa cola No° 1 es: ");
            while (C.Count > 0)
            {
                float Co = 0;
                Co = (float)C.Dequeue();
                Console.WriteLine(" {0} ", Co);
                P.Push(Co);
            }

            // Vaciar la pila y mover elementos nuevamente a la cola (C)
            for (int j = 0; j < TamCola; j++)
            {
                float Val = 0;
                Val = (float)P.Pop();
                C.Enqueue(Val);
            }

            // Mover elementos de la cola (C) nuevamente a la pila (P)
            for (int j = 0; j < TamCola; j++)
            {
                float Re = 0;
                Re = (float)C.Dequeue();
                P.Push(Re);
            }

            // Mostrar la pila resultante (P) utilizando un bucle foreach
            Console.WriteLine("\nLa pila resultante es: ");
            foreach (float number in P)
            {
                Console.WriteLine(" {0} ", number);
            }
        }
    }
}
