using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        string _nombreInstancia;
        public string NombreInstancia
        {
            get
            {
                return _nombreInstancia;
            }
            set
            {
                _nombreInstancia = value;
            }
        }
        public A()
        {
            _nombreInstancia = "Instancia Sin Nombre";
        }
        public A(string instanceName)
        {
            _nombreInstancia = instanceName;
        }
        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }
        // ¿Es esta la función que se pide que tengan los métodos M1, M2 y M3 en el enunciado?
        public void M1()
        {
            Console.WriteLine("El método M1 fue invocado");
        }
        public void M2()
        {
            Console.WriteLine("El método M2 fue invocado");
        }
        public void M3()
        {
            Console.WriteLine("El método M3 fue invocado");
        }
    }
}
