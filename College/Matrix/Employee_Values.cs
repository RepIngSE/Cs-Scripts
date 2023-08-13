using System;

namespace AplicacionBase
{


    class MatrizEmpleados
    {

        string[] Cliente = new string[2];
        string[] producto_Costo = new string[2];
        private double[] precio = new double[2];
        double suma = 0;
        private int[] TotalizacionSueldos;

        public void CargarMatriz()
        {
            for (int f = 0; f < Cliente.Length; f++)
            {
                Console.Write($"Ingrese el nombre del cliente  {f + 1}: ");
                Cliente[f] = Console.ReadLine();
            }
            for (int c = 0; c < producto_Costo.Length; c++)
            {
                Console.Write($"Ingrese el producto {c + 1}: ");
                producto_Costo[c] = Console.ReadLine();
            }
            for (int d = 0; d < precio.Length; d++)
            {
                Console.Write($"Ingrese el precio {d + 1}: ");
                precio[d] = double.Parse(Console.ReadLine());

                suma += precio[d];

            }

            Console.WriteLine("la suma es: " + suma);
        }
        public void ImprimirTotalPagado()
        {

            for (int f = 0; f < Cliente.Length; f++)

                for (int c = 0; c < producto_Costo.Length; c++)
                    for (int d = 0; d < precio.Length; d++)
                    {
                        Console.WriteLine("el cliente " + Cliente[f+1] + " compro los productos  " + producto_Costo[c+1] + "y los costos en total  fueron" + suma);

                    }
       }
    
            static void Main(string[] args)
            {
                MatrizEmpleados matrizEmpleados = new MatrizEmpleados();
                matrizEmpleados.CargarMatriz();
                matrizEmpleados.ImprimirTotalPagado();

            }
     }
    
}
