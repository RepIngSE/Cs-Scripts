using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            int TamañoArrayList = 0;
            int numero = 0;
            Console.WriteLine("lista numero 1");
            TamañoArrayList = int.Parse(Console.ReadLine());
            ArrayList lista = new ArrayList();
            for (int i = 0; i < TamañoArrayList; i++)
            {
                Console.WriteLine( $"digite el elemento {i+1}:");   
                numero=int.Parse(Console.ReadLine());
                if (numero != 0) {
                    lista.Insert(i, numero);
                }
                if(numero == 0){
                    i = TamañoArrayList + 1;
                }

                imprime(lista);

            }          
            static void imprime(ArrayList arreglo)
            {
                foreach (int n in arreglo)
                    Console.WriteLine("{0},", n);
                Console.WriteLine("\n---------");
                arreglo.Sort();
            }
            
        }
    }
}
