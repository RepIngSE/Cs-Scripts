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

        public void aleatorio()
        {
            Random aleatorio = new Random();

            for (int f = 0; f < Vector.Length; f++)
            {
                Vector[f] = (aleatorio.Next(1, 300) + 1);
            }

        }
        public void Mostrar()
        {
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.WriteLine("En el indice " + f + " Esta el número " + Vector[f]);

            }
        }

        public void Digito()
        {
            Console.Write("Ingrese un numero de 0 9: ");
            int num1 = int.Parse(System.Console.ReadLine());

            if (num1 >=0 && num1 <= 9)
            {
                string numero = num1.ToString();

                for (int f = 0; f < Vector.Length; f++)
                {

                    string numeros = Vector[f].ToString();
                    string ultimo = numeros.Substring(numeros.Length - 1);

                    if (ultimo == numero)
                    {
                        Console.Write("Este es el número " + Vector[f] + " del vector que terminan en " + ultimo + "\n");
                    }

                }
            }
            else
            {
                Console.Write("El número ingresado no esta en el rango permitido \n");
            }

            
        }
        static void Main(string[] args)
        {
            program Program = new program();
            Program.CargarVector();
            Program.aleatorio();
            Program.Mostrar();
            Program.Digito();
        }
    }
}
