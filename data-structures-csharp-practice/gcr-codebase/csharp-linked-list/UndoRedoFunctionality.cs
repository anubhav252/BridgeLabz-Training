using System;

namespace UndoRedoFunctionality
{
   class TextStateNode
   {
       public string Content;
       public TextStateNode Previous;
       public TextStateNode Next;

       public TextStateNode(string content)
       {
           Content = content;
           Previous = null;
           Next = null;
       }
   }

   class TextEditorUtility
   {
       private TextStateNode head;
       private TextStateNode tail;
       private TextStateNode current;
       private int stateCount;
       private const int MAX_HISTORY = 10;

       public void AddState(string content)
       {
           TextStateNode newNode = new TextStateNode(content);

           if (head == null)
           {
               head = tail = current = newNode;
               stateCount = 1;
               return;
           }

           if (current != tail)
           {
               current.Next = null;
               tail = current;
           }

           tail.Next = newNode;
           newNode.Previous = tail;
           tail = newNode;
           current = newNode;
           stateCount++;

           if (stateCount > MAX_HISTORY)
           {
               head = head.Next;
               head.Previous = null;
               stateCount--;
           }
       }

       public void Undo()
       {
           if (current != null && current.Previous != null)
           {
               current = current.Previous;
           }
           else
           {
               Console.WriteLine("No more undo available");
           }
       }

       public void Redo()
       {
           if (current != null && current.Next != null)
           {
               current = current.Next;
           }
           else
           {
               Console.WriteLine("No more redo available");
           }
       }

       public void DisplayCurrentState()
       {
           if (current == null)
           {
               Console.WriteLine("Editor is empty");
           }
           else
           {
               Console.WriteLine("Current Text: " + current.Content);
           }
       }
   }

   class Program
   {
       static void Main(string[] args)
       {
           TextEditorUtility editor = new TextEditorUtility();

           editor.AddState("Hello");
           editor.DisplayCurrentState();

           editor.AddState("Hello World");
           editor.DisplayCurrentState();

           editor.AddState("Hello World!");
           editor.DisplayCurrentState();

           Console.WriteLine("\nUndo:");
           editor.Undo();
           editor.DisplayCurrentState();

           Console.WriteLine("\nUndo:");
           editor.Undo();
           editor.DisplayCurrentState();

           Console.WriteLine("\nRedo:");
           editor.Redo();
           editor.DisplayCurrentState();

           Console.WriteLine("\nRedo:");
           editor.Redo();
           editor.DisplayCurrentState();
       }
   }
}
