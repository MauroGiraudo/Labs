using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab03
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataRow drAlumnos = dtAlumnos.NewRow();
            DataColumn dtColNombre = new DataColumn("Nombre", typeof(string));
            DataColumn dtColApellido = new DataColumn("Apellido", typeof(string));
            dtAlumnos.Columns.Add(dtColNombre);
            dtAlumnos.Columns.Add(dtColApellido);
            drAlumnos[dtColNombre] = "Pepe";
            drAlumnos[dtColApellido] = "Juarez";
            dtAlumnos.Rows.Add(drAlumnos);
            DataRow drAlumnos2 = dtAlumnos.NewRow();
            drAlumnos2["Nombre"] = "Joaquín";
            drAlumnos2["Apellido"] = "Márquez";
            dtAlumnos.Rows.Add(drAlumnos2);

            Console.WriteLine("Listado de Alumnos");
            foreach (DataRow dr in dtAlumnos.Rows)
            {
                Console.WriteLine(dr[dtColApellido].ToString() + ", " + dr[dtColNombre].ToString());
            }
            Console.ReadLine();
        }
    }
}
