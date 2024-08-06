using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Alumno
    {
        private int _id;

        public int Id
        {
            get; set;
        }

        private string _nombre;

        public string Nombre
        {
            get; set;
        }

        private string _apellido;

        public string Apellido
        {
            get; set;
        }

        private int _legajo;

        public int Legajo
        {
            get; set;
        }

        private string _direccion;

        public string Direccion
        {
            get; set;
        }
    }
}
