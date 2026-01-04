using System;
class Circle{
	float Radius;
	
	public Circle():this(0){}
	
	public Circle(float radius){
		Radius=radius;
	}
	
	public void Display(){
		Console.WriteLine(Radius);
	}
	
	
}

class CircleClass{
	static void Main(string[] args){
		Circle circle1=new Circle();
		Circle circle2=new Circle(7);	
		
		circle1.Display();
		circle2.Display();
	}
	
}