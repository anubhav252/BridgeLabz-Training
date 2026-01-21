using System;
namespace SuperMarket
{
    class Item
    {
        public double Price { get; set; }
        public int Stock { get; set; }

        public Item(double price, int stock)
        {
            Price = price;
            Stock = stock;
        }
    }

    
}