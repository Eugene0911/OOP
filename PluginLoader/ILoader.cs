using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    interface ILoader<T>
    {
        List<T> Load();
    }
}
