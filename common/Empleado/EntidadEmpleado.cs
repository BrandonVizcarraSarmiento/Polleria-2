using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polleria.common
{
    internal class EntidadEmpleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaContratacion { get; set; }
        public decimal Salario { get; set; }

        public EntidadEmpleado() { }

        public EntidadEmpleado(string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaContratacion, decimal salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Direccion = direccion;
            FechaContratacion = fechaContratacion;
            Salario = salario;
        }

        public EntidadEmpleado(int empleadoID, string nombre, string apellido, string dni, string telefono, string direccion, DateTime fechaContratacion, decimal salario)
        {
            EmpleadoID = empleadoID;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Direccion = direccion;
            FechaContratacion = fechaContratacion;
            Salario = salario;
        }
    }
}
