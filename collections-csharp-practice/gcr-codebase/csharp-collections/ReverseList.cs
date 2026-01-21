using System;
using System.Collections;
class ReverseList{
    public void ReverseArrayList(ArrayList list1)
    {
        int left=0;
        int right=list1.Count-1;
        while (left < right)
        {
            int temp=(int)list1[left];
            list1[left]=list1[right];
            list1[right]=temp;

            left++;
            right--;

        }
        foreach(int i in list1)
        {
            System.Console.Write(i+" ");
        }
    }
    public void ReverseLinkedList(LinkedList<int> list2)
    {
        LinkedList<int> reversed = new LinkedList<int>();

        foreach (int item in list2)
        {
            reversed.AddFirst(item);
        }
        System.Console.WriteLine();
        foreach(int i in reversed)
        {
            System.Console.Write(i+" ");
        }
        
    }
    static void Main(string[] args)
    {
        ReverseList perform=new ReverseList();
        ArrayList list1=new ArrayList(){1,2,3,4,5};
        LinkedList<int> list2=new LinkedList<int>();
        list2.AddLast(2);
        list2.AddLast(3);
        list2.AddLast(4);
        list2.AddLast(5);
        list2.AddLast(6);
        perform.ReverseArrayList(list1);
        perform.ReverseLinkedList(list2);
    }
}