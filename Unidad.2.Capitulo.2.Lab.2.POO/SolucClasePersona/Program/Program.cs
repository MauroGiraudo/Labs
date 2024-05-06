using System;
using Clases;

namespace Program
{
    public class Programa
    {
        static void Main()
        {
            Console.Write("Ingrese el nombre de la persona: ");
            string nom = Console.ReadLine();
            Console.Write("Ingrese el apellido de la persona: ");
            string ape = Console.ReadLine();
            Console.Write("Ingrese la edad de la persona: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el DNI de la persona: ");
            string dni = Console.ReadLine();
            Persona persona = new Persona(nom, ape, edad, dni);
            int anio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un año para saber la edad de la persona en el mismo");
            persona.GetAge(anio);
            Console.Write("Saludo: ");
            persona.GetFullName();
        }
    }
}

