using System;
using System.Collections;

namespace Ejercicio13
{
    class PilaCola
    {
        static void Main(string[] args)
        {
            Queue C=new Queue();
            Stack P=new Stack();
            Console.Write("Digite el tamaño de la cola:  ");
            int m=int.Parse(Console.ReadLine());
            for(int j=0;j<m;j++){
                Console.Write($"Digite el elemento {j+1}: ");
                int Valor=int.Parse(Console.ReadLine());
                C.Enqueue(Valor);
            }

            Console.WriteLine("\nLa cola es: ");
            for(int e=0;e<m;e++){
                int mos=(int)C.Dequeue(); 
                Console.WriteLine(mos);
                P.Push(mos);    
            }

            Console.WriteLine("\nLa pila es: ");
            for(int j=0;j<m;j++){
                Console.WriteLine(P.Pop());
            }   

            Console.WriteLine("\nLa nueva cola está vacia. ");

        }
    }
}
