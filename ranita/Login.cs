using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ranita
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            while (textBox1.Text != "")
            {
                if (rbAmarillo.Checked == true)
                {
                    tmp.Image = rbAmarillo.Image;
                    Form1 form1 = new Form1(tmp);
                    form1.ShowDialog();

                }
                if (rbAzul.Checked == true)
                {
                    tmp.Image = rbAzul.Image;
                    Form1 form1 = new Form1(tmp);
                    form1.ShowDialog();
                }
                if (rbLila.Checked == true)
                {
                    tmp.Image = rbLila.Image;
                    Form1 form1 = new Form1(tmp);
                    form1.ShowDialog();
                }
                if (rbNaranja.Checked == true)
                {
                    tmp.Image = rbNaranja.Image;
                    Form1 form1 = new Form1(tmp);
                    form1.ShowDialog();
                }
                if (rbRojo.Checked == true)
                {
                    tmp.Image = rbRojo.Image;
                    Form1 form1 = new Form1(tmp);
                    form1.ShowDialog();
                }
                if (rbVerde.Checked == true)
                {
                    tmp.Image = rbVerde.Image;
                    Form1 form1 = new Form1(tmp);
                    form1.ShowDialog();
                }
            }

        }

    
    }
}
