namespace PuntoDeVenta
{
    partial class Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.Gato2 = new System.Windows.Forms.PictureBox();
            this.Gato1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gato2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gato1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gato2
            // 
            this.Gato2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Gato2.Image = global::PuntoDeVenta.Properties.Resources.Gatito2;
            this.Gato2.Location = new System.Drawing.Point(950, 441);
            this.Gato2.Name = "Gato2";
            this.Gato2.Size = new System.Drawing.Size(300, 220);
            this.Gato2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gato2.TabIndex = 1;
            this.Gato2.TabStop = false;
            // 
            // Gato1
            // 
            this.Gato1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gato1.BackColor = System.Drawing.Color.Transparent;
            this.Gato1.Image = global::PuntoDeVenta.Properties.Resources.Gatito1;
            this.Gato1.Location = new System.Drawing.Point(12, 461);
            this.Gato1.Name = "Gato1";
            this.Gato1.Size = new System.Drawing.Size(300, 200);
            this.Gato1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gato1.TabIndex = 0;
            this.Gato1.TabStop = false;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Gato2);
            this.Controls.Add(this.Gato1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventana";
            this.Text = "CUIDADO CON EL MICHI";
            ((System.ComponentModel.ISupportInitialize)(this.Gato2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gato1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Gato1;
        private System.Windows.Forms.PictureBox Gato2;
    }
}

