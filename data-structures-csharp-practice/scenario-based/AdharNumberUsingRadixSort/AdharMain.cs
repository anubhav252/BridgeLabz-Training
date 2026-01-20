using System;
using System.ComponentModel.Design;
namespace AdharNoRadixSort
{
    class AdharMain
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            IOperations utility=new Utility();
            while(true)
            {
                Console.WriteLine("1. Add Adhar Number");
                Console.WriteLine("2. Display Sorted Adhar Numbers");
                Console.WriteLine("3. Search Adhar Number");
                System.Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        utility.AddAdharNumber();
                        break;
                    case 2:
                        utility.DisplaySortedAdharNumbers();
                        break;
                    case 3:
                        utility.SearchNumber();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}