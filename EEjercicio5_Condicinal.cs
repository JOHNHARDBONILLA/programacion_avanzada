using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosenclase
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
           

            if (num1 > 0)
            {             
                Console.Write("El numero es " + num1 + " es positivo");                
            } 
            else
            {
                if (num1 < 0)
                {
                    Console.Write("El numero es " + num1 + " es negativo");
                }

                else 
                {
                    Console.Write("El numero es " + num1 + " es nulo");
                }
                                  
            }
                            Console.ReadKey();
            
        }
    }
}
