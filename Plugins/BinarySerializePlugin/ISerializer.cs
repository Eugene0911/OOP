using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySerializePlugin
{
    interface ISerializer
    {
        byte[] Serialize(List<object> list);

        List<object> Deserialize(byte[] source);
    }
}
