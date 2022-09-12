using MagicShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MagicShopLibrary
{
    public class MagicShop
    {
        public MagicItem[] Inventory { get; set; }
        public int Count
        {
            get { return Inventory.Length; }
            private set {}
        }
        public ShopType ShopType { get; private set; }
        public ShopSize ShopSize { get; private set; }
        private int PlayerLevel { get; set; }

        public MagicShop()
        {
            Inventory = Data.FullList.Items;
        }
        public MagicShop(int count)
        {
            Inventory = Data.GetRandomItems(count).Items;
        }
        public MagicShop(MagicShopOptions options)
        {
            PlayerLevel = options.AveragePlayerLevel;
            ShopSize = options.Size;
            ShopType = options.Type;
            Inventory = Data.GetItems(ShopType, ShopSize, PlayerLevel);
        }
        
    }
}
