using System;
namespace OnlineMarketplace
{
    abstract class Category
    {
        public string CategoryName;
        public double ProductPrice;
        public Category(string name,double price)
        {
            CategoryName = name;
            ProductPrice = price;
        }
        public abstract void DisplayProduct();

    }
    
    class BookCategory : Category
    {
        public string Bookname;
        public string BookGenre;
        public  BookCategory(string categoryName ,double bookPrice,string bookName,string genre) : base(categoryName,bookPrice)
        {
            Bookname = bookName;
            BookGenre = genre;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine($"Category: {CategoryName}, Book Name: {Bookname}, Genre: {BookGenre}, Price: {ProductPrice}");
        }
    }

    class ClothingCategory : Category
    {
        public string ClothingType;
        public string Size;
        public ClothingCategory(string categoryName,double ClothingPrice, string clothingType, string size) : base(categoryName,ClothingPrice)
        {
            ClothingType = clothingType;
            Size = size;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine($"Category: {CategoryName}, Clothing Type: {ClothingType}, Size: {Size}, Price: {ProductPrice}");
        }
    }
    class Product<T> where T: Category
    {
        public List<T> products=new List<T>();
        public void AddProduct(T product)
        {
            products.Add(product);
        }
        public void ApplyDiscount(T product,double discountPercentage)
        {
            product.ProductPrice -= product.ProductPrice * (discountPercentage / 100);
        }
        public void ShowProducts()
        {
            foreach(T product in products)
            {
                product.DisplayProduct();
            }  
        }      
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product<BookCategory> bookProduct = new Product<BookCategory>();
            BookCategory book1 = new BookCategory("Books", 20.0, "The Great Gatsby", "Fiction");
            bookProduct.AddProduct(book1);
            bookProduct.ApplyDiscount(book1, 10);
            bookProduct.ShowProducts();

            Product<ClothingCategory> clothingProduct = new Product<ClothingCategory>();
            ClothingCategory clothing1 = new ClothingCategory("Clothing", 50.0, "T-Shirt", "M");
            clothingProduct.AddProduct(clothing1);
            clothingProduct.ApplyDiscount(clothing1, 15);
            clothingProduct.ShowProducts();
        }
    }
}