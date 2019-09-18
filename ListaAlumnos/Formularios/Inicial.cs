using ListaAlumnos.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ABMAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Calificaciones abmCalificaciones = new ABM_Calificaciones();
            abmCalificaciones.ShowDialog();
        }
    }
}
