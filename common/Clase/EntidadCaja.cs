using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Clase
{
    internal class EntidadCaja
    {
        public int CajaID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        // Constructor por defecto
        public EntidadCaja() { }

        // Constructor con parámetros
        public EntidadCaja(DateTime fecha, decimal total)
        {
            Fecha = fecha;
            Total = total;
        }
    }
}
