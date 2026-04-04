using System;
class HotelBooking{
    private string guestName;
    private string roomType;
    private int nights;

    public HotelBooking(){
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights){
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelBooking(HotelBooking other){
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void DisplayDetails(){
        Console.WriteLine("Guest Name : " + guestName);
        Console.WriteLine("Room Type  : " + roomType);
        Console.WriteLine("Nights     : " + nights);
    }
}

class TestHotelBooking
{
    static void Main(string[] args)
    {
        HotelBooking booking1 = new HotelBooking();
		HotelBooking booking2 = new HotelBooking("Anubhav", "Deluxe", 3);
		HotelBooking booking3 = new HotelBooking(booking2);
        booking1.DisplayDetails();
        booking2.DisplayDetails();
        booking3.DisplayDetails();
    }
}
