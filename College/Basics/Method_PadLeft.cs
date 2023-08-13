namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // esta metodo se utiliza para colocar un numero va a colocar la cantidad de espacios contrando las letras ejemplo 
            //si coloca 15 me va a contar 7 espacios y 8 letras.
            string palabra = " PadLeft ";

            Console.WriteLine(palabra);
            Console.WriteLine(palabra.PadLeft( 20,'°')) ;
            Console.ReadLine();
           
        }
    }
}
