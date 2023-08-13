using System;

namespace Ejercicio13
{
    class Metodos
    {
        static void Main(string[] args)
        {
            // Definir una cadena de texto y un carácter
            string Algo = "Como estas";
            char Signo = '?';

            // Mostrar la cadena original
            Console.WriteLine(Algo);

            // Mostrar la cadena con relleno a la derecha hasta tener una longitud de 15 caracteres
            Console.WriteLine(Algo.PadRight(15, Signo));

            // Mostrar la cadena con relleno a la derecha hasta tener una longitud de 20 caracteres
            Console.WriteLine(Algo.PadRight(20, Signo));
        }
    }
}
