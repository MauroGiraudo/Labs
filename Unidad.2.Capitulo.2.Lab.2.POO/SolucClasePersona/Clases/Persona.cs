using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string m_nombre;
        public string m_apellido;
        public int m_edad;
        public string m_dni;

        public Persona(string nom, string ape, int edad, string dni)
        {
            this.m_nombre = nom;
            this.m_apellido = ape;
            this.m_edad = edad;
            this.m_dni = dni;
            Console.WriteLine("Se ha creado una instancia de la clase 'Persona' con éxito");
        }
        
        ~Persona()
        {
            Console.WriteLine("La instancia ha sido eliminada con éxito");
        }

        public string Nombre
        {
            get
            {
                return m_nombre;
            }
            set
            {
                m_nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return m_apellido;
            }
            set
            {
                m_apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return m_edad;
            }
            set
            {
                m_edad = value;
            }
        }

        public string Dni
        {
            get
            {
                return m_dni;
            }
            set
            {
                m_dni = value;
            }
        }

        public void GetFullName()
        {
            Console.WriteLine("¡Hola! Mi nombre es " + m_nombre + " " + m_apellido);
        }

        public int GetAge(int anio)
        {
            int anioNacimiento = DateTime.Now.Year - Edad;
            if (anio - anioNacimiento >= 0)
            {
                return anio - anioNacimiento;
            }
            return -1;
        }
    }
}
