using System;
using System.Windows.Forms;

namespace Viborita
{
    public partial class Form1 : Form
    {
        int paso = 20;
        private int Bandera;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int alto = this.Height;
            //while (label1.Top + 30 < alto)
            {
                label1.Top = label1.Top + paso;
                label2.Top = label2.Top + paso;
                if (bandera == 1)
                {

                }
                // aca abajo!
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
                label1.Text = "Rutina Primer Día";
           
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {

            }
        }
    }
}
