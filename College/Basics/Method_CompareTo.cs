using System;
using System.Collections; 

//Compare es un método usado para dar a conocer si 2 cadenas son iguales o no. 
 
namespace Ejercicio4
{
    public class Ejercicio4
    {
        public static void Main()
        {
            String cadena1 = "Hola";
            String cadena2 = "Hello";

            String cadena3 = "Mundo";
            String cadena4 = "Mundo";

            Console.WriteLine($"La comparación entre {cadena1} y {cadena2} es: ");
            int comparacion1 = cadena1.CompareTo(cadena2);
            if (comparacion1 == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else if (comparacion1 == 1)
            {
                Console.WriteLine("Las cadenas no son iguales");
            }

            Console.WriteLine();
            Console.WriteLine($"La comparación entre {cadena3} y {cadena4} es: ");
            int comparacion2 = cadena3.CompareTo(cadena4);
            if (comparacion2 == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else if (comparacion2 == 1)
            {
                Console.WriteLine("Las cadenas no son iguales");
            }
        }
    }
}
