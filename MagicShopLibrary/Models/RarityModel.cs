using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicShopLibrary.Models
{
    public class RarityModel
    {
        [JsonProperty("name")]
        private string NameString { get; set; }

        public Rarity Value
        {
            get 
            {
                switch (NameString)
                {
                    case "Common":
                        return Rarity.Common;
                    case "Uncommon":
                        return Rarity.Uncommon;
                    case "Rare":
                        return Rarity.Rare;
                    case "Very Rare":
                        return Rarity.VeryRare;
                    case "Legendary":
                        return Rarity.Legendary;
                    default:
                        return Rarity.Unknown;
                }
            }
            private set {  }
        }

    }
}
