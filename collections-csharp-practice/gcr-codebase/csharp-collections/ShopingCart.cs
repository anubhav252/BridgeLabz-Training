using System;
using System.Collections.Generic;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();
        List<string> order = new List<string>();
        SortedDictionary<double, List<string>> sortedByPrice =new SortedDictionary<double, List<string>>();

        AddItem("Laptop", 80000, cart, order);
        AddItem("Mouse", 800, cart, order);
        AddItem("Keyboard", 1500, cart, order);
        AddItem("Monitor", 12000, cart, order);
        AddItem("Mouse", 800, cart, order);

        Console.WriteLine("Insertion Order:");
        foreach (string item in order)
            Console.WriteLine(item + " : " + cart[item]);

        foreach (var item in cart)
        {
            if (!sortedByPrice.ContainsKey(item.Value))
                sortedByPrice[item.Value] = new List<string>();

            sortedByPrice[item.Value].Add(item.Key);
        }

        Console.WriteLine("\nSorted By Price:");
        foreach (var entry in sortedByPrice)
        {
            foreach (string product in entry.Value)
                Console.WriteLine(product + " : " + entry.Key);
        }
    }

    static void AddItem(string product,double price,Dictionary<string, double> cart,List<string> order)
    {
        if (!cart.ContainsKey(product))
        {
            cart[product] = price;
            order.Add(product);
        }
    }
}
