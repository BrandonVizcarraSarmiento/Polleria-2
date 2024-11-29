using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Pedido
{
    internal class EntidadPedido
    {
        public int PedidoID { get; set; }
        public string Cliente { get; set; }
        public int MetodoPagoID { get; set; }
        public DateTime FechaPedido { get; set; }
        public decimal MontoTotal { get; set; }

        public EntidadPedido() { }

        public EntidadPedido(string cliente, int metodoPagoID, DateTime fechaPedido, decimal montoTotal)
        {
            Cliente = cliente;
            MetodoPagoID = metodoPagoID;
            FechaPedido = fechaPedido;
            MontoTotal = montoTotal;
        }

        public EntidadPedido(int pedidoID, string cliente, int metodoPagoID, DateTime fechaPedido, decimal montoTotal)
        {
            PedidoID = pedidoID;
            Cliente = cliente;
            MetodoPagoID = metodoPagoID;
            FechaPedido = fechaPedido;
            MontoTotal = montoTotal;
        }
    }
}
