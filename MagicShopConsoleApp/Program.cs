using MagicShopLibrary;
using System;

namespace MagicShopConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MagicShop ms = new MagicShop();
            Console.WriteLine(ms.TESTGetAllItemTypes());
        }
    }
}
