using System;
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
    public partial class FormActualizarPelicula : Form
    {
        public FormActualizarPelicula()
        {
            InitializeComponent();
        }


        private void CtxMenuSubModificar_Click(object sender, EventArgs e)
        {
            foreach(TextBox textBox in PanelMain.Controls.OfType<TextBox>())
            {
                textBox.Enabled = true;
            }
        }

        private void PanelBuscarPeliculaNombre_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelBuscarPeliculaNombre, 10);
        }

        private void BtnBuscarPelicula_Click_1(object sender, EventArgs e)
        {
            string textoBuscador = TxtBuscarNombrePelicula.Text;

            List<Pelicula> peliculasEncontradas = UtilsBD.peliculasCargadas
                .Where(p => p.Nombre.ToLower().Contains(textoBuscador.ToLower()))
                .ToList();

            if (peliculasEncontradas.Count == 0)
            {
                MessageBox.Show("No se encontraron películas con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridPeliculas.DataSource = null;
            DataGridPeliculas.DataSource = peliculasEncontradas;
        }

        private void PanelDescripcion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
