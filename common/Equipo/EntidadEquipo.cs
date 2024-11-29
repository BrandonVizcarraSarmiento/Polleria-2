using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Equipo
{
    internal class EntidadEquipo
    {
        public int EquipoID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaMantenimiento { get; set; }

        // Constructor por defecto
        public EntidadEquipo() { }

        // Constructor con parámetros
        public EntidadEquipo(string nombre, DateTime fechaCompra, DateTime fechaMantenimiento)
        {
            Nombre = nombre;
            FechaCompra = fechaCompra;
            FechaMantenimiento = fechaMantenimiento;
        }
    }
}
