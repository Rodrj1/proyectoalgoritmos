using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoNuevo
{
    public static class Utils
    {
        public static List<Usuario> usuariosRegistrados = new List<Usuario>();
        public static Usuario usuarioActual = new Usuario("", "", "Usuario", "admin@gmail.com");
        public static List<Pelicula> peliculas = new List<Pelicula>();
    }
}
