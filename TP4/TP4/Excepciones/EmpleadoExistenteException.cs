using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException(string mensaje)
            : base(mensaje) { }
    }
}
