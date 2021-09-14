using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;

            Console.Write("Ingrese un numero entero : ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);


            if (num1 >= 0 && num1 <= 9)
            {

                Console.Write("El numero " + num1 + " tiene 1 cifra");


            }
            else
            {
                if (num1 >= 10 && num1 <= 99)
                {
                    Console.Write("El numero " + num1 + " tiene 2 cifras");
                }

                else
                {
                    if (num1 >= 100 && num1 <= 999)
                    {
                        Console.Write("El numero " + num1 + " tiene 3 cifras");
                    }

                   
                        
                 
                    
                }
                 

            }


           

            Console.ReadKey();
        }
    }
}

