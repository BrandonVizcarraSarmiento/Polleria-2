using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common.DetalleCompra
{
    internal class EntidadDetalleCompra
    {
        public int DetalleCompraID { get; set; }
        public int CompraID { get; set; }
        public int IngredienteID { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        // Constructor por defecto
        public EntidadDetalleCompra() { }

        // Constructor con parámetros
        public EntidadDetalleCompra(int compraID, int ingredienteID, decimal cantidad, decimal precioUnitario, decimal subtotal)
        {
            CompraID = compraID;
            IngredienteID = ingredienteID;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }
    }
}
