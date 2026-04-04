using System;
using System.Collections.Generic;

namespace CircularTourProblem
{
    class PetrolPump
    {
        public int Petrol;
        public int Distance;

        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
    }

    class Program
    {
        static int FindStartingPoint(PetrolPump[] pumps)
        {
            Queue<int> queue = new Queue<int>();
            int surplus = 0;
            int index = 0;

            while (queue.Count < pumps.Length)
            {
                surplus += pumps[index].Petrol - pumps[index].Distance;
                queue.Enqueue(index);

                while (surplus < 0 && queue.Count > 0)
                {
                    int removedIndex = queue.Dequeue();
                    surplus -= pumps[removedIndex].Petrol - pumps[removedIndex].Distance;
                }

                index = (index + 1) % pumps.Length;
            }

            return surplus >= 0 ? queue.Peek() : -1;
        }

        static void Main(string[] args)
        {
            PetrolPump[] pumps = {
                new PetrolPump(6, 4),
                new PetrolPump(3, 6),
                new PetrolPump(7, 3)
            };

            int start = FindStartingPoint(pumps);

            Console.WriteLine(start);
        }
    }
}
