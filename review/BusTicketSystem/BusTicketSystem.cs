using System;

class BusTicketSystem{
    private static int noOfSeats = 30;
    private static double ticketPrice = 150.00;
    private int seatsBooked = 0;
	

    public bool BookTicket(int count){
        if (count <= noOfSeats){
            seatsBooked = count;
            noOfSeats -= count;
            return true;
        }
        return false;
    }

    public void CalculateBill(){
        double totalBill = seatsBooked * ticketPrice;
        Console.WriteLine("Total Bill: " + totalBill);
    }

    public void RemainingSeats(){
        Console.WriteLine("Remaining Seats: " + noOfSeats);
    }
}


class User{
    static void Main(string[] args){
        User user = new User();
        user.Menu();
    }

    public void Menu(){
        BusTicketSystem bus = new BusTicketSystem();
        bool isBooked = false;
        Console.WriteLine("Welcome to GoBus.com");
        while (true){
            Console.WriteLine("Enter your choice : \n1. To book tickets : \n2. to get Bill : \n3.to Check Remaining Seats \n4. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:{
                    Console.Write("Enter number of tickets: ");
                    int count = int.Parse(Console.ReadLine());

                    if (bus.BookTicket(count)){
                        Console.WriteLine("Tickets booked successfully!");
                        isBooked = true;
                    }
                    else{
                        Console.WriteLine("Not enough seats available! --- enter again");
                    }
                    break;
				}

                case 2:{
                    if (isBooked)
                        bus.CalculateBill();
                    else
                        Console.WriteLine("Please book tickets first!");
                    break;
				}

                case 3:{
                    bus.RemainingSeats();
                    break;
				}

                case 4:{
                    return;
				}

                default:{
                    Console.WriteLine("Invalid choice! ---- enter again");
                    break;
				}
            }
        }
    }
}
