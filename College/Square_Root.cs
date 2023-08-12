using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Problema5
{
    class program
    {
        static void Main(string[] args)

        {
            double numero = 0;
            double raiz_cuadrada = 0;
            Console.WriteLine("Digite un múmero"); 
            numero = double.Parse(System.Console.ReadLine());

            raiz_cuadrada = Math.Sqrt(numero);
            Console.WriteLine("La raiz cuadrada es {0}", raiz_cuadrada); 

        }
    }
}
