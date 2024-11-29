using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Asistencia
{
    internal class EntidadAsistencia
    {
        public int AsistenciaID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }

        // Constructor por defecto
        public EntidadAsistencia() { }

        // Constructor con parámetros
        public EntidadAsistencia(int empleadoID, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            EmpleadoID = empleadoID;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
        }

    }
}
