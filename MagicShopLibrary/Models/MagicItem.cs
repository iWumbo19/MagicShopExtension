using Newtonsoft.Json;

namespace MagicShopLibrary.Models
{
    public class MagicItem
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("desc")]
        public string[] Description { get; set; }

        [JsonProperty("equipment_category")]
        public APIReference Category { get; set; }

        [JsonProperty("rarity")]
        public RarityModel Rarity { get; set; }

        [JsonProperty("varients")]
        public APIReference[] Varients { get; set; }

        [JsonProperty("varient")]
        public bool Varient { get; set; }

        public int Cost
        {
            get { return RNG.CostOfItem(Rarity.Value); }
            private set { }
        }

    }
}
