using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dsUniversidad miUniversidad = new dsUniversidad();
            dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
            dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();
            
            dsUniversidad.dtAlumnosRow rowAlu = dtAlumnos.NewdtAlumnosRow();
            rowAlu["Apellido"] = "Giraudo";
            rowAlu["Nombre"] = "Mauro F.";
            dtAlumnos.AdddtAlumnosRow(rowAlu);

            dsUniversidad.dtCursosRow rowCur = dtCursos.NewdtCursosRow();
            rowCur["Curso"] = "Informática";
            dtCursos.AdddtCursosRow(rowCur);

            dsUniversidad.dtAlumnoCursoDataTable dtAlumnoCurso = new dsUniversidad.dtAlumnoCursoDataTable();
            dsUniversidad.dtAlumnoCursoRow rowAluCur = dtAlumnoCurso.NewdtAlumnoCursoRow();
            dtAlumnoCurso.AdddtAlumnoCursoRow(rowAlu, rowCur);

            dsUniversidad.dtAlumnosRow rowAlu2 = dtAlumnos.NewdtAlumnosRow();
            rowAlu2["Apellido"] = "Giraudo";
            rowAlu2["Nombre"] = "Lucas G.";
            dtAlumnos.AdddtAlumnosRow(rowAlu2);

            dtAlumnoCurso.AdddtAlumnoCursoRow(rowAlu2, rowCur);
        }
    }
}
