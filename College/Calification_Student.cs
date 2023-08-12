using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Caliificacion
{
    class program
    {
        static void Main(string[] args)
        {

            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;
            float nota4 = 0;
            float promedio = 0;
            float MAXIMA_CALIFICACION = 50;
            float MINIMA_CALIFICACION = 30;
                    

            Console.WriteLine("escriba la nota1");
            nota1 = float.Parse(System.Console.ReadLine());
            Console.WriteLine("escriba la nota2");
            nota2= float.Parse(System.Console.ReadLine());
            Console.WriteLine("escriba la nota3");
            nota3 = float.Parse(System.Console.ReadLine());
            Console.WriteLine("escriba la nota4");
            nota4 = float.Parse(System.Console.ReadLine());
            
            promedio=(nota1+nota2+nota3 +nota4)/4;
            MAXIMA_CALIFICACION = 50;
            MINIMA_CALIFICACION = 30;
           
            Console.WriteLine("LA MAXIMA_CALIFICACION es {0}", MAXIMA_CALIFICACION);
            Console.WriteLine("LA MINIMA_CALIFICACION es {0}", MINIMA_CALIFICACION);
            Console.WriteLine("El promedio es {0}", promedio);
        }
    }
}
