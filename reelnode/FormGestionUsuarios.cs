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
    public partial class FormGestionUsuarios: Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            DataGridUsuarios.DataSource = null;
            DataGridUsuarios.DataSource = UtilsBD.usuariosRegistrados;
        }



        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelCambiarRol.Visible = true;
            RbtAdmin.Checked = true;
        }

        private void BtnConfirmar_Click_1(object sender, EventArgs e)
        {
            UtilsBD.ModificarUsuarioBD(DataGridUsuarios);
            DataGridUsuarios.DataSource = null;
            UtilsBD.CargarUsuario();
            DataGridUsuarios.DataSource = UtilsBD.usuariosRegistrados;
        }

        private void RbtAdmin_CheckedChanged_1(object sender, EventArgs e) => DataGridUsuarios.Tag = "1";

        private void RbtUsuario_CheckedChanged_1(object sender, EventArgs e) => DataGridUsuarios.Tag = "2";


        private void DataGridUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataGridUsuarios.Columns[e.ColumnIndex].Name == "RolUsuario" &&
            e.Value != null && e.Value.ToString() == "Admin")
            {
                e.CellStyle.ForeColor = Color.Green;
            } 
            else if (DataGridUsuarios.Columns[e.ColumnIndex].Name == "RolUsuario" &&
            e.Value != null && e.Value.ToString() == "Moderador")
            {
                e.CellStyle.ForeColor = Color.Purple;
            } 
            else e.CellStyle.ForeColor = Color.Black;
        }
    }
}
