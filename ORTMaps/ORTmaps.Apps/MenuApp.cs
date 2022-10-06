using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORTmaps.Apps
{
    public partial class MenuApp : Form
    {
        public MenuApp()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuApp_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapaORT Nuevaventana = new MapaORT();
            Nuevaventana.Show();//el inicio es a la pantalla a la que quiero ir y this representa esta pantalla 
        }
    }
}
