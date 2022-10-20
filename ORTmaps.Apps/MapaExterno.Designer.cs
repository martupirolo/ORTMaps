namespace ORTmaps.Apps
{
    partial class MapaExterno
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
            this.MyMap = new System.Windows.Forms.Integration.ElementHost();
            this.ucMap = new ORTmaps.Apps.UserControl1();
            this.SuspendLayout();
            // 
            // MyMap
            // 
            this.MyMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyMap.Location = new System.Drawing.Point(0, 0);
            this.MyMap.Name = "MyMap";
            this.MyMap.Size = new System.Drawing.Size(800, 450);
            this.MyMap.TabIndex = 0;
            this.MyMap.Text = "elementHost1";
            this.MyMap.Child = this.ucMap;
            // 
            // MapaExterno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyMap);
            this.Name = "MapaExterno";
            this.Text = "MapaExterno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MapaExterno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost MyMap;
        private UserControl1 ucMap;
    }
}