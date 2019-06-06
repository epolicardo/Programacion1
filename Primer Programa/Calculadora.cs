using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Programa
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Bt0_Click(object sender, EventArgs e)
        {
            CargarVisor("0");
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            CargarVisor("1");
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            CargarVisor("2");
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            CargarVisor("3");
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            CargarVisor("4");
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            CargarVisor("5");
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            CargarVisor("6");
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            CargarVisor("7");
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            CargarVisor("8");
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            CargarVisor("9");
        }

        private void BtComa_Click(object sender, EventArgs e)
        {
            CargarVisor(",");
        }

        private void BtSuma_Click(object sender, EventArgs e)
        {

        }

        private void BtResta_Click(object sender, EventArgs e)
        {

        }

        private void BtMultiplicacion_Click(object sender, EventArgs e)
        {

        }

        private void BtDivision_Click(object sender, EventArgs e)
        {

        }

        private void BtIgual_Click(object sender, EventArgs e)
        {

        }


        private void CargarVisor(string valor)
        {
            if (txtVisor.Text == "\r\n0")

            {
                txtVisor.Text = valor;
            }
            else
            {
                txtVisor.Text = txtVisor.Text + valor;
            }
        }

        private void BtC_Click(object sender, EventArgs e)
        {
            //Borra la operacion

        }

        private void BtCE_Click(object sender, EventArgs e)
        {
            //Borra solo el ingreso actual
            txtVisor.Text = "";
        }
    }
}
