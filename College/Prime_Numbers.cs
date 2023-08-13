using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {

        static bool Primos(int numero)
        {
            bool primo = true;
            int n = 2;
            while ((primo) && (n < numero))
            {
                if (numero % n == 0)
                    primo = false;
                else
                    n = n + 1;
            }
            if (primo)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            int tamañovector = 0;
            Console.Write("Ingrese la longitud del Vector: ");
            tamañovector = int.Parse(System.Console.ReadLine());

            int[] Vector = new int[tamañovector];
            int numero, f = 0;
            bool pri = true;

            Random rnd = new Random();
            while (pri)
            {
                numero = rnd.Next(2, 1000);
                if (Primos(numero))
                {
                    Vector[f] = numero;
                    f = f + 1;

                    if (f == tamañovector)
                        pri = false;
                }
            }
            for (int i = 0; i < tamañovector; i++)
            Console.WriteLine($"En la posición {i} esta el número {Vector[i]}");

            Array.Sort(Vector);
            Console.WriteLine("El número menor es: " + Vector[0]);
            Console.WriteLine("El número mayor es: " + Vector[tamañovector - 1]);
        }

    }
}
 
