using System;
using System.Collections;

namespace Ejercicio5
{
    class Ejercicio7
    {
        static void Mostrar(ArrayList Arreglo)
        {
            foreach (float n in Arreglo)
            {
                Console.WriteLine(" {0} ",n);
            }
            Console.WriteLine("\n--------------");
        }
        static void Main(string[] args)
        {
            ArrayList Lista1 = new ArrayList();
            Console.Write("Digite el tamaño del arraylist: ");
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la lista #1: ");
                float Valor = float.Parse(Console.ReadLine());
                Lista1.Insert(j, Valor);
            }

            ArrayList Lista2 = new ArrayList(); 
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Digite el elemento {i + 1} de la lista #2: ");
                float Numero  = float.Parse(Console.ReadLine());
                Lista2.Insert(i, Numero);
            }

            Console.WriteLine("La concanetacion de las dos listas es: ");
            Lista1.AddRange(Lista2); 
            Mostrar(Lista1);
        }
    }
}
