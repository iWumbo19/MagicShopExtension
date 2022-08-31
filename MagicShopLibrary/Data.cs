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

        internal static MagicItem[] GetItems(Rarity rarity) => FullList.Items.Where(x => x.Rarity.Value == rarity).ToArray();
        internal static MagicItem[] GetItems(ItemType type) => FullList.Items.Where(x => Utilities.StringToItemType(x.Category.Name) == type).ToArray();
        internal static MagicItem[] GetItems(ItemType type, Rarity rarity) => FullList.Items.Where(x => Utilities.StringToItemType(x.Category.Name) == type && x.Rarity.Value == rarity).ToArray();
        internal static MagicItemList ConvertToMagicItemList(MagicItem[] items) => new MagicItemList(items);
        internal static MagicItemList ConvertToMagicItemList(List<MagicItem> items) => new MagicItemList(items);
        internal static void Initialize()
        {
            FullList = JsonConvert.DeserializeObject<MagicItemList>(File.ReadAllText(@"magicshop.json"));
        }
        
    }
}
