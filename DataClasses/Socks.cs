using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public enum LengthType
    {
        NoShow,
        Ped,
        MidCalf,
        Liner,
        Quarter,
        Golf
    }

    [Serializable]
    public class Socks : Clothes
    {
        public string Color { get; set; }

        public LengthType Length { get; set; }

        public Socks(string name, string producer, string material, double price, string color, LengthType type) :
            base(name, producer, material, price)
        {
            Color = color;
            Length = type;
        }
    }
}
