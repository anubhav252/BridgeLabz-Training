using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace FlashDealz
{
    class ProductUtilityImpl:IProductOperation
    {
        private Product[] products=new Product[100];
        private int count=0;
        public void AddProduct()
        {
            if (count >= 100)
            {
                Console.WriteLine("Storage full.");
                return;
            }
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter discount percentage:");
            double discount = Convert.ToDouble(Console.ReadLine());
            products[count] = new Product(name, price, discount);
            count++;
            Console.WriteLine("Product added successfully.");
        }
        public int GetCount()
        {
            return count;
        }
        public void SortDiscountedProducts(int low,int high)
        {
            if (count==0)
            {
                Console.WriteLine("No products! add products first");
                return;
            }
            if (low < high)
            {
                int pivotIndex = Partition(low, high);
                SortDiscountedProducts(low, pivotIndex - 1);
                SortDiscountedProducts(pivotIndex + 1, high);
            }
        }
        public int Partition(int low, int high)
        {
            double pivot = products[high].DiscountPercentage;
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (products[j].DiscountPercentage >= pivot)
                {
                    i++;
                    Product temp = products[i];
                    products[i] = products[j];
                    products[j] = temp;
                }
            }
            Product temp1 = products[i + 1];
            products[i + 1] = products[high];
            products[high] = temp1;
            return i + 1;
        }
        public void DisplayProducts()
        {
            if(count==0)
            {
                Console.WriteLine("No products to display.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
    }
}