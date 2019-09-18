namespace ListaAlumnos.Data
{
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DataContext : DbContext
    {
        
        public DataContext() : base("name=conexion") { }

        public DbSet<Alumno> alumnos { get; set; }
        public DbSet<Persona> personas { get; set; }

        
    }
}
