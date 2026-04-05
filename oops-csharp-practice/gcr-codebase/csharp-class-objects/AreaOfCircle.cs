using System;
class Circle{
	private float Radius;
	
	public Circle(float radius){
		this.Radius=radius;
	}
	
	public double CalculateArea(){
		double areaOfCircle=3.14*Math.Pow(Radius,2);
		return areaOfCircle;
	}
	
	public double CalculateCircumference(){
		double circumference=2*3.14*Radius;
		return circumference;
	}
	
	public void DisplayAreaAndCircumference(){
		Console.WriteLine("area of circle with radius "+Radius +" is : "
		+CalculateArea()+" and circumference is : "+CalculateCircumference());
	}
}

class AreaOfCircle{
	static void Main(string[] args){
		Console.WriteLine("enter the radius : ");
		float radius=float.Parse(Console.ReadLine());
		
		Circle obj=new Circle(radius);
		obj.DisplayAreaAndCircumference();
	}
}