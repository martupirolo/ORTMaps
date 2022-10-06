﻿using System;
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
    public partial class SegundoPiso : Form
    {
        public SegundoPiso()
        {
            InitializeComponent();
        }

        private void SegundoPiso_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SetOrigen(txtDesde.Text);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            try
            {
                SetDestino(txtHasta.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
        }

        private void SetOrigen(string Origen)
        {
            Form ParentForm;
            ParentForm = this.FindForm();
            var findTextBox = ParentForm.Controls.Find(Origen, true).FirstOrDefault();

            if (findTextBox != null)
            {
                findTextBox.Enabled = true;
                findTextBox.BackColor = Color.Gray;
            }
        }

        private void SetDestino(string Destino)
        {
            Form ParentForm;
            ParentForm = this.FindForm();
            var findTextBox = ParentForm.Controls.Find(Destino, true).FirstOrDefault();

            if (findTextBox != null)
            {
                findTextBox.Enabled = true;
                findTextBox.BackColor = Color.CornflowerBlue;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClearColors();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void ClearColors()
        {
            Form ParentForm;
            ParentForm = this.FindForm();
            foreach (Control OFN in ParentForm.Controls)
            {
                String TipoControl = OFN.GetType().ToString();
                if (TipoControl == "System.Windows.Forms.RichTextBox")
                {
                    OFN.BackColor = Color.White;
                }
            }

        }

        private void BtnBarras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuApp Nuevaventana = new MenuApp();
            Nuevaventana.Show(); //el inicio es a la pantalla a la que quiero ir y this representa esta pantalla
        }
    }
}
