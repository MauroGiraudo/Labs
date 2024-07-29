using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataRow rwAlumno = dtAlumnos.NewRow();
            DataColumn colNombre = new DataColumn();
            DataColumn colApellido = new DataColumn();
            colApellido.ColumnName = "Apellido";
            colNombre.ColumnName = "Nombre";
            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.Columns.Add(colApellido);
            rwAlumno[colApellido] = "Giraudo";
            rwAlumno[colNombre] = "Mauro F.";
            dtAlumnos.Rows.Add(rwAlumno);
            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2["Apellido"] = "Giraudo";
            rwAlumno2["Nombre"] = "Lucas G.";
            dtAlumnos.Rows.Add(rwAlumno2);
            Console.WriteLine("Listado de Alumnos: ");
            Console.WriteLine();
            foreach (DataRow row in dtAlumnos.Rows)
            {
                Console.WriteLine(row["Apellido"].ToString() + ", " + row["Nombre"].ToString());
            }
            Console.Read();

        }
    }
}
