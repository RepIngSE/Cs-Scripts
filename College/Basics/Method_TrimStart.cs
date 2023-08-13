using System;

//Método que elimina caracteres específicos 

class ABC {
 
    public static void Main()
    {
        // Definir una cadena de texto con caracteres al principio y al final
        string s1 = "***000000000000abc000****";

        // Definir un arreglo de caracteres para ser eliminados al principio de la cadena s1
        char[] charsToTrim1 = { '*', '0' };

        // Definir dos cadenas de texto
        string s2 = "  abc";
        string s3 = "  -ABC-";

        // Mostrar las cadenas originales
        Console.WriteLine("Antes:");
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine();

        // Mostrar las cadenas después de aplicar el método TrimStart()
        Console.WriteLine("Después:");
        Console.WriteLine(s1.TrimStart(charsToTrim1));
        Console.WriteLine(s2.TrimStart());
        Console.WriteLine(s3.TrimStart('-'));
    }
}
