namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // este metodo se utiliza para que al escribir una palabra y si nos aparece true es que si aparece en la oracion
            //y false si no esta en la oracion
            string palabra = "este es el ejercicio de Endswith";
           
            Console.WriteLine(palabra);
            Console.WriteLine(palabra.EndsWith("Endswith"));
            Console.WriteLine(palabra.EndsWith("Ejercicio"));
        }
    }
}
