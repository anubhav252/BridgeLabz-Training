using System;
namespace CourseManagement
{
    public abstract class CourseType
    {
        public string CourseName { get; set; }

        public CourseType(string courseName)
        {
            CourseName = courseName;
        }
        public abstract void EvaluateStudent(string studentName);
    }
    public class ExamCourse : CourseType
    {
        public ExamCourse(string courseName)
            : base(courseName)
        {
        }
        public override void EvaluateStudent(string studentName)
        {
            Console.WriteLine($"{studentName} evaluated by written exam in {CourseName}");
        }
    }
    public class AssignmentCourse : CourseType
    {
        public AssignmentCourse(string courseName)
            : base(courseName)
        {
        }
        public override void EvaluateStudent(string studentName)
        {
        Console.WriteLine($"{studentName} evaluated by assignments in {CourseName}");
        }
    }
    public class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        public void EvaluateAll(string studentName)
        {
            foreach (var course in courses)
            {
                course.EvaluateStudent(studentName);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "John Doe";
            string student2 = "Jane Smith";
            Course<ExamCourse> examCourseManager = new Course<ExamCourse>();
            examCourseManager.AddCourse(new ExamCourse("Mathematics"));
            examCourseManager.AddCourse(new ExamCourse("Physics"));

            Course<AssignmentCourse> assignmentCourseManager = new Course<AssignmentCourse>();
            assignmentCourseManager.AddCourse(new AssignmentCourse("Literature"));
            assignmentCourseManager.AddCourse(new AssignmentCourse("History"));

            

            Console.WriteLine("Evaluating Exam Courses:");
            examCourseManager.EvaluateAll(student1);

            Console.WriteLine("\nEvaluating Assignment Courses:");
            assignmentCourseManager.EvaluateAll(student2);
        }
    }
}