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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*Rectangle rect = panel2.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(53, 106, 124),
                Color.FromArgb(24, 76, 90),
                LinearGradientMode.Vertical))
            {
                Blend blend = new Blend();
                blend.Positions = new float[] { 0f, 0.4f, 0.6f, 1f };
                blend.Factors = new float[] { 0f, 0.5f, 0.7f, 1f };
                brush.Blend = blend;
                e.Graphics.FillRectangle(brush, rect);
            }*/
        }

        private void ToolStpMenuUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void ToolStpMenuPeliculas_Click(object sender, EventArgs e)
        {

        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = PanelPeliculaCreacion.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(34, 55, 85),
                Color.FromArgb(28, 51, 78),
                LinearGradientMode.Vertical))
            {
                Blend blend = new Blend();
                blend.Positions = new float[] { 0f, 0.4f, 0.6f, 1f };
                blend.Factors = new float[] { 0f, 0.5f, 0.7f, 1f };
                brush.Blend = blend;
                e.Graphics.FillRectangle(brush, rect);
            }

            Utils.RedondearBordes(PanelPeliculaCreacion, 20);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
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

    }
}
