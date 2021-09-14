using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEjercicio7_Condicinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantitotalpreg, cantipregcorr, porc;
            string linea;

            Console.Write("Ingrese la cantidad total de preguntas que se le realizaron : ");
            linea = Console.ReadLine();
            porc=cantitotalpreg = int.Parse(linea);

            Console.Write("Ingrese la cantidad de preguntas que contestó correctamente : ");
            linea = Console.ReadLine();
            cantipregcorr = int.Parse(linea);

            porc = cantipregcorr * 100 / cantitotalpreg;

            if (porc >= 90)
            {

                Console.Write("Nivel maximo");


            }
            else if (porc >= 75 && porc < 90)
            
                
                {
                    Console.Write("Nivel medio");
                }

            else if (porc >= 50 && porc < 75)
            
                     
                    {
                        Console.Write("Nivel regular");
                    }
            else if (porc < 50)
            
                        
                        {
                            Console.Write("fuera de nivel");
                        }
            else 
                

                    {
                        Console.Write("Error, Ingresa bien tus datos");
                    }









                    Console.ReadKey();
        }
    }
}

        
    

