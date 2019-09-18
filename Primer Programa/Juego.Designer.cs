namespace Primer_Programa
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btRespuesta1 = new System.Windows.Forms.Button();
            this.btRespuesta2 = new System.Windows.Forms.Button();
            this.btRespuesta3 = new System.Windows.Forms.Button();
            this.btRespuesta4 = new System.Windows.Forms.Button();
            this.btRetirarse = new System.Windows.Forms.Button();
            this.btComodin1 = new System.Windows.Forms.Button();
            this.btComodin2 = new System.Windows.Forms.Button();
            this.btComodin3 = new System.Windows.Forms.Button();
            this.btComodin4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.lblPremioAcumulado = new System.Windows.Forms.Label();
            this.lblRespuestasCorrectas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.lblResultadoDeRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Clarendon Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(12, 225);
            this.lblPregunta.MaximumSize = new System.Drawing.Size(1081, 181);
            this.lblPregunta.MinimumSize = new System.Drawing.Size(1081, 181);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(1081, 181);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // btRespuesta1
            // 
            this.btRespuesta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRespuesta1.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRespuesta1.Location = new System.Drawing.Point(74, 504);
            this.btRespuesta1.Name = "btRespuesta1";
            this.btRespuesta1.Size = new System.Drawing.Size(479, 69);
            this.btRespuesta1.TabIndex = 1;
            this.btRespuesta1.Text = "Respuesta &1";
            this.btRespuesta1.UseVisualStyleBackColor = false;
            this.btRespuesta1.Click += new System.EventHandler(this.BtRespuesta1_Click);
            // 
            // btRespuesta2
            // 
            this.btRespuesta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRespuesta2.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRespuesta2.Location = new System.Drawing.Point(559, 504);
            this.btRespuesta2.Name = "btRespuesta2";
            this.btRespuesta2.Size = new System.Drawing.Size(479, 69);
            this.btRespuesta2.TabIndex = 2;
            this.btRespuesta2.Text = "Respuesta &2";
            this.btRespuesta2.UseVisualStyleBackColor = false;
            this.btRespuesta2.Click += new System.EventHandler(this.BtRespuesta2_Click);
            // 
            // btRespuesta3
            // 
            this.btRespuesta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRespuesta3.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRespuesta3.Location = new System.Drawing.Point(74, 579);
            this.btRespuesta3.Name = "btRespuesta3";
            this.btRespuesta3.Size = new System.Drawing.Size(479, 69);
            this.btRespuesta3.TabIndex = 3;
            this.btRespuesta3.Text = "Respuesta &3";
            this.btRespuesta3.UseVisualStyleBackColor = false;
            this.btRespuesta3.Click += new System.EventHandler(this.BtRespuesta3_Click);
            // 
            // btRespuesta4
            // 
            this.btRespuesta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btRespuesta4.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRespuesta4.Location = new System.Drawing.Point(559, 579);
            this.btRespuesta4.Name = "btRespuesta4";
            this.btRespuesta4.Size = new System.Drawing.Size(479, 69);
            this.btRespuesta4.TabIndex = 4;
            this.btRespuesta4.Text = "Respuesta &4";
            this.btRespuesta4.UseVisualStyleBackColor = false;
            this.btRespuesta4.Click += new System.EventHandler(this.BtRespuesta4_Click);
            // 
            // btRetirarse
            // 
            this.btRetirarse.BackColor = System.Drawing.Color.Red;
            this.btRetirarse.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetirarse.Location = new System.Drawing.Point(12, 12);
            this.btRetirarse.Name = "btRetirarse";
            this.btRetirarse.Size = new System.Drawing.Size(195, 69);
            this.btRetirarse.TabIndex = 5;
            this.btRetirarse.Text = "Retirarse";
            this.btRetirarse.UseVisualStyleBackColor = false;
            this.btRetirarse.Click += new System.EventHandler(this.btRetirarse_Click);
            // 
            // btComodin1
            // 
            this.btComodin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btComodin1.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComodin1.Location = new System.Drawing.Point(157, 671);
            this.btComodin1.Name = "btComodin1";
            this.btComodin1.Size = new System.Drawing.Size(195, 69);
            this.btComodin1.TabIndex = 6;
            this.btComodin1.Text = "Comodin 1";
            this.btComodin1.UseVisualStyleBackColor = false;
            // 
            // btComodin2
            // 
            this.btComodin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btComodin2.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComodin2.Location = new System.Drawing.Point(358, 671);
            this.btComodin2.Name = "btComodin2";
            this.btComodin2.Size = new System.Drawing.Size(195, 69);
            this.btComodin2.TabIndex = 7;
            this.btComodin2.Text = "Comodin 2";
            this.btComodin2.UseVisualStyleBackColor = false;
            // 
            // btComodin3
            // 
            this.btComodin3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btComodin3.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComodin3.Location = new System.Drawing.Point(559, 671);
            this.btComodin3.Name = "btComodin3";
            this.btComodin3.Size = new System.Drawing.Size(195, 69);
            this.btComodin3.TabIndex = 8;
            this.btComodin3.Text = "Comodin 3";
            this.btComodin3.UseVisualStyleBackColor = false;
            // 
            // btComodin4
            // 
            this.btComodin4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btComodin4.Enabled = false;
            this.btComodin4.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComodin4.Location = new System.Drawing.Point(760, 671);
            this.btComodin4.Name = "btComodin4";
            this.btComodin4.Size = new System.Drawing.Size(195, 69);
            this.btComodin4.TabIndex = 9;
            this.btComodin4.Text = "Comodin 4";
            this.btComodin4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Respuestas Correctas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Premio Acumulado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Preguntas Restantes:";
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(731, 68);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(29, 26);
            this.lblPreguntasRestantes.TabIndex = 15;
            this.lblPreguntasRestantes.Text = "0";
            // 
            // lblPremioAcumulado
            // 
            this.lblPremioAcumulado.AutoSize = true;
            this.lblPremioAcumulado.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremioAcumulado.Location = new System.Drawing.Point(731, 107);
            this.lblPremioAcumulado.Name = "lblPremioAcumulado";
            this.lblPremioAcumulado.Size = new System.Drawing.Size(29, 26);
            this.lblPremioAcumulado.TabIndex = 14;
            this.lblPremioAcumulado.Text = "0";
            // 
            // lblRespuestasCorrectas
            // 
            this.lblRespuestasCorrectas.AutoSize = true;
            this.lblRespuestasCorrectas.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestasCorrectas.Location = new System.Drawing.Point(731, 30);
            this.lblRespuestasCorrectas.Name = "lblRespuestasCorrectas";
            this.lblRespuestasCorrectas.Size = new System.Drawing.Size(29, 26);
            this.lblRespuestasCorrectas.TabIndex = 13;
            this.lblRespuestasCorrectas.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BankGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(701, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "$";
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.Blue;
            this.btIniciar.Font = new System.Drawing.Font("BankGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.ForeColor = System.Drawing.Color.Coral;
            this.btIniciar.Location = new System.Drawing.Point(906, 10);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(195, 69);
            this.btIniciar.TabIndex = 17;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.BtIniciar_Click);
            // 
            // lblResultadoDeRespuesta
            // 
            this.lblResultadoDeRespuesta.Font = new System.Drawing.Font("BankGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDeRespuesta.Location = new System.Drawing.Point(264, 418);
            this.lblResultadoDeRespuesta.Name = "lblResultadoDeRespuesta";
            this.lblResultadoDeRespuesta.Size = new System.Drawing.Size(584, 50);
            this.lblResultadoDeRespuesta.TabIndex = 18;
            this.lblResultadoDeRespuesta.Text = "¡Correcto!";
            this.lblResultadoDeRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultadoDeRespuesta.Visible = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1113, 752);
            this.Controls.Add(this.lblResultadoDeRespuesta);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPreguntasRestantes);
            this.Controls.Add(this.lblPremioAcumulado);
            this.Controls.Add(this.lblRespuestasCorrectas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btComodin4);
            this.Controls.Add(this.btComodin3);
            this.Controls.Add(this.btComodin2);
            this.Controls.Add(this.btComodin1);
            this.Controls.Add(this.btRetirarse);
            this.Controls.Add(this.btRespuesta4);
            this.Controls.Add(this.btRespuesta3);
            this.Controls.Add(this.btRespuesta2);
            this.Controls.Add(this.btRespuesta1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Juego";
            this.Text = "Juego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btRespuesta1;
        private System.Windows.Forms.Button btRespuesta2;
        private System.Windows.Forms.Button btRespuesta3;
        private System.Windows.Forms.Button btRespuesta4;
        private System.Windows.Forms.Button btRetirarse;
        private System.Windows.Forms.Button btComodin1;
        private System.Windows.Forms.Button btComodin2;
        private System.Windows.Forms.Button btComodin3;
        private System.Windows.Forms.Button btComodin4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPreguntasRestantes;
        private System.Windows.Forms.Label lblPremioAcumulado;
        private System.Windows.Forms.Label lblRespuestasCorrectas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Label lblResultadoDeRespuesta;
    }
}