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
            DataColumn colNombre = new DataColumn();
            DataColumn colApellido = new DataColumn();
            DataColumn colIdAlu = new DataColumn("ID", typeof(int)); //El nombre y tipo de la columna pueden asignarse de esta manera
            colApellido.ColumnName = "Apellido"; // o de esta otra manera...
            colNombre.ColumnName = "Nombre";
            colIdAlu.ReadOnly = true; // Sólo lectura
            colIdAlu.AutoIncrement = true; //ID auto-incrementable
            colIdAlu.AutoIncrementSeed = 0; //Primer nro = 0
            colIdAlu.AutoIncrementStep = 1; //Incremento de 1 en 1
            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.Columns.Add(colApellido);
            dtAlumnos.Columns.Add(colIdAlu);
            dtAlumnos.PrimaryKey = new DataColumn[] { colIdAlu };
            DataRow rwAlumno = dtAlumnos.NewRow();
            rwAlumno[colApellido] = "Giraudo";
            rwAlumno[colNombre] = "Mauro F.";
            dtAlumnos.Rows.Add(rwAlumno);
            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2["Apellido"] = "Giraudo";
            rwAlumno2["Nombre"] = "Lucas G.";
            dtAlumnos.Rows.Add(rwAlumno2);

            DataTable dtCursos = new DataTable();
            DataColumn colIdCur = new DataColumn("ID", typeof(int));
            colIdCur.ReadOnly = true;
            colIdCur.AutoIncrement = true;
            colIdCur.AutoIncrementSeed = 1;
            colIdCur.AutoIncrementStep = 1;
            DataColumn colCurso = new DataColumn("Curso", typeof(string));
            dtCursos.Columns.Add(colIdCur);
            dtCursos.Columns.Add(colCurso);
            dtCursos.PrimaryKey = new DataColumn[] { colIdCur };
            DataRow rwCurso = dtCursos.NewRow();
            rwCurso["Curso"] = "Informática";
            dtCursos.Rows.Add(rwCurso);
            DataRow rwCurso2 = dtCursos.NewRow();
            rwCurso2[colCurso] = "Matemática";
            dtCursos.Rows.Add(rwCurso2);

            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);

            DataTable dtAlumnoCurso = new DataTable();
            DataColumn colAluCur_IdAlu = new DataColumn("IdAlumno", typeof(int));
            DataColumn colAluCur_IdCur = new DataColumn("IdCurso", typeof(int));
            dtAlumnoCurso.Columns.Add(colAluCur_IdAlu);
            dtAlumnoCurso.Columns.Add(colAluCur_IdCur);

            dsUniversidad.Tables.Add(dtAlumnoCurso);

            DataRelation drAlumnos_AlumnoCurso = new DataRelation("Alumno_Cursos", colIdAlu, colAluCur_IdAlu);
            DataRelation drCursos_AlumnoCurso = new DataRelation("Curso_Alumnos", colIdCur, colAluCur_IdCur);
            dsUniversidad.Relations.Add(drAlumnos_AlumnoCurso);
            dsUniversidad.Relations.Add(drCursos_AlumnoCurso);

            DataRow rwAluCur = dtAlumnoCurso.NewRow();
            rwAluCur["IdAlumno"] = 0;
            rwAluCur["IdCurso"] = 2;
            dtAlumnoCurso.Rows.Add(rwAluCur);
            DataRow rwAluCur2 = dtAlumnoCurso.NewRow();
            rwAluCur2[colAluCur_IdAlu] = 1;
            rwAluCur2[colAluCur_IdCur] = 1;
            dtAlumnoCurso.Rows.Add(rwAluCur2);

            Console.WriteLine("Por favor, ingrese el nombre del curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Listado de Alumnos del Curso " + materia);
            DataRow[] rowCursos = dtCursos.Select("Curso = '" + materia + "'");
            foreach(DataRow rowCur in rowCursos)
            {
                DataRow[] rowAlumnos = rowCur.GetChildRows(drCursos_AlumnoCurso);
                foreach(DataRow rowAlu in rowAlumnos)
                {
                    Console.WriteLine(rowAlu.GetParentRow(drAlumnos_AlumnoCurso)[colApellido].ToString() + ", " + rowAlu.GetParentRow(drAlumnos_AlumnoCurso)[colNombre].ToString());
                }
            }
            Console.Read();
        }
    }
}
