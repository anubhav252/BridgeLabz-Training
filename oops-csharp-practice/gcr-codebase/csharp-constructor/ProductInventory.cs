using System;
class Product{
	string productName;
	double price;
	static int totalProducts;
	
	public Product(string productName,double price){
		this.productName=productName;
		this.price=price;
		totalProducts++;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("Product name : "+productName+"\nPrice : "+price);
	}
	
	public static void DisplayTotalProducts(){
		Console.WriteLine("Total Products : "+totalProducts);
	}
}

class ProductInventory{
	static void Main(string[] args){
		Product product1=new Product("shoes",2999.0);
		Product product2=new Product("samsung machine",12000.0);
		product1.DisplayDetails();
		product2.DisplayDetails();
		Product.DisplayTotalProducts();
	}
}