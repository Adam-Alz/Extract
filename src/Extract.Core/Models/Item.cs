using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Extract.Core.Models
{
    public class Item
    {
        public Item(string id, string normalizedName, DateTime updated, int width, int height, string wikiLink, string iconLink, int lastLowPrice, int avg24hPrice, int changeLast48h,
            double changeLast48hPercent, int minLevelForFlea, List<TraderPrice> sellToTrader, string currency, List<ItemQuestRequirements> itemQuestRequirements, 
            List<HideoutRequirements> hideoutRequirements)
        {
            Id = id;
            NormalizedName = normalizedName;
            Updated = updated;
            Width = width;
            Height = height;
            WikiLink = wikiLink;
            IconLink = iconLink;
            LastLowPrice = lastLowPrice;
            Avg24hPrice = avg24hPrice;
            ChangeLast48h = changeLast48h;
            ChangeLast48hPercent = changeLast48hPercent;
            MinLevelForFlea = minLevelForFlea;
            SellToTrader = sellToTrader;
            Currency = currency;
            ItemQuestRequirements = itemQuestRequirements;
            HideoutRequirements = hideoutRequirements;
        }

        public string Id { get; set; } = string.Empty;
        public string NormalizedName { get; set; } = string.Empty;
        public DateTime? Updated { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? WikiLink { get; set; }
        public string? IconLink { get; set; }
        public int? LastLowPrice { get; set; }
        public int? Avg24hPrice { get; set; }
        public int? ChangeLast48h { get; set; }
        public double? ChangeLast48hPercent { get; set; }
        public int? MinLevelForFlea { get; set; }
        public List<TraderPrice> SellToTrader { get; set; } = new();
        public string Currency { get; set; } = "RUB";
        public List<ItemQuestRequirements> ItemQuestRequirements { get; set; } = new();
        public List<HideoutRequirements> HideoutRequirements { get; set; } = new();


    }
}
