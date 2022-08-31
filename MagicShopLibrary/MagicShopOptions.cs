using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary
{
    public class MagicShopOptions
    {
        public MagicShopOptions(int averageLevel, ShopType type, ShopSize size)
        {
            AveragePlayerLevel = averageLevel;
            Type = type;
            Size = size;
        }
        public int AveragePlayerLevel { get; private set; }
        public ShopType Type { get; private set; }
        public ShopSize Size { get; private set; }
    }
}
