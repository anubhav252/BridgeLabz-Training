using System;
namespace ResumeScreeningSystem
{
    public abstract class JobRole
    {
        public string CandidateName { get; set; }
        public int Experience { get; set; }

        public JobRole(string candidateName, int experience)
        {
            CandidateName = candidateName;
            Experience = experience;
        }
        public abstract void ScreenResume();
    }
    public class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer(string name, int experience): base(name, experience)
        {
        }

        public override void ScreenResume()
        {
            Console.WriteLine($"Software Engineer Candidate: {CandidateName}, " +$"Experience: {Experience} years — Skills evaluated: C#, DSA, OOP");
        }
    }
    public class DataScientist : JobRole
    {
        public DataScientist(string name, int experience): base(name, experience)
        {
        }
        public override void ScreenResume()
        {
            Console.WriteLine($"Data Scientist Candidate: {CandidateName}, " +$"Experience: {Experience} years — Skills evaluated: Python, ML, SQL");
        }
    }
    public class Resume<T> where T : JobRole
    {
        private List<T> candidates = new List<T>();

        public void AddResume(T candidate)
        {
            candidates.Add(candidate);
        }

        public void ScreenAll()
        {
            Console.WriteLine("\n--- Resume Screening Started ---");

            foreach (T candidate in candidates)
            {
                candidate.ScreenResume();
            }
        }
    }

    public static class ResumeProcessor
    {
        public static void ProcessResumes<T>(List<T> resumes)
        where T : JobRole
        {
            Console.WriteLine("\n=== AI Screening Pipeline ===");

            foreach (T resume in resumes)
            {
                resume.ScreenResume();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
            seResumes.AddResume(new SoftwareEngineer("Alice", 4));
            seResumes.AddResume(new SoftwareEngineer("Bob", 2));
    
            Resume<DataScientist> dsResumes = new Resume<DataScientist>();
            dsResumes.AddResume(new DataScientist("Charlie", 3));
            dsResumes.AddResume(new DataScientist("Diana", 5));
            
            seResumes.ScreenAll();
            dsResumes.ScreenAll();
            ResumeProcessor.ProcessResumes(new List<SoftwareEngineer>{new SoftwareEngineer("Ethan", 6),new SoftwareEngineer("Fiona", 1)});
        }
    }
}


