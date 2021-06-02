using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public class PluginsLoader<T> : ILoader<T> where T: class
    {
        public string Path { get; set; }

        public PluginsLoader(string path)
        {
            Path = path;
        }

        public List<T> Load()
        {
            var dirInfo = new DirectoryInfo(Path);
            if(!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            var plugins = new List<T>();
            var files = Directory.GetFiles(Path, "*.dll");
            foreach(var file in files)
            {
                if (IsValidPlugin(file))
                {
                    Type[] types;
                    Assembly asm = Assembly.LoadFrom(file);
                    try
                    {
                        types = asm.GetTypes();
                    }
                    catch (ReflectionTypeLoadException)
                    {
                        types = null;
                    }
                    if (types != null)
                    {
                        foreach (var type in types)
                        {
                            if (type.GetInterface(typeof(T).Name) != null)
                            {
                                var plugin = asm.CreateInstance(type.FullName) as T;
                                plugins.Add(plugin);
                            }
                        }
                    }
                }
            }
            return plugins;

        }

        private bool IsEqual(byte[] first, byte[] second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }
            for(int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidPlugin(string fileName)
        {
            try
            {
                AssemblyName asmName = AssemblyName.GetAssemblyName(fileName);
                AssemblyName selfAsmName = Assembly.GetExecutingAssembly().GetName();
                if (IsEqual(asmName.GetPublicKeyToken(), selfAsmName.GetPublicKeyToken()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
