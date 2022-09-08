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


        internal static string ItemTypeToString(ItemType type)
        {
            switch (type)
            {
                case ItemType.Armor:
                    return "Armor";
                case ItemType.Ammunition:
                    return "Ammunition";
                case ItemType.WondrousItem:
                    return "Wonderous Item";
                case ItemType.Weapon:
                    return "Weapon";
                case ItemType.Rod:
                    return "Rod";
                case ItemType.Potion:
                    return "Potion";
                case ItemType.Ring:
                    return "Ring";
                case ItemType.Scroll:
                    return "Scroll";
                case ItemType.Staff:
                    return "Staff";
                case ItemType.Wand:
                    return "Wand";
                default:
                    throw new Exception("Could not convert ItemType to string");
            }
        }

        internal static void BuildTables()
        {
            foreach (ShopType item in Enum.GetValues(typeof(ShopType)))
                StringToShopType.Add(item.ToString(), item);
            foreach (ShopSize item in Enum.GetValues(typeof(ShopSize)))
                StringToShopSize.Add(item.ToString(), item);
            foreach (PlayerLevel item in Enum.GetValues(typeof(PlayerLevel)))
                StringToPlayerLevel.Add(item.ToString(), item);
        }

        internal static ItemType StringToItemType(string type)
        {
            switch (type)
            {
                case "Armor":
                    return ItemType.Armor;
                case "Ammunition":
                    return ItemType.Ammunition;
                case "Wonderous Item":
                    return ItemType.WondrousItem;
                case "Weapon":
                    return ItemType.Weapon;
                case "Rod":
                    return ItemType.Rod;
                case "Potion":
                    return ItemType.Potion;
                case "Ring":
                    return ItemType.Ring;
                case "Scroll":
                    return ItemType.Scroll;
                case "Staff":
                    return ItemType.Staff;
                case "Wand":
                    return ItemType.Wand;
                default:
                    throw new Exception("Pass in string could not be converted to ItemType");
            }
        }
    }
}
