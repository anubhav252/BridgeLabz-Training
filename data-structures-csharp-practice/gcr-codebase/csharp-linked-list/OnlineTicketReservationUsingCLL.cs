using System;

namespace OnlineTicketReservationUsingCLL
{
    class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;
        public TicketNode Next;

        public TicketNode(int id, string customer, string movie, string seat)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = DateTime.Now;
            Next = null;
        }
    }

    class TicketUtility
    {
        private TicketNode head;

        public void AddTicket(int id, string customer, string movie, string seat)
        {
            TicketNode newNode = new TicketNode(id, customer, movie, seat);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            TicketNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void RemoveTicket(int ticketId)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode current = head;
            TicketNode previous = null;

            do
            {
                if (current.TicketId == ticketId)
                {
                    if (current == head)
                    {
                        TicketNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }

                        if (head.Next == head)
                        {
                            head = null;
                        }
                        else
                        {
                            head = head.Next;
                            last.Next = head;
                        }
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    Console.WriteLine("Ticket removed successfully");
                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);

            Console.WriteLine("Ticket not found");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No booked tickets");
                return;
            }

            TicketNode temp = head;
            do
            {
                DisplayTicket(temp);
                temp = temp.Next;
            } while (temp != head);
        }

        public void SearchByCustomer(string customerName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            do
            {
                if (temp.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No ticket found for customer");
        }

        public void SearchByMovie(string movieName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            do
            {
                if (temp.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tickets found for this movie");
        }

        public int CountTickets()
        {
            if (head == null)
                return 0;

            int count = 0;
            TicketNode temp = head;

            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }

        private void DisplayTicket(TicketNode ticket)
        {
            Console.WriteLine("Ticket ID: " + ticket.TicketId +", Customer: " + ticket.CustomerName +", Movie: " + ticket.MovieName +", Seat: " + ticket.SeatNumber +", Time: " + ticket.BookingTime.ToShortTimeString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TicketUtility reservationSystem = new TicketUtility();

            reservationSystem.AddTicket(1, "Alice", "Inception", "A1");
            reservationSystem.AddTicket(2, "Bob", "Inception", "A2");
            reservationSystem.AddTicket(3, "Charlie", "Interstellar", "B1");

            Console.WriteLine("All Tickets:");
            reservationSystem.DisplayTickets();

            Console.WriteLine("\nSearch by Customer:");
            reservationSystem.SearchByCustomer("Alice");

            Console.WriteLine("\nSearch by Movie:");
            reservationSystem.SearchByMovie("Inception");

            Console.WriteLine("\nTotal Tickets: " + reservationSystem.CountTickets());

            Console.WriteLine("\nRemove Ticket:");
            reservationSystem.RemoveTicket(2);

            Console.WriteLine("\nFinal Ticket List:");
            reservationSystem.DisplayTickets();
        }
    }
}
