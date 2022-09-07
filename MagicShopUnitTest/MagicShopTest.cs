using MagicShopLibrary;
using MagicShopLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MagicShopUnitTest
{
    [TestClass]
    public class MagicShopTest
    {
        [TestMethod]
        public void FirstInitializeData()
        {
            MagicShop ms = new MagicShop(100);
        }

        [TestMethod]
        public void SecondInitailizeData()
        {
            MagicShop ms = new MagicShop(100);
        }


        [TestMethod]
        public void QueryAllItemsInData()
        {
            MagicShop ms = new MagicShop();
            foreach (var item in ms.Inventory)
            {
                if (item.Index == null) Assert.Fail("Index was null");
                if (item.Name == null) Assert.Fail("Name was null");
                if (item.URL == null) Assert.Fail("URL was null");
                if (item.Description[0] == null) Assert.Fail("Description Overview was null");
                if (item.Description[1] == null) Assert.Fail("Description Full was null");
                if (item.Category == null) Assert.Fail("Category was null");
                if (item.Rarity == null) Assert.Fail("Rarity was null");
            }
        }

        [TestMethod]
        public void MakeAllShops()
        {
            MagicShop ms;
            ShopType[] types = (ShopType[])Enum.GetValues(typeof(ShopType));
            ShopSize[] sizes = (ShopSize[])Enum.GetValues(typeof(ShopSize));

            for(int i = 0; i < types.Length; i++)
            {
                for (int j = 0; j < sizes.Length; j++)
                {
                    ms = new MagicShop(new MagicShopOptions(20, types[i], sizes[j]));
                }
            } 
        }
    }
}
