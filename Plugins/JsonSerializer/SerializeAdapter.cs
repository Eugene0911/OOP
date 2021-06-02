using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdLaboratory;

namespace JsonSerializer
{
    class SerializeAdapter : ISerializePlugin
    {
        JsonSerializer adaptee;

        public SerializeAdapter()
        {
            adaptee = new JsonSerializer();
        }

        public List<Clothes> Deserialize(byte[] source)
        {
            var stream = new MemoryStream(source);
            return adaptee.Deserialize(stream) as List<Clothes>;
        }

        public byte[] Serialize(List<Clothes> list)
        {
            var stream = new MemoryStream();
            adaptee.Serialize(stream, list);
            return stream.ToArray();
        }
    }
}
