using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Entrega
{
    internal class EntidadEntrega
    {
        public int EntregaID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public string EstadoEntrega { get; set; }

        // Constructor por defecto
        public EntidadEntrega() { }

        // Constructor con parámetros
        public EntidadEntrega(int pedidoID, DateTime fechaEntrega, string direccionEntrega, string estadoEntrega)
        {
            PedidoID = pedidoID;
            FechaEntrega = fechaEntrega;
            DireccionEntrega = direccionEntrega;
            EstadoEntrega = estadoEntrega;
        }
    }
}
