using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Mesa
{
    internal class EntidadMesa
    {
        public int MesaID { get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidad { get; set; }

        // Constructor por defecto
        public EntidadMesa() { }

        // Constructor con parámetros
        public EntidadMesa(int numeroMesa, int capacidad)
        {
            NumeroMesa = numeroMesa;
            Capacidad = capacidad;
        }
    }
}
    