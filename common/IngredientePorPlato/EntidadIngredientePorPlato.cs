using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.IngredientePorPlato
{
    internal class EntidadIngredientePorPlato
    {
        public int IngredientePlatoID { get; set; }
        public int PlatoID { get; set; }
        public int IngredienteID { get; set; }
        public decimal CantidadNecesaria { get; set; }

        // Constructor por defecto
        public EntidadIngredientePorPlato() { }

        // Constructor con parámetros
        public EntidadIngredientePorPlato(int platoID, int ingredienteID, decimal cantidadNecesaria)
        {
            PlatoID = platoID;
            IngredienteID = ingredienteID;
            CantidadNecesaria = cantidadNecesaria;
        }
    }
}
