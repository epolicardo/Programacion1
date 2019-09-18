using System;
using System.Windows.Forms;

namespace Parcial_3
{
    public partial class Form1 : Form
    {

        #region Propiedades
        Lista Alumnos = new Lista();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            if (Alumnos.Agregar(txtNombre.Text, txtNota.Text))
            {
                lblListaNombres.Text = Alumnos.MostrarLista();
            }
            else
            {
                MessageBox.Show("e r r o r");
            }


            txtNombre.SelectAll();
            txtNombre.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int Pos = Alumnos.BuscarPosicion(txtNombre.Text);
            if (Pos == -1)
            {
                MessageBox.Show("No se pudo encontrar el alumno" + txtNombre.Text);
            }
            else
            {
                MessageBox.Show("El alumno " + txtNombre.Text + " fue encontrado en la posición " + (Pos + 1).ToString());
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            string Resp = Alumnos.Borrar(txtNombre.Text);
            if (string.IsNullOrEmpty(Resp))
            {
                MessageBox.Show("El alumno " + txtNombre.Text + " ha sido borrado");
            }
            else
            {
                MessageBox.Show("El alumno " + txtNombre.Text + " no ha sido encontrado.");
            }
            lblListaNombres.Text = Alumnos.MostrarLista();
            lblListaNombresOrd.Text = Alumnos.Ordenar();

        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {

            lblListaNombres.Text = Alumnos.MostrarLista();
            lblListaNombresOrd.Text = Alumnos.Ordenar();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            lblListaNombres.Text = Alumnos.MostrarLista();
            lblListaNombresOrd.Text = Alumnos.Ordenar();
        }
    }
}
