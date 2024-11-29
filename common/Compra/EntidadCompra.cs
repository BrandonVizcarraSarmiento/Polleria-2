using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Compra
{
    internal class EntidadCompra
    {
        public int CompraID { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }

        // Constructor por defecto
        public EntidadCompra() { }

        // Constructor con parámetros
        public EntidadCompra(string proveedor, DateTime fechaCompra)
        {
            Proveedor = proveedor;
            FechaCompra = fechaCompra;
        }
    }
}
