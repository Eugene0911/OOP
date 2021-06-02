using System.IO;
using System.Text;
using Newtonsoft.Json;
using SerializerInterface;

namespace JsonSerializer
{
    public class JsonSerializer : ISerializerPlugin
    {
        private static JsonSerializerSettings jsonSettings;

        public JsonSerializer()
        {
            jsonSettings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
        }

        public object Deserialize(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            string jsonString = reader.ReadToEnd();
            return JsonConvert.DeserializeObject(jsonString, jsonSettings);
        }

        public void Serialize(Stream stream, object obj)
        {
            var tempStream = new MemoryStream(Encoding.Default.GetBytes(JsonConvert.SerializeObject(obj, jsonSettings)));
            tempStream.CopyTo(stream);
        }
    }
}
