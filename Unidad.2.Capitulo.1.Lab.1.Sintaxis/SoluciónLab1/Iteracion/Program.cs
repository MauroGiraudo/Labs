using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantInteracciones = 5;
            string[] cadena = new string[cantInteracciones];
            for (int i = 0; i < cantInteracciones; i++)
            {
                cadena[i] = Console.ReadLine();
            }
            for (int i = cantInteracciones - 1; i > -1; i--)
            {
                Console.WriteLine(cadena[i], "\n");
            }
        }
    }
}
