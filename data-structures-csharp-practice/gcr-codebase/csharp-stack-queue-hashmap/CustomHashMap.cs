using System;

namespace CustomHashMapImplementation
{
    class HashNode
    {
        public int Key;
        public int Value;
        public HashNode Next;

        public HashNode(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    class CustomHashMap
    {
        private readonly int capacity;
        private HashNode[] table;

        public CustomHashMap(int size)
        {
            capacity = size;
            table = new HashNode[capacity];
        }

        private int GetIndex(int key)
        {
            return Math.Abs(key) % capacity;
        }

        public void Put(int key, int value)
        {
            int index = GetIndex(key);
            HashNode head = table[index];

            HashNode current = head;
            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;
                    return;
                }
                current = current.Next;
            }

            HashNode newNode = new HashNode(key, value);
            newNode.Next = head;
            table[index] = newNode;
        }

        public int Get(int key)
        {
            int index = GetIndex(key);
            HashNode current = table[index];

            while (current != null)
            {
                if (current.Key == key)
                    return current.Value;
                current = current.Next;
            }

            return 0;
        }

        public bool Remove(int key)
        {
            int index = GetIndex(key);
            HashNode current = table[index];
            HashNode previous = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (previous == null)
                        table[index] = current.Next;
                    else
                        previous.Next = current.Next;

                    return true;
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void Display()
        {
            for (int i = 0; i < capacity; i++)
            {
                HashNode current = table[i];
                Console.Write($"Index {i}: ");
                while (current != null)
                {
                    Console.Write($"[{current.Key}:{current.Value}] ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomHashMap map = new CustomHashMap(5);

            map.Put(1, 100);
            map.Put(6, 600);
            map.Put(11, 1100);
            map.Put(2, 200);

            Console.WriteLine(map.Get(6));
            Console.WriteLine(map.Get(3));

            map.Remove(6);

            Console.WriteLine(map.Get(6));

            map.Display();
        }
    }
}
