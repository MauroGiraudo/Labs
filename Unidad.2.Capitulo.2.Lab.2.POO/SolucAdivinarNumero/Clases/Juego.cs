using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Juego
    {
        public Juego()
        {

        }

        private int m_record;

        public int Record
        {
            get
            {
                return m_record;
            }
            set
            {
                m_record = value;
            }
        }

        public void ComenzarJuego()
        {
            int opc;
            Record = 0;
            do
            {
                Console.Clear();
                Console.Write("Adivinanza de números entre 0 y N\n\nIngrese el valor de N: ");
                int recordJugadaActual = 0;
                int m_n = int.Parse(Console.ReadLine());
                JugadaConAyuda jug = new JugadaConAyuda(m_n);
                do
                {
                    Console.Clear();
                    Console.WriteLine("Adivine el número entre 0 y " + m_n);
                    Console.WriteLine();
                    Console.WriteLine("Le quedan " + jug.Intentos + " intentos");
                    Console.WriteLine();
                    Console.Write("Ingrese un número: ");
                    jug.Respuesta = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (jug.Respuesta == jug.Numero)
                    {
                        Console.WriteLine("¡Ha adivinado el número!\nEl juego ha finalizado");
                    }
                    else if (jug.Intentos == 1 && jug.Respuesta != jug.Numero)
                    {
                        Console.WriteLine("¡Se ha quedado sin intentos!");
                        jug.InformarNumero();
                        Console.WriteLine("\nEl juego ha finalizado");
                    }
                    else
                    {
                        Console.WriteLine("¡Ese no es el número correcto! Inténtelo nuevamente");
                        Console.WriteLine();
                        Console.Write("¿Desea una pista respecto al número a adivinar? [1 = Si | 2 = No]: ");
                        int pista = int.Parse(Console.ReadLine());
                        while (pista > 2 || pista < 1)
                        {
                            Console.WriteLine("\nValor incorrecto. Ingréselo nuevamente.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Adivine el número entre 0 y " + m_n);
                            Console.WriteLine();
                            Console.WriteLine("Le quedan " + jug.Intentos + " intentos");
                            Console.WriteLine();
                            Console.Write("Ingrese un número: " + jug.Respuesta);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("¡Ese no es el número correcto! Inténtelo nuevamente");
                            Console.WriteLine();
                            Console.Write("¿Desea una pista respecto al número a adivinar? [1 = Si | 2 = No]: ");
                            pista = int.Parse(Console.ReadLine());
                        }
                        if (pista == 1)
                        {
                            jug.Comparar();
                        }
                    }
                    jug.Intentos = jug.Intentos - 1;
                    recordJugadaActual++;
                    Console.WriteLine();
                    Console.WriteLine("Presione alguna tecla para continuar");
                    Console.ReadLine();
                } while (jug.Respuesta != jug.Numero && jug.Intentos != 0);

                if (Record == 0)
                {
                    Record = recordJugadaActual;
                }

                if (Record > recordJugadaActual) Record = recordJugadaActual;

                do
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("1- Volver a jugar\n\n2- Ver récord \n\n3- Salir\n\nIngrese el número de la opción a acceder: ");
                        opc = int.Parse(Console.ReadLine());
                        if (opc < 1 || opc > 3)
                        {
                            Console.WriteLine(opc + " No es una opción válida. Inténtelo nuevamente");
                            Console.ReadLine();
                        }
                    } while (opc < 1 || opc > 3);
                    if (opc == 2)
                    {
                            Console.Clear();
                            Console.WriteLine("El récord actual es de: " + RecordActual() + " intentos (Máximo = 5)");
                            Console.WriteLine();
                            Console.WriteLine("Presione alguna tecla para continuar");
                            Console.ReadLine();
                    }
                } while (opc != 1 && opc != 3);
            } while (opc != 3);
        }

        public int RecordActual()
        {
            return Record;
        }
    }
}
