using Microsoft.EntityFrameworkCore;

namespace U6_Lab1_WebService
{
    public class UniversidadContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MAUROG;Initial Catalog=Academia;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public UniversidadContext()
        {
            this.Database.EnsureCreated();
        }
    }
}