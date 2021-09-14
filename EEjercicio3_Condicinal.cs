using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;

            Console.Write("Ingrese un valor entero de 1 o 2 digitos: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            

            if (num1>=10)
            {
                                
                Console.Write("El numero tiene 2 digitos");
                
                
            }
            else
            {
               
               
                    Console.Write("El numero tiene 1 digito");
               
            }
                


            Console.ReadKey();
        }
    }
}
