using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskSchedulerCircularList
{
    class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int id, string name, int priority, DateTime dueDate)
        {
            TaskId = id;
            TaskName = name;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }

    class TaskSchedulerUtility
    {
        private TaskNode head;
        private TaskNode current;

        public void AddAtBeginning(int id, string name, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }

        public void AddAtEnd(int id, string name, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void AddAtPosition(int id, string name, int priority, DateTime dueDate, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(id, name, priority, dueDate);
                return;
            }

            TaskNode temp = head;
            for (int i = 1; i < position - 1 && temp.Next != head; i++)
            {
                temp = temp.Next;
            }

            TaskNode newNode = new TaskNode(id, name, priority, dueDate);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void RemoveByTaskId(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            TaskNode temp = head;
            TaskNode prev = null;

            do
            {
                if (temp.TaskId == id)
                {
                    if (temp == head)
                    {
                        TaskNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }

                        head = head.Next;
                        last.Next = head;
                        current = head;
                    }
                    else
                    {
                        prev.Next = temp.Next;
                    }

                    Console.WriteLine("Task removed successfully");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Task not found");
        }

        public void ViewCurrentAndMoveNext()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            DisplayTask(current);
            current = current.Next;
        }

        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks to display");
                return;
            }

            TaskNode temp = head;
            do
            {
                DisplayTask(temp);
                temp = temp.Next;
            } while (temp != head);
        }

        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            bool found = false;

            do
            {
                if (temp.Priority == priority)
                {
                    DisplayTask(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
            {
                Console.WriteLine("No task found with given priority");
            }
        }

        private void DisplayTask(TaskNode task)
        {
            Console.WriteLine("Task Id: " + task.TaskId +", Name: " + task.TaskName +", Priority: " + task.Priority +", Due Date: " + task.DueDate.ToShortDateString());
        }
    }

    class TaskSchedulerMain
    {
        static void Main(string[] args)
        {
            TaskSchedulerUtility scheduler = new TaskSchedulerUtility();

            scheduler.AddAtEnd(1, "Design Module", 1, DateTime.Now.AddDays(3));
            scheduler.AddAtEnd(2, "Code Review", 2, DateTime.Now.AddDays(5));
            scheduler.AddAtBeginning(3, "Fix Bugs", 1, DateTime.Now.AddDays(1));
            scheduler.AddAtPosition(4, "Write Tests", 3, DateTime.Now.AddDays(4), 2);

            Console.WriteLine("All Tasks:");
            scheduler.DisplayAllTasks();

            Console.WriteLine("\nView Current Task:");
            scheduler.ViewCurrentAndMoveNext();

            Console.WriteLine("\nNext Task:");
            scheduler.ViewCurrentAndMoveNext();

            Console.WriteLine("\nSearch Tasks by Priority 1:");
            scheduler.SearchByPriority(1);

            Console.WriteLine("\nRemove Task with ID 2:");
            scheduler.RemoveByTaskId(2);

            Console.WriteLine("\nFinal Task List:");
            scheduler.DisplayAllTasks();
        }
    }
}
