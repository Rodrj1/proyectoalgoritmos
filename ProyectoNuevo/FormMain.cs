using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoNuevo
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel2.ClientRectangle,
                Color.DarkSlateGray,
                Color.FloralWhite,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
            }
        }

        private void ToolStpMenuAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdmin ventana = new FormAdmin();

            ventana.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UtilsBD.CargarUsuario();

            FormLogin login = new FormLogin();

            login.ShowDialog();

            ToolStpMenuAdmin.Visible = Utils.usuarioActual.RolUsuario == "Admin" ? true : false;
        }

        private void CargarUsuarios()
        {
            string ruta = Path.Combine(Application.StartupPath, "personas.json");
            string json = File.ReadAllText(ruta);
            Utils.usuariosRegistrados = JsonSerializer.Deserialize<List<Usuario>>(json);
        }

    }
}
