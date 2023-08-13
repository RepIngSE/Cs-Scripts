using System;
using System.Collections;

namespace Ejercicio8
{
    class CambioPilas
    {
        static void Main(string[] args)
        {
            Stack Pila1 = new Stack();
            Stack Pila2 = new Stack();
            Stack Pila3 = new Stack();
            Stack Pila4 = new Stack();

            Console.Write("Digite el tamaño de las pilas:  ");
            int TamPila = int.Parse(Console.ReadLine());
            for (int j = 0; j < TamPila; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la pila #1: ");
                int Valor1 = int.Parse(Console.ReadLine());
                Pila1.Push(Valor1);
            }
            Console.WriteLine();
            for (int e = 0; e < TamPila; e++)
            {
                Console.Write($"Digite el elemento {e + 1} de la pila #2: ");
                int Valor2 = int.Parse(Console.ReadLine());
                Pila2.Push(Valor2);
            }

            Console.WriteLine("\nLa pila #1 es: ");
            while (Pila1.Count > 0)
            {
                int Co = 0;
                Co = (int)Pila1.Pop();
                Console.WriteLine(Co);
                Pila3.Push(Co);
            }
            Console.WriteLine("\nLa pila #2 es: ");
            while (Pila2.Count > 0)
            {
                int Co1 = 0;
                Co1 = (int)Pila2.Pop();
                Console.WriteLine(Co1);
                Pila4.Push(Co1);
            }
            for (int j = 0; j < TamPila; j++)
            {
                int Val = 0;
                Val = (int)Pila3.Pop();
                Pila2.Push(Val);
            }
            for (int j = 0; j < TamPila; j++)
            {
                int Val = 0;
                Val = (int)Pila4.Pop();
                Pila1.Push(Val);
            }

            Console.WriteLine("\nLa pila final #1 es: ");
            foreach (int number in Pila1)
            {
                Console.WriteLine("{0} ", number);
            }

            Console.WriteLine("\nLa pila final #2 es: ");
            foreach (int number in Pila2)
            {
                Console.WriteLine("{0} ", number);
            }
        }
    }
}
