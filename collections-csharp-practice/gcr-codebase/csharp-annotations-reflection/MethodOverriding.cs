using System;
class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("makes sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("dogs barks");
    }
}
class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.MakeSound();
    }
}