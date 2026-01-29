class SearchInCsv
{
    static void Main(string[] args)
    {
        string path="employees.csv";
        try
        {
            System.Console.WriteLine("Eneter name to be search---");
            string name=Console.ReadLine();
            using(StreamReader reader=new StreamReader(path))
            {
                string line;
                bool isHeader=true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader=false;
                        continue;
                    }
                    string[] records=line.Split(',');
                    if (name.Equals(records[1],StringComparison.OrdinalIgnoreCase))
                    {
                        System.Console.WriteLine($"Department : {records[2]} | Salary : {records[3]}");
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