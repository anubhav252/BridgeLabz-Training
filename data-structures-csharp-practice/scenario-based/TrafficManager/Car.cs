using System;

namespace TrafficManager
{
    class Car
    {
        public string NumberPlate { get; private set; }
        public Car Next { get; set; }

        public Car(string numberPlate)
        {
            NumberPlate = numberPlate;
        }
    }

    class QueueNode
    {
        public Car Data { get; set; }
        public QueueNode Next { get; set; }

        public QueueNode(Car data)
        {
            Data = data;
        }
    }

    class CustomQueue
    {
        private QueueNode front = null;
        private QueueNode rear = null;
        private int count = 0;
        private int maxSize = 5;

        public bool Enqueue(Car car)
        {
            if (count >= maxSize)
            {
                Console.WriteLine("Queue overflow: Cannot add more cars to waiting queue.");
                return false;
            }
            QueueNode newNode = new QueueNode(car);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            count++;
            return true;
        }

        public Car Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue underflow: No cars waiting to enter.");
                return null;
            }
            Car car = front.Data;
            front = front.Next;
            if (front == null) rear = null;
            count--;
            return car;
        }

        public int Count => count;

        public void Display()
        {
            Console.WriteLine("Waiting queue:");
            if (front == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            QueueNode current = front;
            while (current != null)
            {
                Console.WriteLine(current.Data.NumberPlate);
                current = current.Next;
            }
        }
    }

    class Roundabout
    {
        private Car head = null;
        private int count = 0;
        private int maxCars = 10; 

        public bool AddCar(Car car)
        {
            if (count >= maxCars)
            {
                Console.WriteLine("Roundabout full: Cannot add more cars.");
                return false;
            }
            if (head == null)
            {
                head = car;
                car.Next = car;
            }
            else
            {
                car.Next = head.Next;
                head.Next = car;
                head = car; 
            }
            count++;
            return true;
        }

        public bool RemoveCar(string plate)
        {
            if (head == null) return false;
            Car current = head;
            Car previous = null;
            do
            {
                if (current.NumberPlate == plate)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current == head) head = previous;
                    }
                    else
                    {
                        head = null; 
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            } while (current != head);
            return false;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }
            Car current = head;
            do
            {
                Console.WriteLine(current.NumberPlate);
                current = current.Next;
            } while (current != head);
        }
    }

    class TrafficManager
    {
        private CustomQueue waitingQueue = new CustomQueue();
        private Roundabout roundabout = new Roundabout();

        public void AddWaitingCar(string plate)
        {
            waitingQueue.Enqueue(new Car(plate));
        }

        public void EnterRoundabout()
        {
            Car car = waitingQueue.Dequeue();
            if (car != null)
            {
                roundabout.AddCar(car);
            }
        }

        public void RemoveFromRoundabout(string plate)
        {
            roundabout.RemoveCar(plate);
        }

        public void DisplayRoundabout()
        {
            Console.WriteLine("Roundabout state:");
            roundabout.Display();
        }

        public void DisplayQueue()
        {
            waitingQueue.Display();
        }
    }   
}


