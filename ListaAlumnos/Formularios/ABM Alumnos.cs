using ListaAlumnos.Data;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace ListaAlumnos
{
    public partial class ABM_Alumnos : Form
    {

        ListaAlumnos.Repositorios.Lista alumnos = new Repositorios.Lista();
        ListaAlumnos.Repositorios.Lista profesores = new Repositorios.Lista();
        ListaAlumnos.Repositorios.Lista notas = new Repositorios.Lista();

        public ABM_Alumnos()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //using (DataContext db = new DataContext())
            //{
            //    if (txtApellido.Text.Equals("") || txtNombre.Text.Equals("") || txtNombre.Text.Equals(""))
            //    {
            //        MessageBox.Show("No puede guardar un Alumno sin los datos básicos");
            //    }
            //    else
            //    {
            //        Alumno alumno = personaBindingSource.Current as Alumno;
            //        if (alumno != null)
            //        {
            //            if (db.Entry<Alumno>(alumno).State == EntityState.Detached)
            //            {
            //                db.Set<Alumno>().Attach(alumno);
            //            }
            //            if (alumno.Id == 0)
            //            {
            //                db.Entry<Alumno>(alumno).State = EntityState.Added;
            //            }
            //            else
            //            {
            //                db.Entry<Alumno>(alumno).State = EntityState.Modified;
            //                db.SaveChanges();
            //                MessageBox.Show("Alumno guardado correctamente");
            //                dataGridView1.Rows.Add(alumno.persona.DNI, alumno.persona.Nombre, alumno.persona.Apellido);
            //            };
            //        }
                
            
        }


    }
}

