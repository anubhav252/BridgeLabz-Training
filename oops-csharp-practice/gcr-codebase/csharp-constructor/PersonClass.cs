using System;
class Person{
	string PersonName;
	int Age;
	public Person(string personName,int age){
		PersonName=personName;
		Age=age;
	}
	
	public Person(Person previousObject){
		PersonName=previousObject.PersonName;
		Age=previousObject.Age;
	} 
	
	public void DisplayDetails(){
		Console.WriteLine("Name : "+PersonName+"\nAge : "+Age);
	}
	
}

class PersonClas{
	static void Main(string[] args){
		Person person1=new Person("sam",20);
		Person person2=new Person(person1);
		
		person1.DisplayDetails();
		person2.DisplayDetails();
	}
}