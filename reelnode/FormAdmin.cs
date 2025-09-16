using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoNuevo
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void ToolStpSubMenuCargarPeliculas_Click(object sender, EventArgs e)
        {
            FormCrearPelicula formCrearPelicula = new FormCrearPelicula();

            formCrearPelicula.ShowDialog();
        }

        private void ToolStpSubMenuListarPeliculas_Click(object sender, EventArgs e)
        {
            DataGridPeliculas.DataSource = null;
            DataGridPeliculas.DataSource = UtilsBD.peliculasCargadas;
        }

        private void ToolStpMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios f = new FormGestionUsuarios();

            f.ShowDialog();
        }
    }
}
