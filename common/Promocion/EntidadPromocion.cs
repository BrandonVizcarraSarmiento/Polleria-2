using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Promocion
{
    internal class EntidadPromocion
    {
        public int PromocionID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Descuento { get; set; }

        // Constructor por defecto
        public EntidadPromocion() { }

        // Constructor con parámetros
        public EntidadPromocion(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, decimal descuento)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Descuento = descuento;
        }
    }
}
