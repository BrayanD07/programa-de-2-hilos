namespace Texto
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
            this.btninicio = new System.Windows.Forms.Button();
            this.txtoriginal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(103, 115);
            this.btninicio.Margin = new System.Windows.Forms.Padding(4);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(100, 28);
            this.btninicio.TabIndex = 4;
            this.btninicio.Text = "insertar";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // txtoriginal
            // 
            this.txtoriginal.Location = new System.Drawing.Point(13, 13);
            this.txtoriginal.Margin = new System.Windows.Forms.Padding(4);
            this.txtoriginal.Multiline = true;
            this.txtoriginal.Name = "txtoriginal";
            this.txtoriginal.Size = new System.Drawing.Size(285, 76);
            this.txtoriginal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 156);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.txtoriginal);
            this.Name = "Form1";
            this.Text = "insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.TextBox txtoriginal;
    }
}

