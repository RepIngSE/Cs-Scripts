using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables para almacenar la edad de la persona y la edad equivalente del perro
            double edad_persona = 0;
            double edad_perro = 0;

            // Solicitar al usuario ingresar la edad de la persona
            System.Console.WriteLine("Digite la edad de la persona");
            edad_persona = double.Parse(System.Console.ReadLine());

            // Calcular la edad equivalente del perro según la regla dada
            if (edad_persona <= 2)
            {
                edad_perro = edad_persona * 10.5; // Si la edad es menor o igual a 2, se multiplica por 10.5
            }
            else
            {
                edad_perro = (edad_persona - 2) * 4 + 21; // Si la edad es mayor a 2, se aplica la fórmula dada
            }

            // Mostrar la edad equivalente del perro
            System.Console.WriteLine("La edad del perro es {0}:", edad_perro);
        }
    }
}
