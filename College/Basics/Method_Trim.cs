using System;

//Método que sirve para quitar espacios al inicio y final de un texto

class ABC {
    public static void Main()
    {
        // Definir dos cadenas de texto, una con espacios al principio y otra con espacios al principio y al final
        string j1 = " ABC";
        string j2 = " ABC ";

        // Mostrar las cadenas originales
        Console.WriteLine("Antes");
        Console.WriteLine(j1);
        Console.WriteLine(j2);
        Console.WriteLine();

        // Mostrar las cadenas después de aplicar el método Trim()
        Console.WriteLine("Después:");
        Console.WriteLine(j1.Trim());
        Console.WriteLine(j2.Trim());
    }
}
