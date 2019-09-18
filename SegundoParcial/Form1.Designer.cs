namespace SegundoParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.lblAmarillo = new System.Windows.Forms.Label();
            this.lblLila = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLila);
            this.panel1.Controls.Add(this.lblAmarillo);
            this.panel1.Controls.Add(this.lblVerde);
            this.panel1.Controls.Add(this.lblAzul);
            this.panel1.Controls.Add(this.lblRojo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 658);
            this.panel1.TabIndex = 2;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(520, 676);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(126, 77);
            this.btnIzquierda.TabIndex = 3;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.BtnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(652, 676);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(126, 77);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.BtnDerecha_Click);
            // 
            // lblRojo
            // 
            this.lblRojo.BackColor = System.Drawing.Color.Red;
            this.lblRojo.Location = new System.Drawing.Point(186, 47);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(155, 28);
            this.lblRojo.TabIndex = 1;
            // 
            // lblAzul
            // 
            this.lblAzul.BackColor = System.Drawing.Color.Blue;
            this.lblAzul.Location = new System.Drawing.Point(347, 47);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(155, 28);
            this.lblAzul.TabIndex = 6;
            // 
            // lblAmarillo
            // 
            this.lblAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.lblAmarillo.Location = new System.Drawing.Point(669, 47);
            this.lblAmarillo.Name = "lblAmarillo";
            this.lblAmarillo.Size = new System.Drawing.Size(155, 28);
            this.lblAmarillo.TabIndex = 8;
            // 
            // lblLila
            // 
            this.lblLila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLila.Location = new System.Drawing.Point(830, 47);
            this.lblLila.Name = "lblLila";
            this.lblLila.Size = new System.Drawing.Size(155, 28);
            this.lblLila.TabIndex = 9;
            // 
            // lblVerde
            // 
            this.lblVerde.BackColor = System.Drawing.Color.Lime;
            this.lblVerde.Location = new System.Drawing.Point(508, 47);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(155, 28);
            this.lblVerde.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(508, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 765);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Label lblLila;
        private System.Windows.Forms.Label lblAmarillo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label label2;
    }
}

