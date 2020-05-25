namespace Texto
{
    partial class form2
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
            this.btninicio = new System.Windows.Forms.Button();
            this.txtcopia = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(86, 115);
            this.btninicio.Margin = new System.Windows.Forms.Padding(4);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(136, 28);
            this.btninicio.TabIndex = 6;
            this.btninicio.Text = "Guardar y salir";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // txtcopia
            // 
            this.txtcopia.Location = new System.Drawing.Point(21, 13);
            this.txtcopia.Margin = new System.Windows.Forms.Padding(4);
            this.txtcopia.Multiline = true;
            this.txtcopia.Name = "txtcopia";
            this.txtcopia.Size = new System.Drawing.Size(285, 76);
            this.txtcopia.TabIndex = 7;
            this.txtcopia.TextChanged += new System.EventHandler(this.txtcopia_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 213);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 8;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 449);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcopia);
            this.Controls.Add(this.btninicio);
            this.Name = "form2";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.TextBox txtcopia;
        public System.Windows.Forms.TextBox textBox1;
    }
}