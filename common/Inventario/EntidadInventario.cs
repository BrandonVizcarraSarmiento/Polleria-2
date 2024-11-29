    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Inventario
{
    internal class EntidadInventario
    {
        public int InventarioID { get; set; }
        public int IngredienteID { get; set; }
        public string NombreIngrediente { get; set; }
        public decimal CantidadActual { get; set; }
        public string UnidadMedida { get; set; }

        public EntidadInventario() { }

        public EntidadInventario(int ingredienteID, string nombreIngrediente, decimal cantidadActual, string unidadMedida)
        {
            IngredienteID = ingredienteID;
            NombreIngrediente = nombreIngrediente;
            CantidadActual = cantidadActual;
            UnidadMedida = unidadMedida;
        }

        public EntidadInventario(int inventarioID, int ingredienteID, string nombreIngrediente, decimal cantidadActual, string unidadMedida)
        {
            InventarioID = inventarioID;
            IngredienteID = ingredienteID;
            NombreIngrediente = nombreIngrediente;
            CantidadActual = cantidadActual;
            UnidadMedida = unidadMedida;
        }
    }
}
