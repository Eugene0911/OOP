using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public enum Buckle
    {
        Classical,
        Clipse,
        Butterfly
    }

    [Serializable]
    public class Belt : Clothes
    {
        public string BuckleMaterial { get; set; }

        public Buckle BuckleType { get; set; }

        public Belt(string name, string producer, string material, double price, string buckleMaterial, Buckle type) :
            base(name, producer, material, price)
        {
            BuckleMaterial = buckleMaterial;
            BuckleType = type;
        }
    }
}
