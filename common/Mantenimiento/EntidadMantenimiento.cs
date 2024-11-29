using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Mantenimiento
{
    internal class EntidadMantenimiento
    {
        public int MantenimientoID { get; set; }
        public int EquipoID { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string Descripcion { get; set; }

        // Constructor por defecto
        public EntidadMantenimiento() { }

        // Constructor con parámetros
        public EntidadMantenimiento(int equipoID, DateTime fechaMantenimiento, string descripcion)
        {
            EquipoID = equipoID;
            FechaMantenimiento = fechaMantenimiento;
            Descripcion = descripcion;
        }
    }
}
