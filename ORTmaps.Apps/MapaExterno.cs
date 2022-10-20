using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Maps.MapControl.WPF;

namespace ORTmaps.Apps
{
    public partial class MapaExterno : Form
    {
        public MapaExterno()
        {
            InitializeComponent();
            MyMap.Focus();
            ucMap.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("O6ITh9xG2Ph0Ql5AxEjm~jyZmdiaw-pCb1Bu3l1DH1A~ApG4jNDvx5sE1dn1pat3isq-_tkPiesgMgBlaDlptTID_UUtJvTvLb0I8GAOIyBW");
        }

        private void MapaExterno_Load(object sender, EventArgs e)
        {

        }

        private void MyMap_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
