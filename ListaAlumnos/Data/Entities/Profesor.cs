using System.Collections.Generic;

namespace ListaAlumnos.Data.Entities
{
    class Profesor
    {
        public int Id { get; set; }
        public string materia { get; set; }
        public List<Alumno> alumnos{ get; set; }
    }
}
