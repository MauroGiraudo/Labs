using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;

namespace EntityFramework
{
    class Program
    {
        public static void Main(string[] args)
        {         
            string rta = "";
            do
            {
                Console.WriteLine("1- Crear Alumno");
                Console.WriteLine("2- Mostrar Alumno por Id");
                Console.WriteLine("3- Actualizar Alumno");
                Console.WriteLine("4- Eliminar Alumno");
                Console.WriteLine("5- Salir");
                Console.Write("Ingrese el nro de la opción a utilizar: ");
                rta = Console.ReadLine();
                switch (rta)
                {
                    case "1":
                        Crear();
                        break;
                    case "2":
                        Leer();
                        break;
                    case "3":
                        Actualizar();
                        break;
                    case "4":
                        Eliminar();
                        break;
                    default:
                        break;
                }
            } while (rta != "5");
        }

        public static void Crear()
        {
            using (UniversidadContext uniContext = new UniversidadContext())
            {
                uniContext.Alumnos.Add(new Alumno()
                {
                    Id = int.Parse(Console.ReadLine()),
                    Nombre = Console.ReadLine(),
                    Apellido = Console.ReadLine(),
                    Legajo = int.Parse(Console.ReadLine()),
                    Direccion = Console.ReadLine()
                });

                uniContext.SaveChanges();
            }
        }

        public static void Leer()
        {
            using(UniversidadContext uniContext = new UniversidadContext())
            {
                Console.Write("Ingrese el Id del usuario para visualizar sus datos: ");
                int idInput = int.Parse(Console.ReadLine());
                Alumno alu = uniContext.Alumnos.Find(idInput);
                if (alu != null)
                {
                    Console.WriteLine("Legajo: {0}", alu.Legajo);
                    Console.WriteLine("Nombre: {0}", alu.Nombre);
                    Console.WriteLine("Apellido: {0}", alu.Apellido); 
                    Console.WriteLine("Direccion: {0}", alu.Direccion);
                    Console.WriteLine();
                }
                /*foreach(Alumno alu in uniContext.Alumnos.Where(x=>x.Id == idInput))
                {
                    Console.WriteLine("Legajo: {0}", alu.Legajo);
                    Console.WriteLine("Nombre: {0}", alu.Nombre);
                    Console.WriteLine("Apellido: {0}", alu.Apellido);
                    Console.WriteLine();
                }*/
            }
        }

        public static void Actualizar()
        {
            using(UniversidadContext uniContext = new UniversidadContext())
            {
                int idInput = int.Parse(Console.ReadLine());
                Alumno alu = uniContext.Alumnos.Find(idInput);
                if (alu != null)
                {
                    Console.WriteLine("Ingrese Nombre: ");
                    alu.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Apellido: ");
                    alu.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese Lejago: ");
                    alu.Legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nombre: ");
                    alu.Direccion = Console.ReadLine();

                    uniContext.SaveChanges();
                }
            }
        }

        public static void Eliminar()
        {
            using(UniversidadContext uniContext = new UniversidadContext())
            {
                int idInput = int.Parse(Console.ReadLine());
                Alumno alu = uniContext.Alumnos.Find(idInput);
                if (alu != null)
                {
                    uniContext.Alumnos.Remove(alu);
                    uniContext.SaveChanges();
                }
            }
        }
    }
}