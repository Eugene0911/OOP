using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public enum TrousersType
    {
        Classical,
        Cargo,
        Flare,
        Baggy,
        Palazzo,
        Jeans
    }

    [Serializable]
    public class Trousers : Clothes
    {
        public string Color { get; set; }

        public TrousersType Type { get; set; }

        public Trousers(string name, string producer, string material, double price, string color, TrousersType type) :
            base(name, producer, material, price)
        {
            Color = color;
            Type = type;
        }
    }
}
