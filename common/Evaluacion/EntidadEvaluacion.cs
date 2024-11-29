using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Evaluacion
{
    internal class EntidadEvaluacion
    {
        public int EvaluacionID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }
        public string Comentario { get; set; }

        // Constructor por defecto
        public EntidadEvaluacion() { }

        // Constructor con parámetros
        public EntidadEvaluacion(int empleadoID, DateTime fecha, int calificacion, string comentario)
        {
            EmpleadoID = empleadoID;
            Fecha = fecha;
            Calificacion = calificacion;
            Comentario = comentario;
        }

    }
}
