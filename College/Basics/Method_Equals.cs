using System;
using System.Collections; 

//Equals es un método que nos permite saber si 2 o mas cadenas son IDENTICAS a traves de un valor verdadero o falso.
 
namespace Ejercicio5
{
    public class Ejercicio5
    {
        public static void Main()
        {
            String cadena1 = "Hola";
            String cadena2 = "Hello";

            String cadena3 = "Mundo";
            String cadena4 = "Mundo";
            Console.WriteLine($"La comparación entre {cadena1} y {cadena2} es:"); 
            Console.WriteLine(cadena1.Equals(cadena2));
            Console.WriteLine();
            Console.WriteLine($"La comparación entre {cadena3} y {cadena4} es:");
            Console.WriteLine(cadena3.Equals(cadena4));
        }
    }
}

