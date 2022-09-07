using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary.Models
{
    public class APIReference
    {
        public string Index { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        public ItemType Type
        {
            get { return GetCategoryEnum(Name); }
            private set { }
        }

        public string URL { get; set; }

        private ItemType GetCategoryEnum(string name)
        {
            switch (name)
            {
                case "Armor":
                    return ItemType.Armor;
                case "Ammunition":
                    return ItemType.Ammunition;
                case "Wondrous Items":
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
                    throw new Exception("Did not recognize Item type");
            }
        }
    }
}
