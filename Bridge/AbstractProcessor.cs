using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory.Bridge
{
    abstract class AbstractProcessor
    {
        public IFunctionalPlugin FunctionalPlugin { private get; set; }

        public ISerializePlugin SerializePlugin { private get; set; }

        protected bool Status { get; set; }

        public AbstractProcessor(IFunctionalPlugin plugin1, ISerializePlugin plugin2)
        {
            FunctionalPlugin = plugin1;
            SerializePlugin = plugin2;
        }

        public AbstractProcessor()
        {
            FunctionalPlugin = null;
            SerializePlugin = null;
        }

        public virtual byte[] ProcessOutput(List<Clothes> data, string path)
        {
            byte[] byteArr;
            Status = true;
            try
            {
                if (SerializePlugin != null)
                {
                    byteArr = SerializePlugin.Serialize(data);
                    if (FunctionalPlugin != null)
                    {
                        byteArr = FunctionalPlugin.ProcessOutput(byteArr, path);
                    }
                } 
                else
                {
                    byteArr = null;
                    Status = false;
                }
            }
            catch
            {
                Status = false;
                byteArr = null;
            }
            ShowMessage();
            return byteArr;
        }

        public virtual List<Clothes> ProcessInput(byte[] data, string path)
        {
            List<Clothes> list;
            Status = true;
            try
            {
                if (SerializePlugin != null)
                {
                    if (FunctionalPlugin != null)
                    {
                        data = FunctionalPlugin.ProcessInput(data, path);
                    }
                    list = SerializePlugin.Deserialize(data);
                } 
                else
                {
                    list = null;
                    Status = false;
                }
            }
            catch
            {
                Status = false;
                list = null;
            }
            ShowMessage();
            return list;
        }

        public abstract void ShowMessage();
    }
}
