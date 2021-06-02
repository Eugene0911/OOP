using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public enum DressType
    {
        Kimono,
        Sundress,
        ALine,
        Bubble,
        BabyDoll,
        Culotte,
        ShirtDress,
        Smocked,
        Trumpet
    }

    [Serializable]
    public class Dress : Clothes
    {
        public string Color { get; set; }

        public DressType Type { get; set; }

        public double Length { get; set; }

        public Dress(string name, string producer, string material, double price, DressType type, string color, double length) :
            base(name, producer, material, price)
        {
            Color = color;
            Type = type;
            Length = length;
        }
    }
}
