using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año: aaaa");
            int anio = int.Parse(Console.ReadLine());
            if (anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine("Es Bisiesto");
            }
            else
            {
                Console.WriteLine("No es Bisiesto");
            }
            Console.ReadLine();
        }
    }
}
