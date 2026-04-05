using System;
using System.Collections.Generic;
namespace SuperMarket
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Item> inventory = new Dictionary<string, Item>()
                {
                { "Milk",  new Item(40, 20) },
                { "Bread", new Item(30, 15) },
                { "Rice",  new Item(60, 25) },
                { "Eggs",  new Item(6, 100) },
                { "Oil",   new Item(180, 10) }
                };

        
            Queue<Customer> checkoutQueue = new Queue<Customer>();

        
            checkoutQueue.Enqueue(new Customer("Amit",new List<string> { "Milk", "Bread", "Eggs" }));

            checkoutQueue.Enqueue(new Customer("Neha",new List<string> { "Rice", "Oil" }));

            checkoutQueue.Enqueue(new Customer("Ravi",new List<string> { "Milk", "Eggs", "Eggs" }));

        
            Console.WriteLine("SMART CHECKOUT BILLING SYSTEM\n");

            while (checkoutQueue.Count > 0)
            {
                Customer current = checkoutQueue.Dequeue();
                Console.WriteLine($"Customer: {current.Name}");
                double total = 0;
                foreach (string itemName in current.Items)
                {
                    if (inventory.ContainsKey(itemName))
                    {
                        Item item = inventory[itemName];

                        if (item.Stock > 0)
                        {
                            total += item.Price;
                            item.Stock--;

                            Console.WriteLine($"{itemName} - ₹{item.Price} (Stock left: {item.Stock})");
                        }
                        else
                        {
                            Console.WriteLine($"{itemName} - OUT OF STOCK");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{itemName} - ITEM NOT FOUND");
                    }
                }
                Console.WriteLine($"Total Bill: ₹{total}");
                Console.WriteLine("---------------------------------\n");
            }
            Console.WriteLine("All customers processed.");
        }
    }
}