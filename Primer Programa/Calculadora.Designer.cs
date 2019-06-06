namespace Primer_Programa
{
    partial class Calculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btOff = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btMultiplicacion = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btMasMenos = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btComa = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVisor.Size = new System.Drawing.Size(318, 73);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.Text = "\r\n0";
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btOff
            // 
            this.btOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOff.Location = new System.Drawing.Point(12, 91);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(75, 65);
            this.btOff.TabIndex = 1;
            this.btOff.Text = "OFF";
            this.btOff.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(12, 159);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 65);
            this.bt7.TabIndex = 2;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.Bt7_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(12, 227);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 65);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.Bt4_Click);
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(93, 91);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(75, 65);
            this.btCE.TabIndex = 5;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.BtCE_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(93, 159);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 65);
            this.bt8.TabIndex = 6;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.Bt8_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(93, 227);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 65);
            this.bt5.TabIndex = 7;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.Bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(174, 227);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 65);
            this.bt6.TabIndex = 10;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.Bt6_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(174, 159);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 65);
            this.bt9.TabIndex = 9;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.Bt9_Click);
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(174, 91);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(75, 65);
            this.btC.TabIndex = 8;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.BtC_Click);
            // 
            // btResta
            // 
            this.btResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResta.Location = new System.Drawing.Point(255, 227);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(75, 65);
            this.btResta.TabIndex = 13;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.BtResta_Click);
            // 
            // btMultiplicacion
            // 
            this.btMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacion.Location = new System.Drawing.Point(255, 159);
            this.btMultiplicacion.Name = "btMultiplicacion";
            this.btMultiplicacion.Size = new System.Drawing.Size(75, 65);
            this.btMultiplicacion.TabIndex = 12;
            this.btMultiplicacion.Text = "X";
            this.btMultiplicacion.UseVisualStyleBackColor = true;
            this.btMultiplicacion.Click += new System.EventHandler(this.BtMultiplicacion_Click);
            // 
            // btDivision
            // 
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.Location = new System.Drawing.Point(255, 91);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(75, 65);
            this.btDivision.TabIndex = 11;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.BtDivision_Click);
            // 
            // btSuma
            // 
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuma.Location = new System.Drawing.Point(255, 295);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 65);
            this.btSuma.TabIndex = 17;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.BtSuma_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(174, 295);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 65);
            this.bt3.TabIndex = 16;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.Bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(93, 295);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 65);
            this.bt2.TabIndex = 15;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(12, 295);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 65);
            this.bt1.TabIndex = 14;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // btMasMenos
            // 
            this.btMasMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasMenos.Location = new System.Drawing.Point(12, 363);
            this.btMasMenos.Name = "btMasMenos";
            this.btMasMenos.Size = new System.Drawing.Size(75, 65);
            this.btMasMenos.TabIndex = 14;
            this.btMasMenos.Text = "+ / -";
            this.btMasMenos.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(93, 363);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 65);
            this.bt0.TabIndex = 15;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.Bt0_Click);
            // 
            // btComa
            // 
            this.btComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComa.Location = new System.Drawing.Point(174, 363);
            this.btComa.Name = "btComa";
            this.btComa.Size = new System.Drawing.Size(75, 65);
            this.btComa.TabIndex = 16;
            this.btComa.Text = ",";
            this.btComa.UseVisualStyleBackColor = true;
            this.btComa.Click += new System.EventHandler(this.BtComa_Click);
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(255, 363);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 65);
            this.btIgual.TabIndex = 17;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.BtIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 435);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.btComa);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btMasMenos);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btMultiplicacion);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btOff);
            this.Controls.Add(this.txtVisor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 474);
            this.MinimumSize = new System.Drawing.Size(357, 474);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btOff;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btMultiplicacion;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btMasMenos;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btComa;
        private System.Windows.Forms.Button btIgual;
    }
}

