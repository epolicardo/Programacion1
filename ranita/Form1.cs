using System;
using System.Windows.Forms;

namespace ranita
{
    public partial class Form1 : Form
    {
        Timer reloj = new Timer();
        private int movimientoH = 10;
        private int movimientoV = 1;
        private int intervalo = 10;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Left":
                    lblRana.Left = lblRana.Left - 50;
                    break;
                case "Right":
                    lblRana.Left = lblRana.Left + 50;
                    break;
                case "Up":
                    lblRana.Top = lblRana.Top - 50;
                    break;
                case "Down":
                    lblRana.Top = lblRana.Top + 50;
                    break;
            }
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            reloj.Interval = intervalo;
            reloj.Start();
            reloj.Tick += new EventHandler(moverAutos);
        }

        private void moverAutos(object sender, EventArgs e)
        {
            if (lblAzul.Left > this.Width)
            {
                lblAzul.Left = 0;
            }
            if (lblVerde.Left > this.Width)
            {
                lblVerde.Left = 0;
            }
            if (lblRojo.Left > this.Width)
            {
                lblRojo.Left = 0;
            }
            if (lblLila.Left > this.Width)
            {
                lblLila.Left = 0;
            }
            if (lblAmarillo.Left > this.Width)
            {
                lblAmarillo.Left = 0;
            }
            if (lblFucsia.Left > this.Width)
            {
                lblFucsia.Left = 0;
            }
            lblAzul.Left = lblAzul.Left + movimientoH + 4;
            lblAmarillo.Left = lblAmarillo.Left + movimientoH + 3;
            lblRojo.Left = lblRojo.Left + movimientoH - 2;
            lblLila.Left = lblLila.Left + movimientoH - 1;
            lblVerde.Left = lblVerde.Left + movimientoH - 1;
            lblFucsia.Left = lblFucsia.Left + movimientoH;
        }
    }
}
