using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Cocina
{
    internal class EntidadCocina
    {
        public int CocinaID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }

        // Constructor por defecto
        public EntidadCocina() { }

        // Constructor con parámetros
        public EntidadCocina(int pedidoID, DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            PedidoID = pedidoID;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estado = estado;
        }
    }
}
