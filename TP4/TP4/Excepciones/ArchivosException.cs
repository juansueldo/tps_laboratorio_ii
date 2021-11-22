using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException)
           : base("Error en el archivo", innerException) { }

        public ArchivosException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
        public ArchivosException(string mensaje) : base(mensaje){ }
    }
}
