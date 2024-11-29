using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.Ingrediente
{
    internal class EntidadIngrediente
    {
        public int IngredienteID { get; set; }
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }

        public EntidadIngrediente() { }

        public EntidadIngrediente(string nombre, string unidadMedida)
        {
            Nombre = nombre;
            UnidadMedida = unidadMedida;
        }

        public EntidadIngrediente(int ingredienteID, string nombre, string unidadMedida)
        {
            IngredienteID = ingredienteID;
            Nombre = nombre;
            UnidadMedida = unidadMedida;
        }
    }
}
