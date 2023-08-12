using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Problema8 
{
    class program
    {
        static void Main(string[] args)

        {
            string c;

            Console.WriteLine("Digite una letra");
            c = Console.ReadLine();
            if (c == "a" || c == "e" || c == "i" || c == "o" || c == "u" || c == "A" || c == "E" || c == "I" || c == "O" || c == "U")
            {
                Console.WriteLine("La letra \"{0}\" es una vocal", c);
            }
            else
            {
                Console.WriteLine("La letra \"{0}\" no es una vocal", c);
            }
            if (c == "a" || c == "b" || c == "c" || c == "d" || c == "e" || c == "f" || c == "g" || c == "h" || c == "i" || c == "j" || c == "k" || c == "l" || c == "m" || c == "n" || c == "ñ" || c == "o" || c == "p" || c == "q" || c == "r" || c == "s" || c == "t" || c == "u" || c == "v" || c == "w" || c == "x" || c == "y" || c == "z")
            {
                Console.WriteLine("La letra \"{0}\" es una miniscula", c);
            }

            if (c == "a" || c == "b" || c == "c" || c == "d" || c == "e" || c == "f" || c == "g" || c == "h" || c == "i" || c == "j" || c == "k" || c == "l" || c == "m" || c == "n" || c == "ñ" || c == "o" || c == "p" || c == "q" || c == "r" || c == "s" || c == "t" || c == "u" || c == "v" || c == "w" || c == "x" || c == "y" || c == "z" || c == "A" || c == "B" || c == "C" || c == "D" || c == "E" || c == "F" || c == "G" || c == "H" || c == "I" || c == "J" || c == "K" || c == "L" || c == "M" || c == "N" || c == "Ñ" || c == "O" || c == "P" || c == "Q" || c == "R" || c == "S" || c == "T" || c == "U" || c == "V" || c == "W" || c == "X" || c == "Y" || c == "Z")
            {
                Console.WriteLine("La letra \"{0}\" es un simbolo del abecedario", c);
            }
            else
            {
                Console.WriteLine("La letra \"{0}\" no es un simbolo del abecedario", c);
            }
        }
    }
}
