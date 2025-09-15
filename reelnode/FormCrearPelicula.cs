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
    public partial class FormCrearPelicula : Form
    {
        public FormCrearPelicula()
        {
            InitializeComponent();
        }

        private void FormCrearPelicula_Load(object sender, EventArgs e)
        {

        }

        private void PanelUsuario_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelUsuario, 10);
        }

        private void PanelFecha_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelFecha, 10);
        }

        private void PanelDirector_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelDirector, 10);
        }

        private void PanelDuracion_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelDuracion, 10);
        }

        private void PanelImagen_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelImagen, 10);
        }

        private void PanelDescripcion_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelDescripcion, 10);
        }

        private void BtnCargarPelicula_Click(object sender, EventArgs e)
        {
            Pelicula nuevaPelicula = new Pelicula
            {
                Nombre = TxtNombre.Text,
                Director = TxtDirector.Text,
                Duracion = TxtDuracion.Text,
                FechaEstreno = DtpFechaEstreno.Value,
                Descripcion = TxtDescripcion.Text,
                Imagen = PicPelicula.Image
            };

            UtilsBD.InsertarPeliculaBD(nuevaPelicula);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelPeliculaCreacion_Paint(object sender, PaintEventArgs e)
        {
            Utils.RedondearBordes(PanelPeliculaCreacion, 10);
        }
    }
}
