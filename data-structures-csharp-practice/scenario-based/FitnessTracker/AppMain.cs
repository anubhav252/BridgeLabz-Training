using System;
namespace FitnessTrackerBubbleSort
{
    class AppMain
    {
        static void Main(string[] args)
        {
            Data[] data=new Data[5];
            data[0]=new Data("Alice",5000);
            data[1]=new Data("Bob",3000);
            data[2]=new Data("Charlie",7000);
            data[3]=new Data("Diana",6000);
            data[4]=new Data("Ethan",4000);
            IAppOperation utility=new AppUtility();
            utility.SortDataBySteps(data);
            Console.WriteLine("for updating data,enter 1 : ");
            int choice=Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                utility.UpdateData(data);
            }
        }
    }
}