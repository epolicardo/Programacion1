using System;
using System.Windows.Forms;

namespace ranita
{
    public partial class Form1 : Form
    {
        Timer reloj = new Timer();
        Timer relojTiempo = new Timer();
        private int movimientoH = 10;
        private int intervalo = 50;
        private int segundosRestantes = 10;
        

        

        public Form1(Label autoSeleccionado)
        {
            InitializeComponent();
            lblRana.Image = autoSeleccionado.Image;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode.ToString())
            {
                case "Left":
                    if (lblRana.Left >= 50)
                    {
                        lblRana.Left = lblRana.Left - 50;
                    }
                    break;
                case "Right":
                    if (lblRana.Left <= this.Size.Width - lblRana.Size.Width - 50)
                    {
                        lblRana.Left = lblRana.Left + 50;
                    }
                    break;
                case "Up":

                    lblRana.Top = lblRana.Top - 50;
                    if (lblRana.Top <= 50)
                    {
                        //  reloj.Stop();
                        // relojTiempo.Stop(); 
                        movimientoH = movimientoH + 5;
                        lblPuntos.Text = Convert.ToString(Convert.ToInt32(lblPuntos.Text) + segundosRestantes);
                        segundosRestantes = 60;
                        lblNivel.Text = Convert.ToString(Convert.ToInt32(lblNivel.Text) + 1);
                        lblRana.Top = 700;
                    }
                    break;
                case "Down":
                    if (lblRana.Top >= 700)
                    {
                    }
                    else
                    {
                        lblRana.Top = lblRana.Top + 50;
                    }
                    break;
            }
        }

        /// <summary>
        /// Cuando inicia la aplicacion inicia el juego, modificarlo para que el usuario elija cuando iniciar
        /// </summary>

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
            relojTiempo.Interval = 1000;
            relojTiempo.Tick += new EventHandler(tiempoNivel);
            relojTiempo.Start();
            reloj.Interval = intervalo;
            reloj.Start();

            reloj.Tick += new EventHandler(moverAutos);
            reloj.Tick += new EventHandler(controlarChoques);
        }
        
        /// <summary>
        /// Controla el tiempo del nivel
        /// </summary>

        private void tiempoNivel(object sender, EventArgs e)
        {
            segundosRestantes = segundosRestantes - 1;
            lblTiempo.Text = segundosRestantes.ToString();
            if (segundosRestantes < 1)
            {
                reloj.Stop();
                relojTiempo.Stop();
                MessageBox.Show("Termino el juego");
                btnReinicio.Visible = true;
            }
        }

        /// <summary>
        /// Metodo que realiza el control de movimiento de los Vehiculos.
        /// Controla los limites derecho e izquierdo, y asigna las distintas velocidades para cada vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void controlarChoques(object sender, EventArgs e)
        {
            if (lblRana.Bounds.IntersectsWith(lblAuto1.Bounds) )
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto2.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto3.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto4.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto5.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto6.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto7.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto8.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto9.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto10.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto11.Bounds))
            {
                perdiste();
            }
            if (lblRana.Bounds.IntersectsWith(lblAuto12.Bounds))
            {
                perdiste();
            }
        }


        private void perdiste()
        {
            lblRana.Top = 700;
            lblPuntos.Text = "0";
            lblNivel.Text = "0";
            movimientoH = 10;
        }

        private void moverAutos(object sender, EventArgs e)
        {
            if (lblAuto5.Left > this.Width)
            {
                lblAuto5.Left = 0;
            }
            if (lblAuto7.Left > this.Width)
            {
                lblAuto7.Left = 0;
            }
            if (lblAuto3.Left > this.Width)
            {
                lblAuto3.Left = 0;
            }
            if (lblAuto11.Left > this.Width)
            {
                lblAuto11.Left = 0;
            }
            if (lblAuto9.Left > this.Width)
            {
                lblAuto9.Left = 0;
            }
            if (lblAuto1.Left > this.Width)
            {
                lblAuto1.Left = 0;
            }
            if (lblAuto12.Left < 0)
            {
                lblAuto12.Left = this.Width;
            }
            if (lblAuto10.Left < 0)
            {
                lblAuto10.Left = this.Width;
            }
            if (lblAuto8.Left < 0)
            {
                lblAuto8.Left = this.Width;
            }
            if (lblAuto6.Left < 0)
            {
                lblAuto6.Left = this.Width;
            }
            if (lblAuto4.Left < 0)
            {
                lblAuto4.Left = this.Width;
            }
            if (lblAuto2.Left < 0)
            {
                lblAuto2.Left = this.Width;
            }

            lblAuto5.Left = lblAuto5.Left + movimientoH + 2;
            lblAuto9.Left = lblAuto9.Left + movimientoH + 1;
            lblAuto3.Left = lblAuto3.Left + movimientoH + 3;
            lblAuto11.Left = lblAuto11.Left + movimientoH - 1;
            lblAuto7.Left = lblAuto7.Left + movimientoH + 1;
            lblAuto1.Left = lblAuto1.Left + movimientoH - 3;
            lblAuto12.Left = lblAuto12.Left - movimientoH - 4;
            lblAuto10.Left = lblAuto10.Left - movimientoH + 3;
            lblAuto8.Left = lblAuto8.Left - movimientoH - 2;
            lblAuto6.Left = lblAuto6.Left - movimientoH + 2;
            lblAuto4.Left = lblAuto4.Left - movimientoH - 1;
            lblAuto2.Left = lblAuto2.Left - movimientoH + 4;

        }

        private void BtnReinicio_Click(object sender, EventArgs e)
        {
            segundosRestantes = 60;
            reloj.Start();
            relojTiempo.Start();
            lblPuntos.Text = "0";
            lblNivel.Text = "0";
            intervalo = 10;
            lblRana.Top = 700;
            btnReinicio.Visible = false;
        }
    }
}
