using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloInfinito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lista listaProductos = new Lista();
            string[] Tabla = listaProductos.CargarProducto(textBox1.Text);
            for (int i = 0; i < Tabla.Length; i++)
            {
                label1.Text = label1.Text + Tabla[i] + "\n\r";

            }
        }
    }
}

