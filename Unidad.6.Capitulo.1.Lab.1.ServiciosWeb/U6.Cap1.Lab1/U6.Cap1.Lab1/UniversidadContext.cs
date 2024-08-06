using System.Data;
using System.Data.SqlClient;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace U6.Cap1.Lab1
{
    public class UniversidadContext : DbContext
    {
        public DbSet<Alumno> Alumno
        {
            get; set;
        }

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
