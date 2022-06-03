using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    class Json
    {
        public static void Serializar(object lista, string path)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(lista, Formatting.Indented, settings);
            File.WriteAllText(path, conteudo, Encoding.UTF8);
        }

        public static object DeserializarVeiculos(string path)
        {
            string conteudo = File.ReadAllText(path, Encoding.UTF8);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.DeserializeObject<List<VeiculoBase>>(conteudo, settings);
        }

        public static object DeserializarMarcas(string path)
        {
            string conteudo = File.ReadAllText(path, Encoding.UTF8);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.DeserializeObject<List<Marca>>(conteudo, settings);
        }

        public static object DeserializarModelos(string path)
        {
            string conteudo = File.ReadAllText(path, Encoding.UTF8);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.DeserializeObject<List<Modelo>>(conteudo, settings);
        }

        public static object DeserializarPedagios(string path)
        {
            string conteudo = File.ReadAllText(path, Encoding.UTF8);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.DeserializeObject<List<Pedagio>>(conteudo, settings);
        }
    }
}
