using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public interface IFunctionalPlugin
    {
        byte[] ProcessOutput(byte[] data, string fileName);

        byte[] ProcessInput(byte[] data, string fileName);
    }
}
