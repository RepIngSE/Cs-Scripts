using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Valorabsoluto
{
    class program
    {
        static void Main(string[] args)
        {
            float Valor, AbsolutoPositivo, AbsolutoNegativo;
            Console.WriteLine("Hola, ingresa el valor del número para obtener su valor absoluto");
            Valor = float.Parse(System.Console.ReadLine());

            AbsolutoPositivo = Valor;

            if (Valor > 0)
            {
                Console.WriteLine("El valor absoluto de {0} es de {1}", Valor, AbsolutoPositivo);
            }

            AbsolutoNegativo = (Valor * -1);

            if (Valor <= 0)
            {
                Console.WriteLine("El valor absoluto de {0} es de {1}", Valor, AbsolutoNegativo);
            }
        }
    }
}
