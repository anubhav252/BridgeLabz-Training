using System;

interface Worker{
    void PerformDuties();
}

class Person{
    protected string Name;
    protected int Id;

    public Person(string name, int id){
        Name = name;
        Id = id;
    }

    public void DisplayPersonDetails(){
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("ID   : " + Id);
    }
}

class Chef : Person, Worker{
    public Chef(string name, int id) : base(name, id) { }

    public void PerformDuties(){
        Console.WriteLine("Chef Duties : Preparing and cooking food");
    }

    public void DisplayRole(){
        Console.WriteLine("Role : Chef");
        DisplayPersonDetails();
        PerformDuties();
        Console.WriteLine("--------------------------");
    }
}

class Waiter : Person, Worker{
    public Waiter(string name, int id) : base(name, id) { }

    public void PerformDuties(){
        Console.WriteLine("Waiter Duties : Serving food to customers");
    }

    public void DisplayRole(){
        Console.WriteLine("Role : Waiter");
        DisplayPersonDetails();
        PerformDuties();
        Console.WriteLine("--------------------------");
    }
}

class RestaurantManagementSystem{
    static void Main(string[] args){
        Chef chef = new Chef("Anubhav", 101);
        Waiter waiter = new Waiter("Rohit", 102);

        chef.DisplayRole();
        waiter.DisplayRole();
    }
}
