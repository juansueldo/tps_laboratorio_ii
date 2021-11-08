using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LegajoValidarException : Exception
    {
        public LegajoValidarException() : base("No es un legajo valido") { }
    }
}
