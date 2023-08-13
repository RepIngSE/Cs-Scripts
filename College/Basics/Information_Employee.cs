using System;

namespace AplicacionBase
{
    public class Empleado
    {
        // Campos protegidos para almacenar el nombre y el sueldo del empleado
        protected string nombre;
        protected double sueldo;

        // Propiedad Nombre para acceder y establecer el nombre del empleado
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        // Propiedad Sueldo para acceder y establecer el sueldo del empleado
        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        // Método para imprimir los detalles del empleado y determinar si debe pagar impuestos
        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Sueldo: " + sueldo);

            if (sueldo <= 3000)
            {
                Console.WriteLine("No debe pagar impuestos");
            }
            else if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Empleado
            Empleado persona1 = new Empleado();

            // Solicitar al usuario ingresar el nombre y el sueldo del empleado
            Console.WriteLine("Introduzca su nombre");
            string nombre = Console.ReadLine();
            persona1.Nombre = nombre;

            Console.WriteLine("Introduzca su sueldo");
            double sueldo = Double.Parse(Console.ReadLine());
            persona1.Sueldo = sueldo;

            // Imprimir los detalles del empleado y los resultados sobre los impuestos
            Console.WriteLine();
            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            Console.ReadKey();
        }
    }
}
