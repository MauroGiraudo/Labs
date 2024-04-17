using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("El resultado de la suma de ");
            Console.Write(num1);
            Console.Write(" y ");
            Console.Write(num2);
            Console.Write(" es ");
            Console.Write(num1 + num2);
            Console.WriteLine("\n");
        }
    }
}
