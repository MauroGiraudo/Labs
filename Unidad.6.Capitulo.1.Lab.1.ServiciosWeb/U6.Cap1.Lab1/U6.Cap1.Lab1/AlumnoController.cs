using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore;

namespace U6.Cap1.Lab1
{
    public class AlumnoController : ControllerBase
    {
        [HttpGet("")]

        public async Task<List<Alumno>> FindAll()
        {

        };

        [HttpGet("/api/alumnos/{id}")]
        public async Task<Alumno> FindOne(int id)
        {
            return await 
        }
    }
}
