using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdLaboratory
{
    public interface IDataPlugin
    {
        void Activate(ref Dictionary<string, Func<Form>> dFormConstructors, ref Dictionary<Type, Func<string, Form>> dEditFormConstructors, ref ComboBox cb);
    }
}
