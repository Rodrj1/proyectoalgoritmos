using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoNuevo
{
    public static class UtilsBD
    {
        public static ConexionBD Conexion = new ConexionBD();

        public static void RegistrarUsuario(Usuario nuevoUsuario) 
        {
            string query = @"
            INSERT INTO usuarios (nombre_usuario, password_usuario, email_usuario, id_rol) 
            VALUES (@nombre, @password, @email, @rol);";

            using (MySqlCommand cmd = new MySqlCommand(query, UtilsBD.Conexion.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@nombre", nuevoUsuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@password", nuevoUsuario.Password);
                cmd.Parameters.AddWithValue("@email", nuevoUsuario.Email);
                cmd.Parameters.AddWithValue("@rol", nuevoUsuario.RolUsuario == "Admin" ? 1 : 2);

                cmd.ExecuteNonQuery();

                Utils.usuariosRegistrados.Add(nuevoUsuario);
            }
        }
        public static void CargarUsuario()
        {
            Conexion.AbrirBD();

            string query =
                "SELECT " +
                "u.nombre, " +
                "r.nombre as nombre_rol\r\n" +
                "FROM usuario u\r\n" +
                "INNER JOIN rol r on r.id_rol = u.id_rol;";

            using (MySqlCommand cmd = new MySqlCommand(query, UtilsBD.Conexion.GetConnection()))
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
        }
    }
}
