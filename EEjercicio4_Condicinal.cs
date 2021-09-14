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
            float num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);
            Console.Write("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);


            if (num1>num2 && num1>num3)
            {
                                
                Console.Write("El numero mayor es: ");
                Console.WriteLine(num1);


            }
            else 
            {
              if (num2 > num1 && num2 > num3)
                { 

                Console.Write("El numero mayor es:");
                Console.WriteLine(num2);

                }
              else
                {
                 Console.Write("El numero mayor es:");
                 Console.WriteLine(num3);
                }

            }
                


            Console.ReadKey();
        }
    }
}
