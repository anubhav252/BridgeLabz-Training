using System;
using System.IO;
using System.Runtime.CompilerServices;
class FilterRecordsInCsv
{
    static void Main(string[] args)
    {
        string path="students.csv";
        if (!File.Exists(path))
        {
            System.Console.WriteLine("File not found!");
            return;
        }
        try
        {
            using (StreamReader reader=new StreamReader(path))
            {
                string line;
                bool isHeader=true;
                
                System.Console.WriteLine("students who got more than 80 marks");
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader=false;
                        continue;
                    }
                    string[] record=line.Split(',');
                    if(int.Parse(record[3])>80)
                    {
                        System.Console.WriteLine($"ID : {record[0]} | Name : {record[1] } | Age : {record[2]} | Marks : {record[3]}");
                    }
                }
            }

        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}