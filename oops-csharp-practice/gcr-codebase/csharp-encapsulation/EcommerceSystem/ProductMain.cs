using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Platform
{
    internal class ProductMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of products: ");
            int size = int.Parse(Console.ReadLine());

            Product[] products = new Product[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\nChoose Product Type:");
                Console.WriteLine("1. Electronics");
                Console.WriteLine("2. Clothing");
                Console.WriteLine("3. Groceries");

                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        products[i] = new Electronics();
                        products[i].ProductId = id;
                        products[i].ProductPrice= price;
                        products[i].ProductName = name;
                        break;

                    case 2:
                        products[i] = new Clothing();
                        products[i].ProductId = id;
                        products[i].ProductPrice = price;
                        products[i].ProductName = name;

                        break;

                    case 3:
                        products[i] = new Groceries();
                        products[i].ProductId = id;
                        products[i].ProductPrice = price;
                        products[i].ProductName = name;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        i--;
                        break;
                }
            }

            Console.WriteLine("\n----- FINAL BILL DETAILS -----\n");
            CalculateFinalPrice(products);
        }

        static void CalculateFinalPrice(Product[] products)
        {
            foreach (Product product in products)
            {
                double tax = 0;

                if (product is ITaxable taxable)
                {
                    tax = taxable.CalculateTax();
                    Console.WriteLine(taxable.GetTaxDetails());
                }

                double discount = product.CalculateDiscount();
                double finalPrice = product.ProductPrice + tax - discount;

                Console.WriteLine(product);
                Console.WriteLine("Discount   : " + discount);
                Console.WriteLine("Tax        : " + tax);
                Console.WriteLine("Final Price: " + finalPrice);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
