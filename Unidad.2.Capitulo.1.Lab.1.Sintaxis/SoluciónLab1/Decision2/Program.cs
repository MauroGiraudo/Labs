using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese texto:");
            string InputTexto = Console.ReadLine();
            if (InputTexto.Length == 0)
            {
                Console.WriteLine("No ha ingresado texto...");
            }
            else
            {
                Console.WriteLine("1- Mayusculas\n2- Minusculas\n3- Cantidad de Caracteres");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine("\n");
                switch (opcion.Key)
                {
                    case (ConsoleKey.D1):
                        Console.WriteLine(InputTexto.ToUpper());
                        break;
                    case (ConsoleKey.D2):
                        Console.WriteLine(InputTexto.ToLower());
                        break;
                    case (ConsoleKey.D3):
                        Console.WriteLine(InputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("Error. Opción incorrecta.");
                        break;
                }
            }
        }
    }
}
