using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número y se mostrará el correspondiente en romano: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string[] roman = new string[15];
            for (int i = 0; i < roman.Length; i++) roman[i] = "n";
            int j = 0;
            while ((num - 1000) >= 0)
            {
                num -= 1000;
                roman[j] = "M";
                j++;
            }
            while ((num - 500) >= 0)
            {
                if (num >= 900 && num <= 999)
                {
                    num -= 900;
                    roman[j] = "CM";
                } else
                {
                    num -= 500;
                    roman[j] = "D";
                }
                j++;
            }
            while ((num - 100) >= 0)
            {
                if (num >= 400 && num <= 499)
                {
                    num -= 400;
                    roman[j] = "CD";
                } else
                {
                    num -= 100;
                    roman[j] = "C";
                }
                j++;
            }
            while ((num - 50) >= 0)
            {
                if (num >= 90 && num <= 99)
                {
                    num -= 90;
                    roman[j] = "XC";
                } else
                {
                    num -= 50;
                    roman[j] = "L";
                }
                j++;
            }
            while ((num - 10) >= 0)
            {
                if (num >= 40 && num <= 49)
                {
                    num -= 40;
                    roman[j] = "XL";
                } else
                {
                    num -= 10;
                    roman[j] = "X";
                }
                j++;
            }
            while ((num - 5) >= 0)
            {
                if(num == 9)
                {
                    num -= 9;
                    roman[j] = "IX";
                } else
                {
                    num -= 5;
                    roman[j] = "V";
                }
                j++;
            }
            while ((num - 1) >= 0)
            {
                if (num == 4)
                {
                    num -= 4;
                    roman[j] = "IV";
                } else
                {
                    num -= 1;
                    roman[j] = "I";
                }
                j++;
            }
            j = 0;
            while (roman[j] != "n")
            {
                Console.Write(roman[j]);
                j++;
            }
            Console.ReadLine();
        }
    }
}
