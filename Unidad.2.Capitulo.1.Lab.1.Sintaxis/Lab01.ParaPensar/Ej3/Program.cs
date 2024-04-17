using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = 0, b = 1, c = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write(a);
                Console.Write(", ");
                c = b;
                b = a + b;
                a = c;
            }
            Console.ReadLine();
        }
    }
}
