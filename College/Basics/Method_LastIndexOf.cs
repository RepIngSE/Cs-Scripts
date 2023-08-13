namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // esta metodo se utiliza para encontar la posicion de la palabra que escribimos
            string palabras  = "este es el ejercicio de lastlndexof ";
           
            Console.WriteLine(palabras);
            int palabra = palabras.LastIndexOf("ejercicio");
            Console.WriteLine("lo encontre esta en la posicion: "+palabra);
        
        }
    }
}
