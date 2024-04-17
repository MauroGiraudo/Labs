using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes para visualizar su número correspondiente: ");
            string mes = (Console.ReadLine()).ToLower();
            switch (mes)
            {
                case "enero":
                    Console.WriteLine("Corresponde al mes n° 1");
                    break;
                case "febrero":
                    Console.WriteLine("Corresponde al mes n° 2");
                    break;
                case "marzo":
                    Console.WriteLine("Corresponde al mes n° 3");
                    break;
                case "abril":
                    Console.WriteLine("Corresponde al mes n° 4");
                    break;
                case "mayo":
                    Console.WriteLine("Corresponde al mes n° 5");
                    break;
                case "junio":
                    Console.WriteLine("Corresponde al mes n° 6");
                    break;
                case "julilo":
                    Console.WriteLine("Corresponde al mes n° 7");
                    break;
                case "agosto":
                    Console.WriteLine("Corresponde al mes n° 8");
                    break;
                case "septiembre":
                    Console.WriteLine("Corresponde al mes n° 9");
                    break;
                case "setiembre":
                    Console.WriteLine("Corresponde al mes n° 9");
                    break;
                case "octubre":
                    Console.WriteLine("Corresponde al mes n° 10");
                    break;
                case "noviembre":
                    Console.WriteLine("Corresponde al mes n° 11");
                    break;
                case "diciembre":
                    Console.WriteLine("Corresponde al mes n° 12");
                    break;
                default:
                    Console.WriteLine("Error. No ha ingresado un mes...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
