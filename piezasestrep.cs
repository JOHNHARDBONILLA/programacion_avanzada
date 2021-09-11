using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piezasEStRep
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, cantidad, n;
            float largo;
            string linea;
            X = 1;
            cantidad = 0;
            Console.Write("Cuantas piezas desea procesar: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while(X<=n)
            {
                Console.Write("ingrese la medida de la pieza: ");
                linea = Console.ReadLine();
                largo = float.Parse(linea);
                if(largo>=1.20 && largo<=1.30)
                {
                    cantidad = cantidad + 1;
                }
                X = X + 1;
            }
            Console.Write("La cantidad de piezas aptas son: ");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}
