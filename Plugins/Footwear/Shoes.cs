using System;
using System.Collections.Generic;
using System.Text;
using ThirdLaboratory;

namespace Footwear
{
    public enum HeelType
    {
        None,
        Short,
        Default,
        High
    }

    [Serializable]
    public class Shoes : Clothes
    {
        public HeelType Heel { get; set; }

        public Shoes(string name, string producer, string material, double price, HeelType heel) :
            base(name, producer, material, price)
        {
            Heel = heel;
        }
    }
}
