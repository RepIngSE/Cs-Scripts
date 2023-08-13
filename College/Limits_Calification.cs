using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {
        string[]nombre;
        int nombres;
        double nota1;
        int TAMAÑO_VECTOR = 12;
        
        
        public void Operaciones()
        {

 
            double nota1;
            string nombres ;
            double nota=0;
          
            nombre=new string[TAMAÑO_VECTOR];

            for (int f = 0; f < nombre.Length; f++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante : ");
                nombres = (Console.ReadLine());

                Console.WriteLine("Ingrese nota en el rango de 0 a 10: ");
                nota = double.Parse(Console.ReadLine());
            
               
                    if (nota  < 5)     
                    {
                        Console.WriteLine("la nota es insuficiente ");
                    }
                    if (nota >= 5 && nota  < 7)
                    {
                        Console.WriteLine("la nota es aceptable");
                    }
                        
                    if (nota >= 7 && nota < 9)
                    {
                        Console.WriteLine("la nota es sobresaliente");
                    }
                    if (nota >= 9.0 && nota <= 10)
                    {
                            Console.WriteLine("la nota es excelente");
                    }
                
                
               
                Console.WriteLine("el estudiante " + nombres + " tiene una nota de "+ nota);
                
                
            }    
        }
      
        static void Main(string[] args)

        {
            program Program = new program();

            Program.Operaciones();
            
            
        }
    }
}
