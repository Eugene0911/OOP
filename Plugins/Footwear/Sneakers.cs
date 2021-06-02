using System;
using ThirdLaboratory;

namespace Footwear
{
    [Serializable]
    public class Sneakers : Clothes
    {
        public string Color { get; set; }

        public bool HasShoelaces { get; set; }

        public Sneakers(string name, string producer, string material, double price, string color, bool hasShoelaces) :
            base(name, producer, material, price)
        {
            Color = Color;
            HasShoelaces = hasShoelaces;
        }
    }
}
