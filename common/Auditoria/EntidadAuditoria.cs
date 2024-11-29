using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Auditoria
{
    internal class EntidadAuditoria
    {
        public int AuditoriaID { get; set; }
        public int UsuarioID { get; set; }
        public string Accion { get; set; }
        public DateTime FechaAccion { get; set; }

        // Constructor por defecto
        public EntidadAuditoria() { }

        // Constructor con parámetros
        public EntidadAuditoria(int usuarioID, string accion, DateTime fechaAccion)
        {
            UsuarioID = usuarioID;
            Accion = accion;
            FechaAccion = fechaAccion;
        }
    }
}
