using System;
using System.Collections.Generic;
using Xunit;
using FuncionesLINQ;

namespace FuncionesLinqTest
{
    public class FuncionesLinqTest
    {
        [Fact]
        public void ObtenerProvinciasQueEmpiezanConDetermindasLetrasTest()
        {
            // Arrange
            var funcionesLinq = new FuncionesLinq();
            IEnumerable<string> provincias = new List<string>
            {
                "Buenos Aires",
                "Capital Federal",
                "Catamarca",
                "Chaco",
                "Chubut",
                "C�rdoba",
                "Corrientes",
                "Entre R�os",
                "Formosa",
                "Jujuy",
                "La Pampa",
                "La Rioja",
                "Mendoza",
                "Misiones",

                "Neuqu�n",
                "R�o Negro",
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago del Estero",
                "Tierra del Fuego, Ant�rtida e Isla del Atl�ntico Sur",
                "Tucum�n"
            };

            // Act
            IEnumerable<string> provinciasSeleccionadas =
            funcionesLinq.ObtenerProvinciasQueEmpiezanConDeterminadasLetras(provincias);

            // Assert
            Assert.Equal(expected: new List<String>
            {
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago del Estero",
                "Tierra del Fuego, Ant�rtida e Isla del Atl�ntico Sur",
                "Tucum�n",
            }, actual: provinciasSeleccionadas);
        }

        [Fact]
        public void ObtenerNumerosMayoresA20Test()
        {
            // Arrange
            var funcionesLinq = new FuncionesLinq();
            IEnumerable<int> numeros = new List<int> { 14, 2, 5, 21, 32, 25, 20 };

            // Act
            IEnumerable<int> numerosMayoresA20 = funcionesLinq.ObtenerNumerosMayoresA20(numeros);

            // Assert
            Assert.Equal(expected: new List<int> { 21, 32, 25 }, actual: numerosMayoresA20);
            Assert.DoesNotContain(20, numerosMayoresA20);
        }

        [Fact]
        public void ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest()
        {
            // Arrange
            var funcionesLinq = new FuncionesLinq();
            IEnumerable<Ciudad> ciudades = new List<Ciudad>
            {
                new Ciudad() { Nombre = "Rosario", CodigoPostal = 2000 },
                new Ciudad()
                {
                    Nombre = "C�rdoba",
                    CodigoPostal = 5000
                },
                new Ciudad()
                {
                    Nombre = "Santa Fe",
                    CodigoPostal = 3000
                },
                new Ciudad() {
                    Nombre = "San Miguel De Tucuman",
                    CodigoPostal = 4000
                },
                new Ciudad()
                {
                    Nombre = "Venado Tuerto",
                    CodigoPostal = 2600
                },
                new Ciudad()
                {

                    Nombre = "Firmat",
                    CodigoPostal = 2630
                },
                new Ciudad()
                {
                    Nombre = "Formosa",
                    CodigoPostal = 3600
                },
                new Ciudad()
                {
                    Nombre = "Aserradero Arroyo",
                    CodigoPostal = 9420
                },
                new Ciudad()
                {
                    Nombre = "Obera",
                    CodigoPostal = 3360
                },
                new Ciudad()
                {
                    Nombre = "Mor�n",
                    CodigoPostal = 1708
                }
            };

            // Act
            IEnumerable<int> codPostalesDeCiudadesSeleccionadas =
            funcionesLinq.ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(ciudades, "San");

            // Assert
            Assert.Equal(expected: new List<int> { 3000, 4000 }, actual: codPostalesDeCiudadesSeleccionadas);
        }

        [Fact]
        public void AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest()
        {
            // Arrange

            var funcionesLinq = new FuncionesLinq();

            var empleados = new List<Empleado> { new Empleado() { Id = 1, Nombre = "Gabriela F", Sueldo = 1600.0}, new
Empleado() { Id = 2, Nombre = "Federico R", Sueldo = 1200.0} };
            var empleadosParaAgregar = new List<Empleado> { new Empleado() { Id = 3, Nombre = "Juan D", Sueldo =
1500.0 }, new Empleado() { Id = 4, Nombre = "Jesus T", Sueldo = 1610.5} };

            // Act
            IEnumerable<Empleado> empleadosOrdenadosPorSueldo =
            funcionesLinq.AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(empleados, empleadosParaAgregar, "ASC");

            // Assert
            Assert.Equal(expected: new List<Empleado> { empleados[1], empleadosParaAgregar[0], empleados[0],
empleadosParaAgregar[1] }, actual: empleadosOrdenadosPorSueldo);
        }
    }
}