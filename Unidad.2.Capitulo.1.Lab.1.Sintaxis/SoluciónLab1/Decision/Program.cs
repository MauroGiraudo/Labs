using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese texto:");
            string InputTexto = Console.ReadLine();
            if (InputTexto.Length == 0) {
                Console.WriteLine("No ha ingresado texto...");
            } else
            {
                Console.WriteLine("1- Mayusculas\n2- Minusculas\n3- Cantidad de Caracteres");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine("\n");
                if (opcion.Key == ConsoleKey.D1) 
                {
                    Console.WriteLine(InputTexto.ToUpper());
                } else if (opcion.Key == ConsoleKey.D2) 
                {
                    Console.WriteLine(InputTexto.ToLower());
                } else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine(InputTexto.Length);
                }

            }
        }
    }
}
