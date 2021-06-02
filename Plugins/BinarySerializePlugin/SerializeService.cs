using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BinarySerializePlugin
{
    class SerializeService : ISerializer
    {
        public byte[] Serialize(List<object> list)
        {
            var formatter = new BinaryFormatter();

            using(var stream = new MemoryStream())
            {
                formatter.Serialize(stream, list);
                return stream.ToArray();
            }
        }

        public List<object> Deserialize(byte[] source)
        {
            var formatter = new BinaryFormatter();
            formatter.Binder = new Binder();

            using(var stream = new MemoryStream(source))
            {
                return formatter.Deserialize(stream) as List<object>;
            }
        }
    }
}
