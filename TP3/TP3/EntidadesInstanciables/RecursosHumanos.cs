using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RecursosHumanos : Empleado
    {
        public RecursosHumanos(string legajo, string nombre, string apellido, string sueldo, Genero genero)
            : base(legajo, nombre, apellido, sueldo, genero) { }
        public override Sector Tipo
        {
            get
            {
                return Sector.RRHH;
            }
        }
        public override string MostrarEmpleado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarEmpleado());
            sb.AppendLine($"[Puesto] RRHH");

            return sb.ToString();
        }
    }
}
