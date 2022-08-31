using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicShopLibrary.Models
{
    public class MagicItemList
    {
        public MagicItemList() { }

        public MagicItemList(MagicItem[] items)
        {
            Count = items.Length;
            Items = items;
        }
        public MagicItemList(List<MagicItem> items)
        {
            Count = items.Count;
            Items = Items.ToArray();
        }

        public int Count { get; set; }
        public MagicItem[] Items { get; set; }

    }
}
