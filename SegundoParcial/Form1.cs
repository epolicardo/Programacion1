using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {

        Timer reloj = new Timer();
        private int direccion;
        private int movimientoH = 100;
        private int movimientoV = 1;
        private int intervalo = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void moverFondo(object sender, EventArgs e)
        {
            if (lblAzul.Top > this.Height)
            {
                lblAzul.Top = 0;
            }
            if (lblVerde.Top > this.Height)
            {
                lblVerde.Top = 0;
            }
            if (lblRojo.Top > this.Height)
            {
                lblRojo.Top = 0;
            }
            if (lblLila.Top > this.Height)
            {
                lblLila.Top = 0;
            }if (lblAmarillo.Top > this.Height)
            {
                lblAmarillo.Top = 0;
              
            }
            lblAzul.Top = lblAzul.Top + movimientoV + 4;
            lblAmarillo.Top = lblAmarillo.Top + movimientoV + 3;
            lblRojo.Top = lblRojo.Top + movimientoV - 2;
            lblLila.Top = lblLila.Top + movimientoV - 1;
            lblVerde.Top = lblVerde.Top + movimientoV - 1;

        }

        public void controlLimites(int posicionH, int posicionV, int maxWhith, int maxHeight)
        {
            if (posicionH < 1)
            {
                //Mover a la derecha
            }
            else
            {
                //mover a la izquierda
            }
            if (posicionV < 1)
            {
                //Mover abajo
            }
            else
            {
                //mover arriba
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void BtnIzquierda_Click(object sender, EventArgs e)
        {
            //lblRana.Left = label1.Left - movimientoH;
        }

        private void BtnDerecha_Click(object sender, EventArgs e)
        {
            //label1.Left = label1.Left + movimientoH;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //direccion = -1;
            //reloj.Interval = intervalo;
            //reloj.Start();
            //reloj.Tick += new EventHandler(moverFondo);
        }
    }
}
