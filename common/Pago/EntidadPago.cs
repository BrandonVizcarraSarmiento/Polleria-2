using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Pago
{
    internal class EntidadPago
    {
        public int PagoID { get; set; }
        public int PedidoID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }

        // Constructor por defecto
        public EntidadPago() { }

        // Constructor con parámetros
        public EntidadPago(int pedidoID, decimal monto, DateTime fechaPago, string metodoPago)
        {
            PedidoID = pedidoID;
            Monto = monto;
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
        }
    }
}
