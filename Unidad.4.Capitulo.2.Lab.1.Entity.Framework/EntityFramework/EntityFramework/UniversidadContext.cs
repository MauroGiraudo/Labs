using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class UniversidadContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MAUROG;Initial Catalog=Academia;Integrated Security=true;Trusted_Connection=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
        public UniversidadContext()
        {
            this.Database.EnsureCreated();
        }
    }
}
