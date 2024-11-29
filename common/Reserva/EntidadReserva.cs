using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Reserva
{
    internal class EntidadReserva
    {
        public int ReservaID { get; set; }
        public int MesaID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaReserva { get; set; }

        // Constructor por defecto
        public EntidadReserva() { }

        // Constructor con parámetros
        public EntidadReserva(int mesaID, int clienteID, DateTime fechaReserva)
        {
            MesaID = mesaID;
            ClienteID = clienteID;
            FechaReserva = fechaReserva;
        }
    }
}
