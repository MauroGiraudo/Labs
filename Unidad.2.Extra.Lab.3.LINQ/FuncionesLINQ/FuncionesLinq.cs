using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string>
        provincias)
        {
            return from p in provincias
                   where p.StartsWith("S") || p.StartsWith("T")
                   select p;
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            return numeros
            .Where(n => n > 20)
            .Select(n => n);

        }

        public IEnumerable<int>
        ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades,
        string ciudad)
        {
            return ciudades
            .Where(c => c.Nombre.StartsWith(ciudad))
            .Select(c => c.CodigoPostal);
        }

        public IEnumerable<Empleado>
        AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados,
        IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            List<Empleado> finalEmpleados = new List<Empleado>();
            finalEmpleados.AddRange(empleados.ToArray());

            finalEmpleados.AddRange(empleadosParaAgregar.ToArray());
            return from e in finalEmpleados
                   orderby e.Sueldo ascending
                   select e;
        }
    }
}