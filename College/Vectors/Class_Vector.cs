using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {
        int[] Vector;
        int TAMAÑOVECTOR=15;
        public void CargarVector()
        {
            Vector = new int[TAMAÑOVECTOR];

            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write($"Ingrese el elemento {f + 1} del Vector: ");

                Vector[f] = int.Parse(System.Console.ReadLine());
            }
        }
        public void Mostrar()
        {
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.WriteLine(" En el indice " + f + " Esta el número " + Vector[f]);
            
            }
        }
        public void Operaciones()
        {
            double mul = 0, num = 0, div = 0, resultado = 0; 
            {
                Console.WriteLine("Ingrese el número con el cual desea realizar las operaciones: ");
                num = int.Parse(System.Console.ReadLine());

                for (int f = 0; f < Vector.Length; f++)
                {
                        if (num != 0)
                    {
                        resultado = Vector[f] / num;
                        Console.WriteLine("El resultado de la división del indice " + f + " correspondiente al número " + Vector[f] + " entre el número " + num + " es: " + resultado);
                    }
                        else
                    {
                        Console.WriteLine("No es posible realizar la división");
                    }

                        resultado = Vector[f] * num;
                        Console.WriteLine("El resultado de la multiplicación del indice " + f + " correspondiente al número " + Vector[f] + " multiplicado por el número " + num + " es: " + resultado);
                }

            }
        }
        static void Main(string[] args)

        {
            program Program = new program();
            Program.CargarVector();
            Program.Mostrar();
            Program.Operaciones(); 
        }
    }
}
