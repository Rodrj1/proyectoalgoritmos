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

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            UtilsBD.ModificarUsuarioBD(DataGridUsuarios);
            UtilsBD.CargarUsuario();
        }
    }
}
