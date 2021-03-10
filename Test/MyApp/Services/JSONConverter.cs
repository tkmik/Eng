using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class JSONConverter<T>
    {
        public static string Serialize(IEnumerable<T> collection)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                 Formatting = Formatting.Indented
            };
            return JsonConvert.SerializeObject(collection, settings);
        }
        public static IEnumerable<T> Deserialize(string json)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            };
            return JsonConvert.DeserializeObject<IEnumerable<T>>(json, settings);
        }
    }
}
