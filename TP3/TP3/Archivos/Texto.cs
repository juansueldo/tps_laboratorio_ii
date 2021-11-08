using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto : IArchivos<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter stream = new StreamWriter(archivo, false))
                {
                    stream.Write(datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
        public bool Leer(string archivo, out string datos)
        {
            datos = "";
            bool retorno = false;
            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    datos = (string)sr.ReadToEnd();
                    sr.Close();
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
    }
}
