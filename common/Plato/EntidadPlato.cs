using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Plato
{
    internal class EntidadPlato
    {
        public int PlatoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public EntidadPlato() { }

        public EntidadPlato(string nombre, string descripcion, decimal precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public EntidadPlato(int platoID, string nombre, string descripcion, decimal precio)
        {
            PlatoID = platoID;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
