namespace Ejercicio2_AbnerValeriano
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
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTexBox = new System.Windows.Forms.TextBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.EstudianteslistBox = new System.Windows.Forms.ListBox();
            this.Edad1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // NombreTexBox
            // 
            this.NombreTexBox.Location = new System.Drawing.Point(155, 51);
            this.NombreTexBox.Name = "NombreTexBox";
            this.NombreTexBox.Size = new System.Drawing.Size(100, 22);
            this.NombreTexBox.TabIndex = 2;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(290, 60);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(150, 41);
            this.Agregarbutton.TabIndex = 4;
            this.Agregarbutton.Text = "Agregar estudiantes";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // EstudianteslistBox
            // 
            this.EstudianteslistBox.FormattingEnabled = true;
            this.EstudianteslistBox.ItemHeight = 16;
            this.EstudianteslistBox.Location = new System.Drawing.Point(78, 148);
            this.EstudianteslistBox.Name = "EstudianteslistBox";
            this.EstudianteslistBox.Size = new System.Drawing.Size(319, 84);
            this.EstudianteslistBox.TabIndex = 5;
            // 
            // Edad1TextBox
            // 
            this.Edad1TextBox.Location = new System.Drawing.Point(155, 90);
            this.Edad1TextBox.Name = "Edad1TextBox";
            this.Edad1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Edad1TextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.Edad1TextBox);
            this.Controls.Add(this.EstudianteslistBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.NombreTexBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTexBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ListBox EstudianteslistBox;
        private System.Windows.Forms.TextBox Edad1TextBox;
    }
}

