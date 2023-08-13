using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // esta metodo se utiliza para que al escrbir un mensaje se pueda escoger cual palabra deseamos ver
            string cadena1 = "este es el ejercicio de substring";
            Console.WriteLine(cadena1);
            string cadena2=cadena1.Substring(0,4);
            string cadena3=cadena1.Substring(0,7);
            string cadena4=cadena1.Substring(0,10);
            string cadena5=cadena1.Substring(0,21);
            string cadena6=cadena1.Substring(0,23);
            string cadena8=cadena1.Substring(0,33);

            Console.WriteLine();

            Console.WriteLine(cadena2);
            Console.WriteLine(cadena3);
            Console.WriteLine(cadena4);
            Console.WriteLine(cadena5);
            Console.WriteLine(cadena6);
            Console.WriteLine(cadena8);
            Console.WriteLine();
        }
    }
}
