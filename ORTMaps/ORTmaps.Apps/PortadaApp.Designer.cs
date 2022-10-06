namespace ORTmaps.Apps
{
    partial class PortadaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortadaApp));
            this.btnBarras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBarras
            // 
            this.btnBarras.BackColor = System.Drawing.Color.Transparent;
            this.btnBarras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBarras.BackgroundImage")));
            this.btnBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBarras.FlatAppearance.BorderSize = 0;
            this.btnBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarras.Location = new System.Drawing.Point(23, 12);
            this.btnBarras.Name = "btnBarras";
            this.btnBarras.Size = new System.Drawing.Size(75, 55);
            this.btnBarras.TabIndex = 1;
            this.btnBarras.UseVisualStyleBackColor = false;
            this.btnBarras.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ORTmaps.Apps.Properties.Resources.Portada_de_app_ORT_MAPS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 478);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PortadaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btnBarras);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PortadaApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarras;
    }
}

