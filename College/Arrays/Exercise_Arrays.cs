using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.WriteLine("Los números del array #1 son: ");
            for (int j = 0; j < array1.Length; j++)
            {
                Console.WriteLine($"Posición: {j} : {array1[j]}");
            }

            Console.WriteLine("Los números del array #2 son: ");
            for (int j = 0; j < array2.Length; j++) 
            { 
                Console.WriteLine($"Posición: {j} : {array2[j]}"); 
            }        
            Console.WriteLine("Los números generados nuevamente en el array #2 son: ");
            array1.CopyTo(array2, 0);
            for (int j = 0; j < array2.Length; j++)
            {
                Console.WriteLine($"Posición:{j} : {array1[j]}");
            }
            Console.ReadKey();

        }
    }
}
