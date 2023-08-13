using System;
using System.Collections; 

//Contains es un método que se usa para verificar si un string contiene un caractér determinado y la respuesta sera dada a traves de true o false.  

namespace Ejercicio5
{
    public class Ejercicio5
    {
        public static void Main()
        {
            String cadena1 = "Hola";
            Console.Write("¿La palabra Hola contiene la letra H?: "); 
            Console.WriteLine(cadena1.Contains("H"));

            Console.WriteLine();

            String cadena2 = "Hello";
            Console.Write("¿La palabra Hello contiene la letra S?: ");
            Console.WriteLine(cadena2.Contains("S"));
 
        }
    }
}
