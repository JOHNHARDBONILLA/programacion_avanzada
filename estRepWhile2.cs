using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estRepWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,x;
            string lnea;
            Console.Write("ingrese el valor final: ");
            lnea = Console.ReadLine();
            n = int.Parse(lnea);
            x = 1;
            while (x<=n)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x+1;
            }
            Console.ReadKey();

        }
    }
}
