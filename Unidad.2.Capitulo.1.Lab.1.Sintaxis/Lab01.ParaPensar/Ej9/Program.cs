using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dibujador de Triángulos. Ingrese el N° de filas que conformará al triángulo: ");
            int filas = int.Parse(Console.ReadLine());
            int columnas = 2 * filas + 1;
            string[,] ar =  new string[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    ar[i, j] = " ";
                }
            }
            Console.Clear();
            for (int i = 0; i < filas; i++)
            {
                int asteriscos = 2 * i + 1;
                int media = (columnas / 2) + 1;
                for (int j = (media - i); j <= (media + i); j++)
                {
                    ar[i, j] = "*";
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(ar[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
