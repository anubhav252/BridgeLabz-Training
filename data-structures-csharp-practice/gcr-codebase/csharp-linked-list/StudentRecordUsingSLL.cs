using System;
class StudentNode{
	public int RollNumber;
	public string StudentName;
	public int Age;
	public char Grade;
	public StudentNode Next;
	
	public StudentNode(int rollNumber,string studentName,int age,char grade){
		RollNumber=rollNumber;
		StudentName=studentName;
		Age=age;
		Grade=grade;
		Next=null;
	}
}

class StudentUtility{
	private StudentNode head;
	public void AddAtBeginning(int rollNumber,string studentName,int age,char grade){
		StudentNode newNode=new StudentNode(rollNumber,studentName,age,grade);
		newNode.Next=head;
		head=newNode;
	}
	
	public void AddAtEnd(int rollNumber,string studentName,int age,char grade){
		StudentNode newNode=new StudentNode(rollNumber,studentName,age,grade);
		if(head==null){
			head=newNode;
			return;
		}
		StudentNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
	}
	
	public void AddAtPosition(int roll, string StudentName, int age, char grade, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(roll, StudentName, age, grade);
                return;
            }

            StudentNode newNode = new StudentNode(roll, StudentName, age, grade);
            StudentNode temp = head;

            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
	
	public void DeleteByRollNumber(int roll)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.RollNumber == roll)
        {
            head = head.Next;
            Console.WriteLine("Student record deleted");
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNumber != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted");
        }
    }

    public void SearchByRollNumber(int roll)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                DisplayStudent(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    public void UpdateGrade(int roll, char newGrade)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No student records available");
            return;
        }

        StudentNode temp = head;
        while (temp != null)
        {
            DisplayStudent(temp);
            temp = temp.Next;
        }
    }

    private void DisplayStudent(StudentNode student)
    {
        Console.WriteLine("Roll No: " + student.RollNumber +", Name: " + student.StudentName +", Age: " + student.Age +", Grade: " + student.Grade);
    }
}
    

class StudentMain{
    static void Main(string[] args)
    {
        StudentUtility list = new StudentUtility();

        list.AddAtEnd(1, "Alice", 20, 'A');
        list.AddAtEnd(2, "Bob", 21, 'B');
        list.AddAtBeginning(3, "Charlie", 19, 'A');
        list.AddAtPosition(4, "Diana", 22, 'C', 2);

        Console.WriteLine("All Student Records:");
        list.DisplayAll();

        Console.WriteLine("\nSearch Student with Roll No 2:");
        list.SearchByRollNumber(2);

        Console.WriteLine("\nUpdate Grade for Roll No 4:");
        list.UpdateGrade(4, 'B');

        Console.WriteLine("\nDelete Student with Roll No 1:");
        list.DeleteByRollNumber(1);

        Console.WriteLine("\nFinal Student Records:");
        list.DisplayAll();
    }
}