using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A a1 = new A("Pepe");
            B b = new B();
            a.MostrarNombre();
            a1.MostrarNombre();
            b.MostrarNombre();
            a.M1();
            a.M2();
            a.M3();
            b.M1();
            b.M2();
            b.M3();
            b.M4();
        }
    }
}
