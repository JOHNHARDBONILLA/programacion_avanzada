using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            string linea;
            Console.Write("ingrese un valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("ingere un segundo valor");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if(num1>num2)
            {
                int suma, diferencia;
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.Write("la suma de los valores es: ");
                Console.WriteLine(suma);
                Console.Write("la diferencia de los valores es: ");
                Console.WriteLine(diferencia);

            }
            else
            {
                int producto, division;
                producto = num1 * num2;
                division = num1 / num2;
                Console.Write("el producto de los valores es: ");
                Console.WriteLine(producto);
                Console.Write("la division de los valores es: ");
                Console.WriteLine(division);
            }
            Console.ReadKey();
        }
    }
}
