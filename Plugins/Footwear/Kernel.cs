using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdLaboratory;

namespace Footwear
{
    public class Kernel : IDataPlugin
    {
        public void Activate(ref Dictionary<string, Func<Form>> dFormConstructors, ref Dictionary<Type, Func<string, Form>> dEditFormConstructors, ref ComboBox cb)
        {
            cb.Items.Add("Shoes");
            cb.Items.Add("Sneakers");

            dFormConstructors.Add("Shoes", () => { return new ShoesForm(); });
            dFormConstructors.Add("Sneakers", () => { return new SneakersForm(); });

            dEditFormConstructors.Add(typeof(Shoes), (string name) => { return new ShoesForm(name); });
            dEditFormConstructors.Add(typeof(Sneakers), (string name) => { return new SneakersForm(name); });
        }
    }
}
