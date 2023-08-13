using System;

namespace AplicacionBase
{
    public class Producto
    {
        protected string nombre;
        protected string descripcion;
        protected float precio;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public float Precio
        {
            set { precio = value; }
            get { return precio; }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Descripción: " + Descripcion);
            Console.WriteLine("Precio: $" + Precio);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del producto 1 y establecer valores
            Producto producto1 = new Producto();
            producto1.Nombre = "Gaseosa";
            producto1.Descripcion = "Bebida fría";
            producto1.Precio = 2500;

            // Mostrar los detalles del producto 1
            Console.WriteLine("Los datos del producto #1 son:");
            producto1.Imprimir();
            Console.WriteLine();

            // Crear una instancia del producto 2 y establecer valores
            Producto producto2 = new Producto();
            producto2.Nombre = "Granizado";
            producto2.Descripcion = "Bebida helada";
            producto2.Precio = 8000;

            // Mostrar los detalles del producto 2
            Console.WriteLine("Los datos del producto #2 son:");
            producto2.Imprimir();
            Console.WriteLine();

            // Crear una instancia del producto 3 y establecer valores
            Producto producto3 = new Producto();
            producto3.Nombre = "Café";
            producto3.Descripcion = "Bebida caliente";
            producto3.Precio = 1000;

            // Mostrar los detalles del producto 3
            Console.WriteLine("Los datos del producto #3 son:");
            producto3.Imprimir();

            Console.ReadKey();
        }
    }
}
