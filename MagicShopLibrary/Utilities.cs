using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary
{
    public static class Utilities
    {
        public readonly static Dictionary<string, ShopType> StringToShopType = new Dictionary<string, ShopType>();
        public readonly static Dictionary<string, ShopSize> StringToShopSize = new Dictionary<string, ShopSize>();
        public readonly static Dictionary<string, PlayerLevel> StringToPlayerLevel = new Dictionary<string, PlayerLevel>();
        public readonly static Dictionary<string, ItemType> StringToItemType = new Dictionary<string, ItemType>();


        static Utilities()
        {
            try
            {
                foreach (ShopType item in Enum.GetValues(typeof(ShopType)))
                    StringToShopType.Add(item.ToString(), item);
                foreach (ShopSize item in Enum.GetValues(typeof(ShopSize)))
                    StringToShopSize.Add(item.ToString(), item);
                foreach (PlayerLevel item in Enum.GetValues(typeof(PlayerLevel)))
                    StringToPlayerLevel.Add(item.ToString(), item);
                foreach (ItemType item in Enum.GetValues(typeof(ItemType)))
                    StringToItemType.Add(item.ToString(), item);
            }
            catch (Exception)
            {

            }
        }
    }
}
