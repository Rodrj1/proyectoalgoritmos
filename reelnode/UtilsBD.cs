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

        public static void RegistrarUsuarioBD(Usuario nuevoUsuario)
        {
            string query = @"
            INSERT INTO usuarios (nombre_usuario, password_usuario, email_usuario, avatar, fecha_registro, id_rol) 
            VALUES (@nombre, @password, @email, @avatar, @fecha_registro, @rol);";

            using (MySqlCommand cmd = new MySqlCommand(query, Conexion.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@nombre", nuevoUsuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@password", nuevoUsuario.Password);
                cmd.Parameters.AddWithValue("@email", nuevoUsuario.Email);
                cmd.Parameters.AddWithValue("@avatar", null);
                cmd.Parameters.AddWithValue("@fecha_registro", nuevoUsuario.FechaRegistro);
                cmd.Parameters.AddWithValue("@rol", ObtenerRolUsuario(nuevoUsuario));

                cmd.ExecuteNonQuery();

                Utils.usuariosRegistrados.Add(nuevoUsuario);
            }
        }

        private static string ObtenerRolUsuario(Usuario u)
        {
            switch (u.RolUsuario.ToLower())
            {
                case "Admin":
                    return "1";
                case "Usuario":
                    return "2";
                default:
                    return "2";
            }
        }
        public static void CargarUsuario()
        {
            Conexion.AbrirBD();

            string query =
                "SELECT " +
                "u.nombre_usuario, " +
                "u.password_usuario, " +
                "u.email_usuario,"+
                "r.nombre as nombre_rol\r\n" +
                "FROM usuarios u\r\n" +
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
