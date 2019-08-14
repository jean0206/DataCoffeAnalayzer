namespace WindowsFormsApp1
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Mapa = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mapa
            // 
            this.Mapa.Location = new System.Drawing.Point(205, 356);
            this.Mapa.Name = "Mapa";
            this.Mapa.Size = new System.Drawing.Size(121, 35);
            this.Mapa.TabIndex = 1;
            this.Mapa.Text = "Mapa";
            this.Mapa.UseVisualStyleBackColor = true;
            this.Mapa.Click += new System.EventHandler(this.Mapa_Click);
            // 
            // Datos
            // 
            this.Datos.FlatAppearance.BorderSize = 6;
            this.Datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Datos.Location = new System.Drawing.Point(378, 356);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(121, 35);
            this.Datos.TabIndex = 2;
            this.Datos.Text = "Datos";
            this.Datos.UseVisualStyleBackColor = true;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 448);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Mapa;
        private System.Windows.Forms.Button Datos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

