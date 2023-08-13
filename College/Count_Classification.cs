using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar una variable de cadena para almacenar la frase ingresada.
            string Frase = "";
            // Declarar variables enteras para contar caracteres, consonantes, vocales y números.
            int CantCaracter, ContConso = 0, ContVocal = 0, ContNum = 0;
            // Declarar una variable char para almacenar caracteres individuales de la frase.
            char i;

            // Solicitar al usuario que ingrese una frase.
            Console.WriteLine("Digite una frase.");
            // Leer la frase ingresada por el usuario.
            Frase = System.Console.ReadLine();

            // Iterar a través de cada carácter de la frase ingresada.
            for (CantCaracter = 0; CantCaracter < Frase.Length; CantCaracter++)
            {
                // Obtener el carácter actual.
                i = Frase[CantCaracter];
                // Convertir el carácter a minúscula para comparación sin distinción de mayúsculas y minúsculas.
                int Caracter = char.ToLower(i);

                // Verificar si el carácter es una vocal (a, e, i, o, u).
                if (Caracter == 'a' || Caracter == 'e' || Caracter == 'i' || Caracter == 'o' || Caracter == 'u')
                {
                    // Incrementar el contador de vocales.
                    ContVocal++;
                }
                // Verificar si el carácter es un dígito (0-9).
                else if (Caracter >= '0' && Caracter <= '9')
                {
                    // Incrementar el contador de números.
                    ContNum++;
                }
                else
                {
                    // Si no es vocal ni número, incrementar el contador de consonantes.
                    ContConso++;
                }
            }

            // Mostrar los recuentos y el total de caracteres de cada tipo.
            Console.WriteLine("Tú frase tiene " + ContVocal + " vocales.");
            Console.WriteLine("Tú frase tiene " + ContConso + " consonantes.");
            Console.WriteLine("Tú frase tiene " + ContNum + " números.");
            Console.WriteLine("En total tiene " + Frase.Length + " caracteres.");
        }
    }
}
