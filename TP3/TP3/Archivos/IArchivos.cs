using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T> where T : class
    {
        public bool Guardar(string archivo, T datos);

        public bool Leer(string archivo, out T datos);
    }
}
