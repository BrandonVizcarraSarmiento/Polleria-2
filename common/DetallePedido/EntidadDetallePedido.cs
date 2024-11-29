using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.DetallePedido
{
    internal class EntidadDetallePedido
    {
        public int DetallePedidoID { get; set; }
        public int PedidoID { get; set; }
        public int PlatoID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public EntidadDetallePedido() { }

        public EntidadDetallePedido(int pedidoID, int platoID, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            PedidoID = pedidoID;
            PlatoID = platoID;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }

        public EntidadDetallePedido(int detallePedidoID, int pedidoID, int platoID, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            DetallePedidoID = detallePedidoID;
            PedidoID = pedidoID;
            PlatoID = platoID;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }
    }
}
