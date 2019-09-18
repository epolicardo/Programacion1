namespace ListaAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expoCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepciónDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aBMAlumnosToolStripMenuItem,
            this.asistenciasToolStripMenuItem,
            this.calificacionesToolStripMenuItem,
            this.expoCarrerasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // aBMAlumnosToolStripMenuItem
            // 
            this.aBMAlumnosToolStripMenuItem.Name = "aBMAlumnosToolStripMenuItem";
            this.aBMAlumnosToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.aBMAlumnosToolStripMenuItem.Text = "ABM Alumnos";
            this.aBMAlumnosToolStripMenuItem.Click += new System.EventHandler(this.ABMAlumnosToolStripMenuItem_Click);
            // 
            // asistenciasToolStripMenuItem
            // 
            this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            this.asistenciasToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.asistenciasToolStripMenuItem.Text = "Asistencias";
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.CalificacionesToolStripMenuItem_Click);
            // 
            // expoCarrerasToolStripMenuItem
            // 
            this.expoCarrerasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepciónDeAlumnosToolStripMenuItem,
            this.encuestaToolStripMenuItem});
            this.expoCarrerasToolStripMenuItem.Name = "expoCarrerasToolStripMenuItem";
            this.expoCarrerasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.expoCarrerasToolStripMenuItem.Text = "ExpoCarreras";
            // 
            // recepciónDeAlumnosToolStripMenuItem
            // 
            this.recepciónDeAlumnosToolStripMenuItem.Name = "recepciónDeAlumnosToolStripMenuItem";
            this.recepciónDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recepciónDeAlumnosToolStripMenuItem.Text = "Recepción de alumnos";
            // 
            // encuestaToolStripMenuItem
            // 
            this.encuestaToolStripMenuItem.Name = "encuestaToolStripMenuItem";
            this.encuestaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.encuestaToolStripMenuItem.Text = "Encuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expoCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepciónDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuestaToolStripMenuItem;
    }
}

