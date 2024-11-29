using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Evento
{
    internal class EntidadEvento
    {
        public int EventoID { get; set; }
        public int TipoEventoID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Lugar { get; set; }

        // Constructor por defecto
        public EntidadEvento() { }

        // Constructor con parámetros
        public EntidadEvento(int tipoEventoID, string descripcion, DateTime fechaEvento, string lugar)
        {
            TipoEventoID = tipoEventoID;
            Descripcion = descripcion;
            FechaEvento = fechaEvento;
            Lugar = lugar;
        }
    }
}
