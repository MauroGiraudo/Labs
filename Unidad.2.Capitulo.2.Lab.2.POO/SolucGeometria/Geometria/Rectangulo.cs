using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rectangulo : Poligono
    {
        private int m_lado1;
        private int m_lado2;

        public int Lado1
        {
            get => default;
            set
            {
            }
        }

        public int Lado2
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
