using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.TipoEvento
{
    internal class EntidadTipoEvento
    {
        public int TipoEventoID { get; set; }
        public string Nombre { get; set; }

        // Constructor por defecto
        public EntidadTipoEvento() { }

        // Constructor con parámetros
        public EntidadTipoEvento(string nombre)
        {
            Nombre = nombre;
        }
    }
}
