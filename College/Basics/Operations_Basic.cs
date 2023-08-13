using System;

namespace AplicacionBase
{
    // Clase base Operacion con propiedades para valores y resultado
    public class Operacion
    {
        protected int valor1;
        protected int valor2;
        protected double valor4;
        protected int resultado;

        public int Valor1
        {
            set { valor1 = value; }
            get { return valor1; }
        }
        
        public int Valor2
        {
            set { valor2 = value; }
            get { return valor2; }
        }

        public double Valor4
        {
            set { valor4 = value; }
            get { return valor4; }
        }

        public int Resultado
        {
            protected set { resultado = value; }
            get { return resultado; }
        }
    }

    // Clase Suma que hereda de Operacion y realiza una suma
    public class Suma : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }

    // Clase Resta que hereda de Operacion y realiza una resta
    public class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }

    // Clase Multiplicación que hereda de Operacion y realiza una multiplicación
    public class Multiplicacion : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 * Valor2;
        }
    }

    // Clase División que hereda de Operacion y realiza una división
    public class Division : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 / Valor2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Realizar suma
            Suma suma1 = new Suma();
            suma1.Valor1 = 10;
            suma1.Valor2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma de " + suma1.Valor1 + " + " + suma1.Valor2 + " = " + suma1.Resultado);

            // Realizar resta
            Resta resta1 = new Resta();
            resta1.Valor1 = 8;
            resta1.Valor2 = 4;
            resta1.Operar();
            Console.WriteLine("La resta de " + resta1.Valor1 + " - " + resta1.Valor2 + " = " + resta1.Resultado);

            // Realizar multiplicación
            Multiplicacion multiplicacion1 = new Multiplicacion();
            multiplicacion1.Valor1 = 9;
            multiplicacion1.Valor2 = 78;
            multiplicacion1.Operar();
            Console.WriteLine("La multiplicación de " + multiplicacion1.Valor1 + " * " + multiplicacion1.Valor2 + " = " + multiplicacion1.Resultado);

            // Realizar división
            Division division1 = new Division();
            division1.Valor1 = 78;
            division1.Valor2 = 6;
            division1.Operar();
            Console.WriteLine("La división de " + division1.Valor1 + " / " + division1.Valor2 + " = " + division1.Resultado);

            Console.ReadKey();
        }
    }
}
