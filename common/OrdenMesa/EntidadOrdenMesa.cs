using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.OrdenMesa
{
    internal class EntidadOrdenMesa
    {
        public int OrdenID { get; set; }
        public int MesaID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaOrden { get; set; }

        // Constructor por defecto
        public EntidadOrdenMesa() { }

        // Constructor con parámetros
        public EntidadOrdenMesa(int mesaID, int pedidoID, DateTime fechaOrden)
        {
            MesaID = mesaID;
            PedidoID = pedidoID;
            FechaOrden = fechaOrden;
        }
    }
}
