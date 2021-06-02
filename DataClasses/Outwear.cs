using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public enum OutwearTypes
    {
        Jacket,
        Coat,
        Windbreaker,
        Denim
    }

    [Serializable]
    public class Outwear : Clothes
    {
        public string Color { get; set; }

        public OutwearTypes Type { get; set; }

        public Outwear(string name, string producer, string material, double price, string color, OutwearTypes type) :
            base(name, producer, material, price)
        {
            Color = color;
            Type = type;
        }
    }
}
