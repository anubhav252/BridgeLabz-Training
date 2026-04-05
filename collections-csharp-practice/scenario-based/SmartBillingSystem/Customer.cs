using System.Collections.Generic;
namespace SuperMarket
{
    class Customer
    {
            public string Name { get; set; }
        public List<string> Items { get; set; }

        public Customer(string name, List<string> items)
        {
            Name = name;
            Items = items;
        }   
    }   
}