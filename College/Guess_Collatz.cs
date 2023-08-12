using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir constantes para las operaciones en la conjetura de Collatz
            int MULTIPLICA = 3, DIVIDE = 2, SUMA = 1;

            // Variables para almacenar el número deseado y el resultado de cada iteración
            int NumDeseado = 0, Resultado = 0;

            // Solicitar al usuario ingresar un número para verificar la conjetura de Collatz
            System.Console.WriteLine("Dijite el número para verificar la conjetura de Collatz. ");
            NumDeseado = int.Parse(System.Console.ReadLine());

            // Ciclo while que realiza la conjetura de Collatz hasta que el número sea 1
            while (NumDeseado > 1)
            {
                if (NumDeseado % 2 == 0)
                {
                    // Si el número es par, dividirlo por 2
                    Resultado = NumDeseado / DIVIDE;
                }
                else
                {
                    // Si el número es impar, multiplicarlo por 3 y sumarle 1
                    Resultado = (NumDeseado * MULTIPLICA) + SUMA;
                }

                // Imprimir el resultado de la iteración actual
                System.Console.WriteLine("La secuencia es: {0}", Resultado);

                // Actualizar el número deseado con el resultado de la iteración
                NumDeseado = Resultado;
            }

            // Si el número deseado es menor que 1, imprimir un mensaje de número inválido
            if (NumDeseado < 1)
            {
                System.Console.WriteLine("Número invalido.");
            }
        }
    }
}
