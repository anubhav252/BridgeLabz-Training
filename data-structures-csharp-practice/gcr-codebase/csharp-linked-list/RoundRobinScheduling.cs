using System;

namespace RoundRobinScheduling
{
   class ProcessNode
   {
       public int ProcessId;
       public int BurstTime;
       public int RemainingTime;
       public int Priority;
       public int WaitingTime;
       public int TurnAroundTime;
       public ProcessNode Next;

       public ProcessNode(int id, int burst, int priority)
       {
           ProcessId = id;
           BurstTime = burst;
           RemainingTime = burst;
           Priority = priority;
           WaitingTime = 0;
           TurnAroundTime = 0;
           Next = null;
       }
   }

   class RoundRobinSchedulerUtility
   {
       private ProcessNode head;
       private int processCount;

       public void AddProcess(int id, int burstTime, int priority)
       {
           ProcessNode newNode = new ProcessNode(id, burstTime, priority);

           if (head == null)
           {
               head = newNode;
               newNode.Next = head;
           }
           else
           {
               ProcessNode temp = head;
               while (temp.Next != head)
               {
                   temp = temp.Next;
               }
               temp.Next = newNode;
               newNode.Next = head;
           }
           processCount++;
       }

       public void SimulateScheduling(int timeQuantum)
       {
           if (head == null)
           {
               Console.WriteLine("No processes to schedule");
               return;
           }

           int currentTime = 0;
           ProcessNode current = head;

           Console.WriteLine("\n--- Round Robin Scheduling ---");

           while (processCount > 0)
           {
               DisplayProcesses();

               if (current.RemainingTime > 0)
               {
                   int executionTime = Math.Min(timeQuantum, current.RemainingTime);
                   current.RemainingTime -= executionTime;
                   currentTime += executionTime;

                   ProcessNode temp = head;
                   do
                   {
                       if (temp != current && temp.RemainingTime > 0)
                       {
                           temp.WaitingTime += executionTime;
                       }
                       temp = temp.Next;
                   } while (temp != head);

                   if (current.RemainingTime == 0)
                   {
                       current.TurnAroundTime = currentTime;
                       RemoveProcess(current.ProcessId);
                   }
               }

               current = current.Next;
           }

           CalculateAverages();
       }

       private void RemoveProcess(int id)
       {
           if (head == null)
               return;

           ProcessNode temp = head;
           ProcessNode prev = null;

           do
           {
               if (temp.ProcessId == id)
               {
                   if (temp == head && temp.Next == head)
                   {
                       head = null;
                   }
                   else
                   {
                       if (temp == head)
                       {
                           ProcessNode last = head;
                           while (last.Next != head)
                               last = last.Next;
                           head = head.Next;
                           last.Next = head;
                       }
                       else
                       {
                           prev.Next = temp.Next;
                       }
                   }
                   processCount--;
                   return;
               }
               prev = temp;
               temp = temp.Next;
           } while (temp != head);
       }

       private void DisplayProcesses()
       {
           if (head == null)
           {
               Console.WriteLine("Process queue empty");
               return;
           }

           Console.Write("Queue: ");
           ProcessNode temp = head;
           do
           {
               Console.Write("[P" + temp.ProcessId + " RT:" + temp.RemainingTime + "] ");
               temp = temp.Next;
           } while (temp != head);
           Console.WriteLine();
       }

       private void CalculateAverages()
       {
           double totalWaitingTime = 0;
           double totalTurnAroundTime = 0;

           Console.WriteLine("\n--- Process Summary ---");

           ProcessNode temp = head;
           if (temp == null)
           {
               Console.WriteLine("All processes completed");
               return;
           }

           do
           {
               totalWaitingTime += temp.WaitingTime;
               totalTurnAroundTime += temp.TurnAroundTime;

               Console.WriteLine("Process P" + temp.ProcessId +" | Waiting Time: " + temp.WaitingTime +" | Turnaround Time: " + temp.TurnAroundTime);

               temp = temp.Next;
           } while (temp != head);

           Console.WriteLine("\nAverage Waiting Time: " +
               (totalWaitingTime / (totalWaitingTime + totalTurnAroundTime > 0 ? processCount + 1 : 1)));

           Console.WriteLine("Average Turnaround Time: " +
               (totalTurnAroundTime / (totalWaitingTime + totalTurnAroundTime > 0 ? processCount + 1 : 1)));
       }
   }

   class Program
   {
       static void Main(string[] args)
       {
           RoundRobinSchedulerUtility scheduler = new RoundRobinSchedulerUtility();

           scheduler.AddProcess(1, 10, 1);
           scheduler.AddProcess(2, 5, 2);
           scheduler.AddProcess(3, 8, 1);

           int timeQuantum = 3;
           scheduler.SimulateScheduling(timeQuantum);

       }
   }
}
