using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoNuevo
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        
        public string RolUsuario { get; set; }

        public Usuario() { }
        public Usuario(string nombreUsuario, string password, string rolUsuario)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
            RolUsuario = rolUsuario;
        }
    }
}
