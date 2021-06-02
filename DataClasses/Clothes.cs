using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    [Serializable]
    public abstract class Clothes
    {
        public string Name { get; set; }

        public string Producer { get; set; }

        public double Price { get; set; }

        public string MainMaterial { get; set; }

        public Clothes(string name, string producer, string material, double price)
        {
            Name = name;
            Producer = producer;
            MainMaterial = material;
            Price = price;
        }
    }
}
