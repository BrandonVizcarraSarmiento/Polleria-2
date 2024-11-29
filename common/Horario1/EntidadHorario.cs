using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common
{
    internal class EntidadHorario

    {
        public int HorarioID { get; set; }
        public int EmpleadoID { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public EntidadHorario() { }

        public EntidadHorario(int empleadoID, string diaSemana, TimeSpan horaInicio, TimeSpan horaFin)
        {
            EmpleadoID = empleadoID;
            DiaSemana = diaSemana;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        public EntidadHorario(int horarioID, int empleadoID, string diaSemana, TimeSpan horaInicio, TimeSpan horaFin)
        {
            HorarioID = horarioID;
            EmpleadoID = empleadoID;
            DiaSemana = diaSemana;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
