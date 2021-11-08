using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoException : Exception
    {
        public EmpleadoException(string mensaje) : base(mensaje) { }
    }
}
