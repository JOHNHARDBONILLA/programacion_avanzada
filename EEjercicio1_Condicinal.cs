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
            float num1, num2;
            string linea;

            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);

            if (num1 > num2)
            {
                float suma, diferencia;
                suma = num1 + num2;
                diferencia = num1 - num2;

                Console.Write("La suma de los numeros es : ");
                Console.WriteLine(suma);
                Console.Write("La diferencia de los numeros es : ");
                Console.WriteLine(diferencia);

            } 
            else
            {
                float division, producto;
                division = num1 / num2;
                producto = num1 * num2;

                Console.Write("La division de los numeros es : ");
                Console.WriteLine(division);
                Console.Write("El producto de los numeros es : ");
                Console.WriteLine(producto);
            }
            Console.ReadKey();
        }
    }
}
