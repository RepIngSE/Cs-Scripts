using System;
using System.Collections; 

//Concat es un método usado para combinar 2 o + cadenas de texto y devolver una cadena de texto nueva. 
 
namespace Ejercicio3
{
  public class Ejercicio3
  {
    public static void Main()
    {
         String cadena1 = "Hola";
         String cadena2 = "mundo";
         String ca = String.Concat(cadena1, " " , cadena2);
         Console.WriteLine(ca); 
    }
  }
}
