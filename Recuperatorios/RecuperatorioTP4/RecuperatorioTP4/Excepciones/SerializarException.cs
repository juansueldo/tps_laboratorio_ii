using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerializarException : Exception
    {
        public SerializarException(string mensaje) : base(mensaje) { }
    }
}
