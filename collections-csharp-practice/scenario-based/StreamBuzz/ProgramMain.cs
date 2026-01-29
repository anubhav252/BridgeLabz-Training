using System;
using System.Collections.Generic;
namespace StreamBuzz
{
    class ProgramMain
    {
        public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();
        public void RegisterCreator(CreatorStats record)
        {
            EngagementBoard.Add(record);
        }

        public Dictionary<string,int> GetTopPostCounts(List<CreatorStats> records,double likeThreshold)
        { 
            Dictionary<string,int> topCounts=new Dictionary<string,int>();
            foreach(var likes in records)
            {
                int count=0;
                for(int i = 0; i < 4; i++)
                {
                    if (likes.WeeklyLikes[i] >= likeThreshold)
                    {
                        count++;
                    }
                }
                topCounts[likes.CreatorName]=count;
            }

            return topCounts;
        }
        public double CalculateAverageLikes()
        {
            double sum=0;
            double count=0;
            foreach(var likes in EngagementBoard)
            {
                for(int i = 0; i < 4; i++)
                {
                    sum+=likes.WeeklyLikes[i];
                    count++;
                }  
            }
            return (sum/count);
        }
        static void Main(string[] args)
        {
            ProgramMain obj=new ProgramMain();
            while (true)
            {
                System.Console.WriteLine("1.Register Creator \n2.Show Top Posts \n3.Calculate Average Likes \n4.Exit \nEnter your choice");
                int choice =int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1 :
                        System.Console.WriteLine("Enter Creator Name:");
                        string name=Console.ReadLine();
                        double[] weeklyLikes=new double[4];
                        System.Console.WriteLine("Enter weekly likes(Week 1 to 4):");
                        for(int i = 0; i < 4; i++)
                            {
                                weeklyLikes[i]=double.Parse(Console.ReadLine());
                            }
                        CreatorStats newRecord=new CreatorStats();
                        newRecord.CreatorName=name;
                        newRecord.WeeklyLikes=weeklyLikes;
                        obj.RegisterCreator(newRecord);
                        System.Console.WriteLine("Creator registered successfully");
                        System.Console.WriteLine();
                        break;
                    
                    case 2:
                        System.Console.WriteLine("Enter like threshold");
                        double likeThreshold=double.Parse(Console.ReadLine());
                        var topCounts=obj.GetTopPostCounts(EngagementBoard,likeThreshold);
                        foreach(var record in topCounts)
                            {
                                System.Console.WriteLine($"{record.Key}-{record.Value}");
                            }
                        System.Console.WriteLine();
                        break;

                    case 3:
                        System.Console.WriteLine($"Overall average weekly likes: {obj.CalculateAverageLikes()}");
                        System.Console.WriteLine();
                        break;

                    case 4:
                        System.Console.WriteLine("Logging off-Keep Creating with StreamBuzz!");
                        return;


                }

            }
        }
    }
}