using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.PagoProveedor
{
    internal class EntidadPagoProveedor
    {
        public int PagoProveedorID { get; set; }
        public int ProveedorID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }

        // Constructor por defecto
        public EntidadPagoProveedor() { }

        // Constructor con parámetros
        public EntidadPagoProveedor(int proveedorID, decimal monto, DateTime fechaPago, string metodoPago)
        {
            ProveedorID = proveedorID;
            Monto = monto;
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
        }
    }
}
