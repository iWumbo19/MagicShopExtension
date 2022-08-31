using MagicShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public MagicShop(int count)
        {
            Data.Initialize();
            Inventory = GetRandomItems(count).Items;
        }
        public MagicShop()
        {
            Data.Initialize();
            Inventory = Data.FullList.Items;
        }
        public MagicShop()
        {

        }

        private MagicItemList GetRandomItems(int count) => new MagicItemList(RNG.GetRandomItems(Data.FullList.Items, count));
    }
}
