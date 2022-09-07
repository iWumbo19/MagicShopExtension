using MagicShopLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MagicShopLibrary
{
    internal static class Data
    {
        internal static MagicItemList FullList { get; private set; }

        internal static void Initialize()
        {
            FullList = JsonConvert.DeserializeObject<MagicItemList>(File.ReadAllText(@"magicshop.json"));
        }
        internal static MagicItem[] GetItems(Rarity rarity) => FullList.Items.Where(x => x.Rarity.Value == rarity).ToArray();
        internal static MagicItem[] GetItems(ItemType type) => FullList.Items.Where(x => x.Category.Type == type).ToArray();
        internal static MagicItem[] GetItems(ItemType type, Rarity rarity) => FullList.Items.Where(x => x.Category.Type == type && x.Rarity.Value == rarity).ToArray();
        internal static MagicItem[] GetItems(ShopType type, ShopSize size, int level)
        {
            List<Rarity> rarities = LevelToRarityList(level);
            List<ItemType> types = ShopTypeToItemType(type);
            MagicItem[] matchingItems = FullList.Items.Where(x => types.Contains(x.Category.Type) && rarities.Contains(x.Rarity.Value)).ToArray();
            return RNG.GetRandomItems(matchingItems, size);
        }
        internal static MagicItemList GetRandomItems(int count) => new MagicItemList(RNG.GetRandomItems(Data.FullList.Items, count));
        internal static MagicItemList ConvertToMagicItemList(MagicItem[] items) => new MagicItemList(items);
        internal static MagicItemList ConvertToMagicItemList(List<MagicItem> items) => new MagicItemList(items);
        
        private static List<Rarity> LevelToRarityList(int level)
        {
            List<Rarity> output = new List<Rarity>() { Rarity.Common, Rarity.Uncommon };
            if (level > 4) 
                output.Add(Rarity.Rare);
            if (level > 10)
                output.Add(Rarity.VeryRare);
            if (level > 16)
                output.Add(Rarity.Legendary);
            return output;
        }
        private static List<ItemType> ShopTypeToItemType(ShopType type)
        {
            List<ItemType> output = new List<ItemType>();
            switch (type)
            {
                case ShopType.General:
                    output = Enum.GetValues(typeof(ShopType)).Cast<ItemType>().ToList();
                    break;
                case ShopType.Blacksmith:
                    output.Add(ItemType.Weapon);
                    break;
                case ShopType.Armorer:
                    output.Add(ItemType.Armor);
                    break;
                case ShopType.Alchemist:
                    output.Add(ItemType.Potion);
                    break;
                case ShopType.Scribe:
                    output.Add(ItemType.Scroll);
                    output.Add(ItemType.Staff);
                    break;
                case ShopType.WandWright:
                    output.Add(ItemType.Scroll);
                    output.Add(ItemType.Wand);
                    break;
                default:
                    throw new Exception("Did not recognize pass in ShopType");
            }
            return output;
        }
    }
}
