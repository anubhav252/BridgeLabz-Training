using System;
namespace FlashDealz
{
    class ProductMenu
    {
        public void Menu()
        {
            IProductOperation utility = new ProductUtilityImpl();
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Sort Products by Discount Percentage");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("-----------------------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.AddProduct();
                        break;
                    case 2:
                        utility.SortDiscountedProducts(0,utility.GetCount()-1);
                        if(utility.GetCount()>0)
                        {
                            Console.WriteLine("Products sorted by discount percentage in descending order.");
                        }
                        break;
                    case 3:
                        utility.DisplayProducts();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
