using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary
{
    internal static class Utilities
    {
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
