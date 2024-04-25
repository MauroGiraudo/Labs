using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {

        }
        public void Comparar()
        {
            if (this.Respuesta - this.Numero <= 5 && this.Respuesta - this.Numero > 0)
            {
                Console.WriteLine("\nEl número es menor y está muy cerca");
            } else if (this.Respuesta - this.Numero >= -5 && this.Respuesta - this.Numero < 0)
            {
                Console.WriteLine("\nEl número es mayor y está muy cerca");
            } else if (this.Respuesta - this.Numero <= 10 && this.Respuesta - this.Numero > 5)
            {
                Console.WriteLine("\nEl número es menor y está cerca");
            } else if (this.Respuesta - this.Numero >= -10 && this.Respuesta - this.Numero < -5)
            {
                Console.WriteLine("\nEl número es mayor y está cerca");
            } else if (this.Respuesta - this.Numero <= 15 && this.Respuesta - this.Numero > 10)
            {
                Console.WriteLine("\nEl número es menor y está lejos");
            } else if (this.Respuesta - this.Numero >= -15 && this.Respuesta - this.Numero < -10)
            {
                Console.WriteLine("\nEl número es mayor y está lejos");
            } else if (this.Respuesta - this.Numero <= 20 && this.Respuesta - this.Numero > 15)
            {
                Console.WriteLine("\nEl número es menor y está muy lejos");
            } else if (this.Respuesta - this.Numero >= -20 && this.Respuesta - this.Numero < -15)
            {
                Console.WriteLine("\nEl número es mayor y está muy lejos");
            } else if (this.Respuesta - this.Numero > 20)
            {
                Console.WriteLine("El número es menor y  está extremadamente lejos");
            } else if (this.Respuesta - this.Numero < -20)
            {
                Console.WriteLine("\nEl número es mayor y está extremadamente lejos");
            }
        }
    }
}
