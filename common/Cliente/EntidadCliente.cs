using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Cliente
{
    internal class EntidadCliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Constructor por defecto
        public EntidadCliente() { }

        // Constructor con parámetros
        public EntidadCliente(string nombre, string apellido, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
