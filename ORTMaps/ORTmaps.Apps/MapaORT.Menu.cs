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
    public partial class MapaORT : Form
    {
        public MapaORT()
        {
            InitializeComponent();
        }

        private void MapaORT_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            TercerPiso Nuevaventana = new TercerPiso();
            Nuevaventana.Show();//el inicio es a la pantalla a la que quiero ir y this representa esta pantalla 
        }

        private void Btn1Piso_Click(object sender, EventArgs e)
        {

            this.Hide();
            btnPBclean Nuevaventana = new btnPBclean();
            Nuevaventana.Show();//el inicio es a la pantalla a la que quiero ir y this representa esta pantalla 
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            PrimerPiso Nuevaventana = new PrimerPiso();
            Nuevaventana.Show();//el inicio es a la pantalla a la que quiero ir y this representa esta pantalla 
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            SegundoPiso Nuevaventana = new SegundoPiso();
            Nuevaventana.Show();//el inicio es a la pantalla a la que quiero ir y this representa esta pantalla 
        }
    }
}
