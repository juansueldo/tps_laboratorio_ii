using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class SerializarAJson
    {
        public static void Serializar<T>(string ruta, T objeto) where T : class
        {
            try
            {
                if (objeto is null)
                {
                    throw new Exception("El objeto a serializar es nulo");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
            }
            catch (Exception)
            {
                throw new SerializarException("No se pudo serializar a Json");
            }
        }
        public static T Deserializar<T>(string ruta) where T : class
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                return objetoDeserealizado;
            }
            catch (Exception)
            {
                throw new SerializarException("No se pudo deserializar a Json");
            }
        }
    }
}
