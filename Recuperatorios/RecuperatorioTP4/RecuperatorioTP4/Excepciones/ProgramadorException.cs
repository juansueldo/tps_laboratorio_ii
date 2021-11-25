using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProgramadorException : Exception
    {
        public ProgramadorException(string mensaje) : base(mensaje) { }
    }
}
