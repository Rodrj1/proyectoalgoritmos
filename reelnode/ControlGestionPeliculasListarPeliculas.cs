﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoNuevo
{
    public partial class ControlGestionPeliculasListarPeliculas : UserControl
    {
        public ControlGestionPeliculasListarPeliculas()
        {
            InitializeComponent();

            DataGridPeliculas.DataSource = null;
            DataGridPeliculas.DataSource = UtilsBD.peliculasCargadas;
        }

        private void PanelListar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
