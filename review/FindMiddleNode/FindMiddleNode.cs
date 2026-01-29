//find the middle node using recursion 
//values by user input
using System;
namespace MiddleNode
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data){
            Data =data;
            Next=null;
        }
    }

    class LinkedListUtil
    {
        private Node head;
        public void AddNode(int data)
        {
            Node newInput=new Node(data);
            if (head == null)
            {
                head=newInput;
                return;
            }
            Node temp=head;
            while (temp.Next!= null)
            {
                temp=temp.Next;
            }
            temp.Next=newInput;
        }
        public Node FindMiddle()
        {
            return FindMiddleRecursive(head, head);
        }
        private Node FindMiddleRecursive(Node slow, Node fast)
        {
            if (fast == null || fast.Next == null)
                return slow;

            return FindMiddleRecursive(slow.Next, fast.Next.Next);
        }
    }
    class MiddleNodeMain
    {
        static void Main(string[] args)
        {
            LinkedListUtil obj=new LinkedListUtil();
            System.Console.WriteLine("enter size of the list ----- ");
            int size=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Values for the list ------");
            for(int i = 0; i < size; i++)
            {
                int input=int.Parse(Console.ReadLine());
                obj.AddNode(input);
            }
            System.Console.WriteLine($"Middle Node : {obj.FindMiddle().Data}");
        }
    }
}