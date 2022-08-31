using MagicShopLibrary;
using MagicShopLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
