using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Turno
{
    internal class EntidadTurno
    {
        public int TurnoID { get; set; }
        public string NombreTurno { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public EntidadTurno() { }

        public EntidadTurno(string nombreTurno, TimeSpan horaInicio, TimeSpan horaFin)
        {
            NombreTurno = nombreTurno;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        public EntidadTurno(int turnoID, string nombreTurno, TimeSpan horaInicio, TimeSpan horaFin)
        {
            TurnoID = turnoID;
            NombreTurno = nombreTurno;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
