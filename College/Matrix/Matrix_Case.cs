using System;
using System.Collections;



namespace AplicacionBase
{
    class alfabeto
    {
        //int[,] matriz;
        
        static void Main(string[] args)
        {
           int[,] matriz;
           int Num1 = 0,num;
            int Opcion = 0;
            int cantidadcolumnas = 0;
            int cantidadfilas = 0;

            Console.WriteLine("digite tamaño de las columnas");
            cantidadcolumnas=int.Parse(Console.ReadLine());
            Console.WriteLine("digite el tamaño de las filas");
            cantidadfilas=int.Parse(Console.ReadLine());
            
            Console.WriteLine("1 - si quiere digitar su numero oprima 1 .");
            Console.WriteLine("2 - si quiere que aparezca de forma aleatoria oprima 2.");

            Opcion = int.Parse(System.Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    matriz = new int[cantidadfilas, cantidadcolumnas];
                    for (int m = 0; m < cantidadcolumnas; m++)
                    {
                        for (int o = 0; o < cantidadfilas; o++)

                        {

                            Console.WriteLine("digite un numero en el rango de 10 a 999");
                            matriz[o,m] = int.Parse(System.Console.ReadLine());
                           
                        }
                        Console.WriteLine();
                    }

                    break;
                case 2:
                    matriz = new int[cantidadcolumnas, cantidadfilas];
                    Random aleatorio = new Random();
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)

                        {
                            matriz[i,j ] = (aleatorio.Next(10, 999));
                            Console.WriteLine(matriz[i, j]);
                        }
                        Console.WriteLine();  Console.WriteLine();
                        
                    }
                    break;
            }
        }
    }
 }
