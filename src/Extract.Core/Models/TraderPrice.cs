using System;
using System.Collections.Generic;
using System.Text;

namespace Extract.Core.Models
{
    public class TraderPrice
    {
        public TraderPrice(string trader, int price, int priceRUB, string currency)
        {
            Trader = trader;
            Price = price;
            PriceRUB = priceRUB;
            Currency = currency;
        }

        public string Trader { get; set; } = string.Empty;
        public int Price { get; set; }
        public int PriceRUB {  get; set; }
        public string Currency { get; set; } = "RUB";

    }
}
