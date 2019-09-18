using System.ComponentModel.DataAnnotations;

namespace ListaAlumnos
{
    public class Alumno
    {
        #region PROPIEDADES

        [Key]
        public int Id { get; set; }
        public string NroMatricula { get; set; }
        public string[] Notas { get; set; }
        public Persona Persona { get; set; }

        #endregion

        #region CONSTRUCTORES
        public Alumno()
        {

        }
        #endregion

        #region METODOS

        public void AgregarAlumno()
        {
            Lista<Alumno>

        }

        #endregion

    }
}
