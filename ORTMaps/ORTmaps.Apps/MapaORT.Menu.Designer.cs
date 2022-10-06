namespace ORTmaps.Apps
{
    partial class MapaORT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaORT));
            this.btn1Piso = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Piso
            // 
            this.btn1Piso.Location = new System.Drawing.Point(81, 123);
            this.btn1Piso.Name = "btn1Piso";
            this.btn1Piso.Size = new System.Drawing.Size(209, 37);
            this.btn1Piso.TabIndex = 0;
            this.btn1Piso.Text = "Planta Baja";
            this.btn1Piso.UseVisualStyleBackColor = true;
            this.btn1Piso.Click += new System.EventHandler(this.Btn1Piso_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "1do Piso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "2er Piso";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(81, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "3er Piso";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MapaORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn1Piso);
            this.DoubleBuffered = true;
            this.Name = "MapaORT";
            this.Text = "MapaORT";
            this.Load += new System.EventHandler(this.MapaORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1Piso;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}