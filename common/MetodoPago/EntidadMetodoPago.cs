using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.MetodoPago
{
    internal class EntidadMetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Nombre { get; set; }

        public EntidadMetodoPago() { }

        public EntidadMetodoPago(string nombre)
        {
            Nombre = nombre;
        }

        public EntidadMetodoPago(int metodoPagoID, string nombre)
        {
            MetodoPagoID = metodoPagoID;
            Nombre = nombre;
        }
    }
}
