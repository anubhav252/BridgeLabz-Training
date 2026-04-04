using System;

namespace InventoryManagementUsingSLL
{
   class InventoryNode
   {
       public int ItemId;
       public string ItemName;
       public int Quantity;
       public double Price;
       public InventoryNode Next;

       public InventoryNode(int id, string name, int quantity, double price)
       {
           ItemId = id;
           ItemName = name;
           Quantity = quantity;
           Price = price;
           Next = null;
       }
   }

   class InventoryUtility
   {
       private InventoryNode head;

       public void AddAtBeginning(int id, string name, int quantity, double price)
       {
           InventoryNode newNode = new InventoryNode(id, name, quantity, price);
           newNode.Next = head;
           head = newNode;
       }

       public void AddAtEnd(int id, string name, int quantity, double price)
       {
           InventoryNode newNode = new InventoryNode(id, name, quantity, price);

           if (head == null)
           {
               head = newNode;
               return;
           }

           InventoryNode temp = head;
           while (temp.Next != null)
           {
               temp = temp.Next;
           }
           temp.Next = newNode;
       }

       public void AddAtPosition(int id, string name, int quantity, double price, int position)
       {
           if (position <= 1)
           {
               AddAtBeginning(id, name, quantity, price);
               return;
           }

           InventoryNode temp = head;
           for (int i = 1; i < position - 1 && temp != null; i++)
           {
               temp = temp.Next;
           }

           if (temp == null)
           {
               Console.WriteLine("Invalid position");
               return;
           }

           InventoryNode newNode = new InventoryNode(id, name, quantity, price);
           newNode.Next = temp.Next;
           temp.Next = newNode;
       }

       public void RemoveByItemId(int id)
       {
           if (head == null)
           {
               Console.WriteLine("Inventory is empty");
               return;
           }

           if (head.ItemId == id)
           {
               head = head.Next;
               Console.WriteLine("Item removed");
               return;
           }

           InventoryNode temp = head;
           while (temp.Next != null && temp.Next.ItemId != id)
           {
               temp = temp.Next;
           }

           if (temp.Next == null)
           {
               Console.WriteLine("Item not found");
           }
           else
           {
               temp.Next = temp.Next.Next;
               Console.WriteLine("Item removed");
           }
       }

       public void UpdateQuantity(int id, int newQuantity)
       {
           InventoryNode temp = head;

           while (temp != null)
           {
               if (temp.ItemId == id)
               {
                   temp.Quantity = newQuantity;
                   Console.WriteLine("Quantity updated");
                   return;
               }
               temp = temp.Next;
           }

           Console.WriteLine("Item not found");
       }

       public void SearchByItemId(int id)
       {
           InventoryNode temp = head;

           while (temp != null)
           {
               if (temp.ItemId == id)
               {
                   DisplayItem(temp);
                   return;
               }
               temp = temp.Next;
           }

           Console.WriteLine("Item not found");
       }

       public void SearchByItemName(string name)
       {
           InventoryNode temp = head;
           bool found = false;

           while (temp != null)
           {
               if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
               {
                   DisplayItem(temp);
                   found = true;
               }
               temp = temp.Next;
           }

           if (!found)
               Console.WriteLine("Item not found");
       }

       public void DisplayTotalInventoryValue()
       {
           double totalValue = 0;
           InventoryNode temp = head;

           while (temp != null)
           {
               totalValue += temp.Price * temp.Quantity;
               temp = temp.Next;
           }

           Console.WriteLine("Total Inventory Value: " + totalValue);
       }

       public void SortByName(bool ascending)
       {
           for (InventoryNode i = head; i != null; i = i.Next)
           {
               for (InventoryNode j = i.Next; j != null; j = j.Next)
               {
                   if ((ascending && string.Compare(i.ItemName, j.ItemName) > 0) ||
                       (!ascending && string.Compare(i.ItemName, j.ItemName) < 0))
                   {
                       SwapData(i, j);
                   }
               }
           }
       }

       public void SortByPrice(bool ascending)
       {
           for (InventoryNode i = head; i != null; i = i.Next)
           {
               for (InventoryNode j = i.Next; j != null; j = j.Next)
               {
                   if ((ascending && i.Price > j.Price) ||
                       (!ascending && i.Price < j.Price))
                   {
                       SwapData(i, j);
                   }
               }
           }
       }

       private void SwapData(InventoryNode a, InventoryNode b)
       {
           int tempId = a.ItemId;
           string tempName = a.ItemName;
           int tempQty = a.Quantity;
           double tempPrice = a.Price;

           a.ItemId = b.ItemId;
           a.ItemName = b.ItemName;
           a.Quantity = b.Quantity;
           a.Price = b.Price;

           b.ItemId = tempId;
           b.ItemName = tempName;
           b.Quantity = tempQty;
           b.Price = tempPrice;
       }

       public void DisplayAll()
       {
           if (head == null)
           {
               Console.WriteLine("No inventory items");
               return;
           }

           InventoryNode temp = head;
           while (temp != null)
           {
               DisplayItem(temp);
               temp = temp.Next;
           }
       }

       private void DisplayItem(InventoryNode item)
       {
           Console.WriteLine(
               "Item ID: " + item.ItemId +
               ", Name: " + item.ItemName +
               ", Quantity: " + item.Quantity +
               ", Price: " + item.Price
           );
       }
   }

   class InventoryMain
   {
       static void Main(string[] args)
       {
           InventoryUtility inventory = new InventoryUtility();

           inventory.AddAtEnd(101, "Keyboard", 10, 500);
           inventory.AddAtEnd(102, "Mouse", 20, 300);
           inventory.AddAtBeginning(103, "Monitor", 5, 8000);
           inventory.AddAtPosition(104, "Printer", 2, 12000, 2);

           Console.WriteLine("Inventory List:");
           inventory.DisplayAll();

           Console.WriteLine("\nSearch by Item ID:");
           inventory.SearchByItemId(102);

           Console.WriteLine("\nUpdate Quantity:");
           inventory.UpdateQuantity(101, 15);

           Console.WriteLine("\nTotal Inventory Value:");
           inventory.DisplayTotalInventoryValue();

           Console.WriteLine("\nSort by Name (Ascending):");
           inventory.SortByName(true);
           inventory.DisplayAll();

           Console.WriteLine("\nSort by Price (Descending):");
           inventory.SortByPrice(false);
           inventory.DisplayAll();
       }
   }
}
