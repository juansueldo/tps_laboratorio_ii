using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class GestorArchivo : IArchivos<Empresa>, IArchivos<string>
    {

        private IArchivos<Empresa>.ETipoArchivo tipo;

        public GestorArchivo()
        {

        }
        public GestorArchivo(IArchivos<Empresa>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        public IArchivos<Empresa>.ETipoArchivo Tipo { set => tipo = value; }

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
                throw;
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

        void IArchivos<Empresa>.Escribir(Empresa dato, string path)
        {
            try
            {
                if (this.tipo == IArchivos<Empresa>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Empresa));
                            xmlSerializer.Serialize(xmlTextWriter, dato);
                        }
                    }
                    else
                    {
                        throw new ArchivosException("Extension invalida para XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Texto texto = new Texto();
                        texto.Escribir(JsonSerializer.Serialize(dato, typeof(Empresa)), path);
                    }
                    else
                    {
                        throw new ArchivosException("Extension invalida para JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        Empresa IArchivos<Empresa>.Leer(string path)
        {
            try
            {
                if (this.tipo == IArchivos<Empresa>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Empresa));
                            return (Empresa)xmlSerializer.Deserialize(xmlTextReader);
                        }
                    }
                    else
                    {
                        throw new ArchivosException("Extension invalida para XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        Texto archivoTexto = new Texto();
                        return JsonSerializer.Deserialize<Empresa>(archivoTexto.Leer(path));
                    }
                    else
                    {
                        throw new ArchivosException("Extension invalida para JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
