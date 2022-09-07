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
        internal static MagicItem[] GetRandomItems(MagicItem[] items, ShopSize size)
        {
            int count = ShopSizeToItemCount(size);
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
        private static int ShopSizeToItemCount(ShopSize size)
        {
            switch (size)
            {
                case ShopSize.Hamlet:
                    return rng.Next(2, 6);
                case ShopSize.Village:
                    return rng.Next(3, 7);
                case ShopSize.SmallTown:
                    return rng.Next(4, 8);
                case ShopSize.LargeTown:
                    return rng.Next(5, 9);
                case ShopSize.SmallCity:
                    return rng.Next(6, 10);
                case ShopSize.LargeCity:
                    return rng.Next(7, 11);
                case ShopSize.Metropolis:
                    return rng.Next(8, 12);
                default:
                    throw new Exception("Did not recognize passed in ShopSize");
            }
        }
        internal static int CostOfItem(Rarity rarity)
        {
            switch (rarity)
            {
                case Rarity.Unknown:
                    return rng.Next(50, 101);
                case Rarity.Common:
                    return rng.Next(100, 500);
                case Rarity.Uncommon:
                    return rng.Next(500, 1000);
                case Rarity.Rare:
                    return rng.Next(500, 5001);
                case Rarity.VeryRare:
                    return rng.Next(5000, 50001);
                case Rarity.Legendary:
                    return rng.Next(50000, 100000);
                default:
                    throw new Exception("Didn't Recognize passed in rarity");
            }
        }
    }
}
