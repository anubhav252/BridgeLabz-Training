using System;

class HospitalUnit
{
    public string Name;
    public bool Available;
    public HospitalUnit Next;

    public HospitalUnit(string name, bool available = true)
    {
        Name = name;
        Available = available;
        Next = null;
    }
}

class AmbulanceRoute
{
    private HospitalUnit head;

    public void AddUnit(string name, bool available = true)
    {
        HospitalUnit newUnit = new HospitalUnit(name, available);

        if (head == null)
        {
            head = newUnit;
            newUnit.Next = head;
            return;
        }

        HospitalUnit temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newUnit;
        newUnit.Next = head;
    }

    public void RemoveUnit(string name)
    {
        if (head == null)
            return;

        HospitalUnit current = head;
        HospitalUnit previous = null;

        do
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                if (current == head)
                {
                    HospitalUnit last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    previous.Next = current.Next;
                }

                Console.WriteLine(name + " is under maintenance and removed.");
                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);
    }

    public void RedirectPatient()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available.");
            return;
        }

        HospitalUnit temp = head;

        do
        {
            Console.WriteLine("Checking " + temp.Name);

            if (temp.Available)
            {
                Console.WriteLine("Patient redirected to: " + temp.Name);
                return;
            }

            temp = temp.Next;

        } while (temp != head);

        Console.WriteLine("All units are currently unavailable.");
    }

    public void DisplayRoute()
    {
        if (head == null)
            return;

        HospitalUnit temp = head;

        Console.Write("\nHospital Route: ");
        do
        {
            Console.Write(temp.Name + " → ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("(back to Emergency)");
    }
}

class Program
{
    static void Main()
    {
        AmbulanceRoute route = new AmbulanceRoute();

        route.AddUnit("Emergency");
        route.AddUnit("Radiology", false);
        route.AddUnit("Surgery", false);
        route.AddUnit("ICU");

        route.DisplayRoute();

        Console.WriteLine("\nAmbulance arriving...\n");
        route.RedirectPatient();

        route.RemoveUnit("Radiology");

        route.DisplayRoute();

        Console.WriteLine("\nAnother patient arriving...\n");
        route.RedirectPatient();
    }
}
