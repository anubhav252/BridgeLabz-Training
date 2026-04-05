using System;
namespace WarehouseSystem
{
    abstract class WarehouseItem
    {
        public string ItemName;
        public int Quantity;
        public WarehouseItem(string itemName,int quantity)
        {
            ItemName=itemName;
            Quantity=quantity;
        }
        public abstract void DisplayInfo();
    }

    class Electronics : WarehouseItem
    {
        public Electronics(string itemName, int quantity) : base(itemName, quantity)
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Electronics Item: {ItemName}, Quantity: {Quantity}");
        }
    }

    class Furniture : WarehouseItem
    {
        public Furniture(string itemName, int quantity) : base(itemName, quantity)
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Furniture Item: {ItemName}, Quantity: {Quantity}");
        }
    }
    class Groceries : WarehouseItem
    {
        public Groceries(string itemName, int quantity) : base(itemName, quantity)
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Grocery Item: {ItemName}, Quantity: {Quantity}");
        }
    }

    class Storage<T> where T : WarehouseItem
    {
        private List<T> items=new List<T>();
        public void AddItem(T item)
        {
            items.Add(item);
        }
        public void DisplayAllItems()
        {
            foreach(T item in items)
            {
                item.DisplayInfo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Storage<Electronics> electronicsStorage=new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics("Laptop", 10));
            electronicsStorage.AddItem(new Electronics("Smartphone", 20));

            Storage<Furniture> furnitureStorage=new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Chair", 15));
            furnitureStorage.AddItem(new Furniture("Table", 5));

            Storage<Groceries> groceryStorage=new Storage<Groceries>();
            groceryStorage.AddItem(new Groceries("Apples", 50));
            groceryStorage.AddItem(new Groceries("Bananas", 30));

            Console.WriteLine("Electronics in Storage:");
            electronicsStorage.DisplayAllItems();

            Console.WriteLine("\nFurniture in Storage:");
            furnitureStorage.DisplayAllItems();

            Console.WriteLine("\nGroceries in Storage:");
            groceryStorage.DisplayAllItems();
        }
    }
}