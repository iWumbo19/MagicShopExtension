using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary
{
    internal class MagicShopOptions
    {
        public int AveragePlayerLevel { get; private set; }
        public ShopType Type { get; private set; }
        public ShopSize Size { get; private set; }
    }
}
