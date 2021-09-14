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
            float not1, not2, not3, promedio;
            string linea;

            Console.Write("Ingrese la primera nota: ");
            linea = Console.ReadLine();
            not1 = float.Parse(linea);
            Console.Write("Ingrese la segunda nota: ");
            linea = Console.ReadLine();
            not2 = float.Parse(linea);
            Console.Write("Ingrese la tercera nota: ");
            linea = Console.ReadLine();
            not3 = float.Parse(linea);
            promedio = (not1 + not2 + not3) / 3;

            if (promedio>=7)
            {
                                
                Console.Write("Promovido");
                
                
            }
            else

                Console.Write("No promovido");


            Console.ReadKey();
        }
    }
}
