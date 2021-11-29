using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Texto : IArchivos<string>
    {
        public void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(dato);
                }
            }
            catch (Exception)
            {
                throw new Exception("No se pudo guardar");
            }
        }

        public string Leer(string path)
        {
            string retorno = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        retorno += $"{streamReader.ReadLine()}\n";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
    }
}
