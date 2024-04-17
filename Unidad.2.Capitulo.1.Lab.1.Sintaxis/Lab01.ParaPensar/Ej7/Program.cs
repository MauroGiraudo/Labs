using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calcular los N primeros números primos gemelos.

namespace Ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se mostrarán los primeros N números primos gemelos. Ingrese el valor de N: ");
            int num = int.Parse(Console.ReadLine());
            int p = 0, q = 0;
            for (int i = 0; i < num; i++)
            {
                bool primo = false;
                while (primo == false)
                {
                    int j = 0;
                    p++;
                    for (int k = 1; k <= p; k++)
                    {
                        if (p % k == 0) j++;
                    }
                    if (j == 2 || p == 1)
                    {
                        int l = 0;
                        q = p + 2;
                        for (int k = 1; k <= q; k++)
                        {
                            if (q % k == 0) l++;
                        }
                        if (l == 2)
                        {
                            primo = true;
                            Console.Write(p);
                            Console.Write(" - ");
                            Console.WriteLine(q);
                        }
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
