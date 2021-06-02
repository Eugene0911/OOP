using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public interface ISerializePlugin
    {
        byte[] Serialize(List<Clothes> list);

        List<Clothes> Deserialize(byte[] source);
    }
}
