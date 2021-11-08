using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CantidadEmpleadosException : Exception
    {
        public CantidadEmpleadosException (string mensaje)
            : base(mensaje) { }
    }
}
