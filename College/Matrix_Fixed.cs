using System;
using System.Collections;

namespace Ejercicio11
{
    class Paises
    {
        private string [,] MatrizCiudades;
        private string [,] MatrizPais;
        int CANTIDAD_FILAS=4;
        int CANTIDAD_COLUMNAS=4;
        int CANTIDAD_COLUMNAS1=2;
        string p="", Ciu="";
        public void CargaMatrizyVector()
        {
            MatrizCiudades=new string[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];
            MatrizPais=new string[CANTIDAD_FILAS,CANTIDAD_COLUMNAS1];
            

            for(int f=0;f<CANTIDAD_FILAS;f++){
                for(int c1=0;c1<CANTIDAD_COLUMNAS1;c1++){
                    if(c1==1){
                        Console.Write("Digite el país:");
                        MatrizPais[f,c1]=Console.ReadLine();
                        
                    }else{
                        p="País:";
                    }
                }
                for(int c=0;c<CANTIDAD_COLUMNAS;c++){
                    if(c!=0){
                        Console.Write("Digite las ciudades:");
                        MatrizCiudades[f,c]=Console.ReadLine();
                        
                    }else{
                        Ciu="Ciudades:";
                    }
                }   
            }         
        }
        public void MostrarTodo()
        {
            for(int f=0;f<CANTIDAD_FILAS;f++){
                Console.Write(p);
                for(int c1=0;c1<CANTIDAD_COLUMNAS1;c1++){
                    Console.Write(""+MatrizPais[f,c1]+"  ");
                }
                Console.Write(Ciu);
                for(int c=0;c<CANTIDAD_COLUMNAS;c++){
                    Console.Write(" "+MatrizCiudades[f,c]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Paises op=new Paises();
            op.CargaMatrizyVector();
            op.MostrarTodo();
        }
    }
}
