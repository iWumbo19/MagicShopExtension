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
            Data.Initialize();
            Inventory = Data.FullList.Items;
        }
        public MagicShop(int count)
        {
            Data.Initialize();
            Inventory = Data.GetRandomItems(count).Items;
        }
        public MagicShop(MagicShopOptions options)
        {
            Data.Initialize();
            PlayerLevel = options.AveragePlayerLevel;
            ShopSize = options.Size;
            ShopType = options.Type;
            Inventory = Data.GetItems(ShopType, ShopSize, PlayerLevel);
        }
        
    }
}
