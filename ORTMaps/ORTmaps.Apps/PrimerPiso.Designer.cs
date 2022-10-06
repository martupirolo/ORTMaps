namespace ORTmaps.Apps
{
    partial class PrimerPiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimerPiso));
            this.btnBarras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBarras
            // 
            this.btnBarras.BackColor = System.Drawing.Color.Transparent;
            this.btnBarras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBarras.BackgroundImage")));
            this.btnBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBarras.FlatAppearance.BorderSize = 0;
            this.btnBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarras.Location = new System.Drawing.Point(12, 12);
            this.btnBarras.Name = "btnBarras";
            this.btnBarras.Size = new System.Drawing.Size(75, 55);
            this.btnBarras.TabIndex = 2;
            this.btnBarras.UseVisualStyleBackColor = false;
            this.btnBarras.Click += new System.EventHandler(this.BtnBarras_Click);
            // 
            // PrimerPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBarras);
            this.Name = "PrimerPiso";
            this.Text = "PrimerPiso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarras;
    }
}