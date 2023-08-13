using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Problema6
{
    class program
    {
        static void Main(string[] args)
        {
            float ValorEnSegundos, SEGUNDOS, MINUTOS, HORAS, DIAS;
            Console.WriteLine("Hola, ingresa el número de segundos");
            ValorEnSegundos = float.Parse(System.Console.ReadLine());

            SEGUNDOS = ValorEnSegundos;
            MINUTOS = ValorEnSegundos /60;
            HORAS = ValorEnSegundos /3600;
            DIAS = ValorEnSegundos /86400;

            Console.WriteLine("El valor en segundos es de: {0},en minutos es de: {1}, en horas es de {2}, en días es de: {3}", SEGUNDOS, MINUTOS, HORAS, DIAS);
        }
    }
}
