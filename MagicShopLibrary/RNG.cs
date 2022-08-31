using MagicShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary
{
    internal static class RNG
    {
        private readonly static Random rng = new Random();
        internal static MagicItem GetRandomItem(MagicItem[] items) => items[rng.Next(items.Length)];
        internal static MagicItem GetRandomItem(List<MagicItem> items, int count) => items[rng.Next(items.Count)];
        internal static MagicItem[] GetRandomItems(MagicItem[] items, int count)
        {
            MagicItem[] output = new MagicItem[count];
            List<int> indexUsed = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(items.Length);
                while (indexUsed.Contains(index))
                {
                    index = rng.Next(items.Length);
                }
                output[i] = items[index];
                indexUsed.Add(index);
            }
            return output;
        }
        internal static MagicItem[] GetRandomItems(List<MagicItem> items, int count)
        {
            MagicItem[] output = new MagicItem[count];
            List<int> indexUsed = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int index = rng.Next(items.Count);
                while (indexUsed.Contains(index))
                {
                    index = rng.Next(items.Count);
                }
                output[i] = items[index];
                indexUsed.Add(index);
            }
            return output;
        }
    }
}
