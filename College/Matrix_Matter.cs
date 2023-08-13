using System;
using System.Collections;

namespace Ejercicio10
{
    class Academia
    {
        private int[,] MatrizAcademia;
        int CANTIDAD_FILAS = 3;
        int CANTIDAD_COLUMNAS = 4;

        public void CargarMatriz()
        {
            MatrizAcademia = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for (int f = 0; f < CANTIDAD_FILAS; f++)
            {
                for (int c = 0; c < CANTIDAD_COLUMNAS; c++)
                {
                    Console.Write("Digite la cantidad de estudiantes: ");
                    MatrizAcademia[f, c] = int.Parse(Console.ReadLine());
                }

            }
        }
        public void MostrarMatriz()
        {
            for (int f = 0; f < CANTIDAD_FILAS; f++)
            {
                if (f == 0)
                {
                    Console.WriteLine("\nNivel básico: ");

                }
                if (f == 1)
                {
                    Console.WriteLine("\nNivel medio: ");
                }
                if (f == 2)
                {
                    Console.WriteLine("\nNivel de perfeccionamiento: ");
                }
                for (int c = 0; c < CANTIDAD_COLUMNAS; c++)
                {
                    if (c == 0)
                    {
                        Console.Write("Inglés");
                    }
                    if (c == 1)
                    {
                        Console.Write("Francés");
                    }
                    if (c == 2)
                    {
                        Console.Write("Alemán");
                    }
                    if (c == 3)
                    {
                        Console.Write("Ruso");
                    }
                    Console.WriteLine(" " + MatrizAcademia[f, c]);
                }
            }
        }
        static void Main(string[] args)
        {
            Academia op = new Academia();
            op.CargarMatriz();
            op.MostrarMatriz();
        }
    }
}
