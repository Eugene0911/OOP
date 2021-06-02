using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLaboratory
{
    public enum Collar
    {
        Classical,
        Kent,
        Mandarin,
        Butterfly,
        Tab
    }

    [Serializable]
    public class Shirt : Clothes
    {
        public Collar CollarType { get; set; }

        public bool Cufflink { get; set; }

        public string Color { get; set; }

        public Shirt(Collar collarType, bool cufflink, string color, string name, string producer, string material, double price) : 
            base(name, producer, material, price)
        {
            CollarType = collarType;
            Cufflink = cufflink;
            Color = color;
        }
    }
}
