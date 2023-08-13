using System;
namespace AplicacionBase
{
    class program
    {
        public void cargarmatriz()
        {
            // Declarar variables para el tamaño de las matrices
            int Tamañofil1, Tamañocol1;

            // Solicitar al usuario que ingrese el número de filas de las matrices
            Console.WriteLine("Digite el número de filas de las matrices");
            Tamañofil1 = int.Parse(System.Console.ReadLine());

            // Solicitar al usuario que ingrese el número de columnas de las matrices
            Console.WriteLine("Digite el número de columnas de las matrices");
            Tamañocol1 = int.Parse(System.Console.ReadLine());

            // Declarar e inicializar las matrices matriz1 y matriz2 con el tamaño proporcionado
            int[,] matriz1 = new int[Tamañofil1, Tamañocol1];
            for (int fil1 = 0; fil1 < Tamañofil1; fil1++)
            {
                for (int col1 = 0; col1 < Tamañocol1; col1++)
                {
                    Console.Write($"Ingrese el elemento [{fil1 + 1},{col1 + 1}] de la matriz #1: ");
                    matriz1[fil1, col1] = int.Parse(System.Console.ReadLine());
                }
            }

            int[,] matriz2 = new int[Tamañofil1, Tamañocol1];
            for (int fil2 = 0; fil2 < Tamañofil1; fil2++)
            {
                for (int col2 = 0; col2 < Tamañocol1; col2++)
                {
                    Console.Write($"Ingrese el elemento [{fil2 + 1},{col2 + 1}] de la matriz #2: ");
                    matriz2[fil2, col2] = int.Parse(System.Console.ReadLine());
                }
            }
            
            // Mostrar la matriz #1 ingresada por el usuario
            Console.WriteLine("La matriz resultante #1 es: ");
            for (int fil1 = 0; fil1 < matriz1.GetLength(0); fil1++)
            {
                for (int col1 = 0; col1 < matriz1.GetLength(1); col1++)
                {
                    Console.Write("    [" + matriz1[fil1, col1] + "] ");
                }
                Console.WriteLine();
            }
            
            // Calcular la matriz transpuesta de la matriz #2
            int[,] matrizT = new int[Tamañofil1, Tamañocol1];
            for (int fil2 = 0; fil2 < Tamañofil1; fil2++)
            {
                for (int col2 = 0; col2 < Tamañocol1; col2++)
                {
                    matrizT[fil2, col2] = matriz2[col2, fil2];
                }
            }
            
            // Mostrar la matriz #2 y su matriz transpuesta
            string resultado = "La matriz resultante #2 es: \n";
            for (int fil2 = 0; fil2 < Tamañofil1; fil2++)
            {
                for (int col2 = 0; col2 < Tamañocol1; col2++)
                {
                    resultado = resultado + ("    [" + matriz2[fil2, col2] + "] ");
                }
                resultado = resultado + "\n";
            }
            resultado = resultado + " La matriz transpuesta de la matriz #2 es: \n";
            for (int fil2 = 0; fil2 < Tamañofil1; fil2++)
            {
                for (int col2 = 0; col2 < Tamañocol1; col2++)
                {
                    resultado = resultado + ("    [" + matrizT[fil2, col2] + "] ");
                }
                resultado = resultado + "\n";
            }
            Console.Write(resultado);
            
            // Calcular y mostrar la suma de la matriz #1 y la matriz transpuesta
            int[,] matrizsuma = new int[Tamañofil1, Tamañocol1];
            for (int fil1 = 0; fil1 < Tamañofil1; fil1++)
            {
                for (int col1 = 0; col1 < Tamañocol1; col1++)
                {
                    matrizsuma[fil1, col1] = matriz1[fil1, col1] + matrizT[fil1, col1];
                }
            }
            Console.WriteLine("La suma de la matriz #1 y la matriz transpuesta es:");
            for (int fil1 = 0; fil1 < Tamañofil1; fil1++)
            {
                for (int col1 = 0; col1 < Tamañocol1; col1++)
                {
                    Console.Write("    [" + matrizsuma[fil1, col1] + "] ");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(String[] args)
        {
            // Crear una instancia de la clase program
            program Program = new program();
            // Invocar el método para cargar y manipular las matrices
            Program.cargarmatriz();
        }
    }
}
