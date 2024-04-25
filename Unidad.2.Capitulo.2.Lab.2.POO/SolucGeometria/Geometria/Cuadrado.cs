using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Cuadrado : Rectangulo
    {
        private int m_lado;

        public int Lado
        {
            get => default;
            set
            {
            }
        }

        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }
}
