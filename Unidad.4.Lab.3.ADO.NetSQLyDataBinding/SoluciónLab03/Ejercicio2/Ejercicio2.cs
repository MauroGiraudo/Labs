using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataColumn colIDAlumno = new DataColumn("IDAlumno", typeof(int));
            colIDAlumno.ReadOnly = true;
            colIDAlumno.AutoIncrement = true;
            colIDAlumno.AutoIncrementSeed = 0;
            colIDAlumno.AutoIncrementStep = 1;
            DataColumn colNombre = new DataColumn("Nombre", typeof(string));
            DataColumn colApellido = new DataColumn("Apellido", typeof(string));
            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.Columns.Add(colApellido);
            dtAlumnos.Columns.Add(colIDAlumno);
            dtAlumnos.PrimaryKey = new DataColumn[] { colIDAlumno };
            DataRow drAlumnos = dtAlumnos.NewRow();
            drAlumnos[colNombre] = "Pepe";
            drAlumnos[colApellido] = "Juarez";
            dtAlumnos.Rows.Add(drAlumnos);
            DataRow drAlumnos2 = dtAlumnos.NewRow();
            drAlumnos2["Nombre"] = "Joaquín";
            drAlumnos2["Apellido"] = "Márquez";
            dtAlumnos.Rows.Add(drAlumnos2);


            DataTable dtCursos = new DataTable();
            DataColumn colIDCurso = new DataColumn("IDCurso", typeof(int));
            colIDCurso.AutoIncrement = true;
            colIDCurso.AutoIncrementSeed = 1;
            colIDCurso.AutoIncrementStep = 1;
            DataColumn colCurso = new DataColumn("Curso", typeof(string));
            dtCursos.Columns.Add(colIDCurso);
            dtCursos.Columns.Add(colCurso);
            dtCursos.PrimaryKey = new DataColumn[] { colIDCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[colCurso] = "Informática";
            dtCursos.Rows.Add(rwCurso);

            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);

            DataTable dtAlumnos_Cursos = new DataTable();
            DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));
            DataColumn col_ac_IDCurso = new DataColumn("IDCurso", typeof(int));
            dtAlumnos_Cursos.Columns.Add(col_ac_IDAlumno);
            dtAlumnos_Cursos.Columns.Add(col_ac_IDCurso);

            dsUniversidad.Tables.Add(dtAlumnos_Cursos);


            DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", colIDAlumno, col_ac_IDAlumno);
            DataRelation relCurso_ac = new DataRelation("Curso_Alumnos", colIDCurso, col_ac_IDCurso);
            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            DataRow rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IDAlumno] = 0;
            rwAlumnosCursos[col_ac_IDCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IDAlumno] = 1;
            rwAlumnosCursos[col_ac_IDCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            Console.Write("Por favor, ingrese el nombre del curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine("Listado de Alumnos del Curso: " + materia);
            DataRow[] row_CursoInf = dtCursos.Select("Curso = '" + materia + "'");
            foreach (DataRow rowCu in row_CursoInf)
            {
                DataRow[] row_AlumnoInf = rowCu.GetChildRows(relCurso_ac);
                foreach (DataRow rowAl in row_AlumnoInf)
                {
                    Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[colApellido].ToString() + ", " + rowAl.GetParentRow(relAlumno_ac)[colNombre].ToString());
                }
            }
            Console.ReadLine();

        }
    }
}