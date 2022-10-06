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
    public partial class TercerPiso : Form
    {
        public TercerPiso()
        {
            InitializeComponent();
        }

        private void BtnBarras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuApp Nuevaventana = new MenuApp();
            Nuevaventana.Show();//el inicio es a la pantalla a la que quiero ir y this representa esta pantalla 
        }
    }
}
