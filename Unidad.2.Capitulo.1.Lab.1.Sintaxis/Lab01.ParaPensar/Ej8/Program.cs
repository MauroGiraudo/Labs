using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clave = "Hola123";
            int intentos = 4;
            do
            {
                Console.Clear();
                Console.Write("Ingrese la clave. Tiene ");
                Console.Write(intentos);
                Console.Write(" intentos: ");
                string intentoUsuario = Console.ReadLine();
                if (intentoUsuario.ToLower() != clave.ToLower())
                {
                    intentos--;
                } else
                {
                    intentos = -1;
                }
            } while (intentos > 0);
            Console.Clear(); 
            if (intentos == 0)
            {
                Console.WriteLine("Se ha quedado sin intentos...");
            } else
            {
                Console.WriteLine("La clave es correcta.");
            }
            Console.ReadLine();
        }
    }
}
