using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Usuario
{
    internal class EntidadUsuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        // Constructor por defecto
        public EntidadUsuario() { }

        // Constructor con parámetros
        public EntidadUsuario(string nombreUsuario, string contraseña, string rol)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
