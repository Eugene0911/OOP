using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace BinarySerializePlugin
{
    class Binder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Assembly currAsm = Assembly.GetExecutingAssembly();
            return Type.GetType($"{currAsm.GetName().Name}.{typeName.Split('.')[1]}");
        }
    }
}
