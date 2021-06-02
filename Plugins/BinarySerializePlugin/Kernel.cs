using System;
using System.Collections.Generic;
using System.Text;
using ThirdLaboratory;

namespace BinarySerializePlugin
{
    class Kernel : ISerializePlugin
    {
        public byte[] Serialize(List<Clothes> list)
        {
            var service = new SerializeService();
            var objList = new List<object>();
            foreach(var item in list)
            {
                objList.Add(item);
            }
            return service.Serialize(objList);
        }

        public List<Clothes> Deserialize(byte[] source)
        {
            var service = new SerializeService();
            var objList = service.Deserialize(source);
            var clothesList = new List<Clothes>();
            foreach(var item in objList)
            {
                clothesList.Add(item as Clothes);
            }
            return clothesList;
        }
    }
}
