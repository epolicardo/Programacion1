namespace Primer_Programa
{
    using Microsoft.EntityFrameworkCore;
    using Primer_Programa.Data.Entities;

    public class DataContext : DbContext
    {

        
            public DbSet<Preguntas> Preguntas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=juegos;Trusted_Connection =True;");
        }
    }
}