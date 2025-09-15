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
            FormAdmin ventana = new FormAdmin();

            ventana.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Utils.Conexion.AbrirBD();

            string query = 
                "select " +
                "u.nombre_usuario, " +
                "u.password_usuario, " +
                "u.email_usuario, " +
                "r.nombre as nombre_rol\r\n" +
                "from usuarios u\r\n" +
                "inner join rol r on r.id_rol = u.id_rol;";

            using (MySqlCommand cmd = new MySqlCommand(query, Utils.Conexion.GetConnection()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario u = new Usuario()
                        {
                            NombreUsuario = reader.GetString("nombre_usuario"),
                            Password = reader.GetString("password_usuario"),
                            Email = reader.GetString("email_usuario"),
                            RolUsuario = reader.GetString("nombre_rol")
                        };
                        Utils.usuariosRegistrados.Add(u);
                    }
                }
            }
            /*CargarUsuarios();*/
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
