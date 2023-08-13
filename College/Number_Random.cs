using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {
        int[] Vector;
        int tamañovector;
        public void CargarVector()
        {
            Console.Write("Ingrese la longitud del Vector: ");
            tamañovector = int.Parse(System.Console.ReadLine());
            Vector = new int[tamañovector];
        }

        private void aleatorio()
            {
                Random aleatorio = new Random();

                for (int f = 0; f < Vector.Length; f++)
                {
                    Vector[f] = (aleatorio.Next(0, 9) + 1);
                }

            }

        public void Mostrar()
        {
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.WriteLine("En el indice " + f + " Esta el número " + Vector[f]);

            }
        }
        public void suma()
        {
            int resultado = 0;
            for (int f = 0; f < Vector.Length; f++)
            {
                resultado = resultado + Vector[f];
                Console.WriteLine("La suma del vector es = " + resultado);
            }

        }
        static void Main(string[] args)
        {
            program Program = new program();
            Program.CargarVector();
            Program.aleatorio(); 
            Program.Mostrar();
            Program.suma();
        }
    }
}
