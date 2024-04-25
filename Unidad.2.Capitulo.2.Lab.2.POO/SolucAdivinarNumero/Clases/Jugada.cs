using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugada
    {
        public int m_numero;
        public int m_intentos = 5;
        public int m_respuesta;
        public int Numero
        {
            get
            {
                return m_numero;
            }
            set
            {
                m_numero = value;
            }
        }

        public int Respuesta
        {
            get
            {
                return m_respuesta;
            }
            set
            {
                m_respuesta = value;
            }
        }

        public int Intentos
        {
            get
            {
                return m_intentos;
            }
            set
            {
                m_intentos = value;
            }
        }

        public void InformarNumero()
        {
            Console.WriteLine("\nEl número correcto era: " + this.Numero);
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }
    }
}
