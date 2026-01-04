using System;

class Animal{
    protected string Name;
    protected int Age;

    public Animal(string name, int age){
        Name = name;
        Age = age;
    }

    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound(){
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound(){
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound(){
        Console.WriteLine("Bird chirps");
    }
}

class AnimalHierarchy{
    static void Main(string[] args){
        Animal a1 = new Dog("Buddy", 3);
        Animal a2 = new Cat("Whiskers", 2);
        Animal a3 = new Bird("Tweety", 1);

        a1.MakeSound();
        a2.MakeSound();
        a3.MakeSound();
    }
}
